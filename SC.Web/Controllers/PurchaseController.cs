using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SC.Data;
using SC.Service.Interface;
using SC.Service;
namespace SC.Web.Controllers
{
    public class PurchaseController : Controller
    {
        private readonly IPurchaseService _IPurchaseService;
        private readonly IPurchaseReturnService _IPurchaseReturnService;
        private readonly IItemService _IItemService;
        private readonly IMapper _mapper;
        private readonly ICOAService _ICOAService;
        public PurchaseController(IPurchaseService iPurchaseService, IMapper mapperService, IItemService itemService, ICOAService COAService, IPurchaseReturnService purchaseReturnService)
        {
            _IPurchaseService = iPurchaseService;
            _mapper = mapperService;
            _IItemService = itemService;
            _ICOAService = COAService;
            _IPurchaseReturnService = purchaseReturnService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PurchaseOrderLoad()
        {
            return View("../Purchase/View_PurchaseList");
        }
        public IActionResult SupplierPayment()
        {
            return View("../Purchase/View_SupplierPayment");
        }

        public IActionResult PurchaseOrder()
        {
            return View("../Purchase/View_PurchaseStockItems");
        }
        public IActionResult NewPurchaseOrder()
        {
            return View("../Purchase/View_NewPurchaseOrder");
        }
        public IActionResult NewOrder(long Id = 0)
        {
            var model = _IPurchaseService.GetPurchaseOrder(Id);
            if (model == null)
            {
                model = new Purchase();
                model.orderdate = DateTime.Now;
            }
            return View("View_NewPurchase", model);
        }


        [HttpGet]
        public ActionResult GetPurchaseOrder()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IPurchaseService.GetAllPurchaseOrder();
            int totalRecords = Results.Count();
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)10);
            var result = new
            {
                total = Results.Count,
                page = 1,
                records = totalRecords,
                rows = Results
            };
            return Json(result);
        }

        [HttpGet]
        public ActionResult GetPurchaseOrderDetails(long PurchaseOrderId)
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IPurchaseService.GetAllPurchaseOrderDetail().Where(x => x.PurchaseOrderId == PurchaseOrderId).ToList();
            int totalRecords = Results.Count();
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)10);
            var result = new
            {
                total = Results.Count,
                page = 1,
                records = totalRecords,
                rows = Results
            };
            return Json(result);
        }

        [HttpPost]
        public ActionResult SavePurchaseOrder(Purchase Purchase)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                ModelState.Remove("Id");
                if (ModelState.IsValid)
                {

                    if (Purchase.Id > 0)
                    {
                        _IPurchaseService.UpdatePurchaseOrder(Purchase);
                    }
                    else
                    {
                        _IPurchaseService.AddPurchaseOrder(Purchase);
                    }
                    return Json(new { id = Purchase.Id });
                }
                else
                {
                    var errorList = (from item in ModelState
                                     where item.Value.Errors.Any()
                                     select item.Value.Errors[0].ErrorMessage).ToList();

                    return Json(errorList);
                }
            }
            catch (Exception ex)
            {
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
        }
        [HttpPost]
        public ActionResult CreatePurchaseOrder(Purchase Purchase)
        {
            Purchase.balance = Purchase.Total;
            Purchase.orderdate = DateTime.Now;
            _IPurchaseService.AddPurchaseOrder(Purchase);
            return Json(new { Id = Purchase.Id });
        }

        [HttpPost]
        public ActionResult Savepurchasepaiddetail(List<purchasepaiddetail> purchasepaiddetails)
        {
            StringBuilder msg = new StringBuilder();
            List<string> vouchers=new List<string>();
            try
            {
                foreach (var item in purchasepaiddetails)
                {
                    item.paiddate = DateTime.Now;
                    _IPurchaseService.AddPurchasePaidDetails(item);
                    var model=_IPurchaseService.GetAllPurchaseOrder().Where(x=>x.Id==item.PurchaseOrderId).First();
                    model.balance = model.balance - item.amount;
                    _IPurchaseService.UpdatePurchaseOrder(model);
                    var voucherno = "VR/"+model.invoiceno;
                    item.voucherno = voucherno;
                    _IPurchaseService.UpdatePaidDetails(item);
                    vouchers.Add(voucherno);
                    var ledid = _ICOAService.GetAllledger().Where(x => x.partnerId == model.Supplier.partnerId).Select(x => x.Id).First();
                    ledgertxn suppled = new ledgertxn();
                    suppled.dr = item.amount;
                    suppled.cr = 0;
                    suppled.txndate = DateTime.Now.Date;
                    suppled.ledgerId = ledid;
                    suppled.details = "Payment For" + model.refno + model.invoiceno;
                    suppled.txnno = model.refno;
                    _ICOAService.AddLedgertxn(suppled);
                    ledgertxn led = new ledgertxn();
                    led.dr = 0;
                    led.cr = item.amount;
                    led.txndate = DateTime.Now.Date;
                    led.ledgerId = 21;
                    led.details = "Payment For" + model.refno + model.invoiceno;
                    led.txnno = model.refno;
                    _ICOAService.AddLedgertxn(led);
                }
            }

            catch (Exception ex)
            {
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
            return Json(new { vouchers, message = "Success" });
        }

        [HttpPost]
        public ActionResult SavePurchaseDetails(List<PurchaseDetail> PurchaseOrderItems)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                _IPurchaseService.DeletePurchaseOrderDetails(PurchaseOrderItems[0].PurchaseOrderId);
                foreach (var item in PurchaseOrderItems)
                {
                    _IPurchaseService.AddPurchaseOrderDetails(item);

                }
            }

            catch (Exception ex)
            {
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
            return Json("Success");
        }


        [HttpPost]
        public IActionResult ProcessPurchase(long Id)
        {
            try
            {
                var order = _IPurchaseService.GetPurchaseOrder(Id);
                order.Status = 2;
                _IPurchaseService.UpdatePurchaseOrder(order);
                var items=_IPurchaseService.GetAllPurchaseOrderDetail().Where(x=>x.PurchaseOrderId==Id).ToList();
                foreach (var item in items)
                {
                    var stock = _IItemService.GetStockMaster().Where(x => x.ItemMasterId == item.ItemMasterId && x.PurPrice == item.amount).FirstOrDefault();
                    if (stock == null)
                    {
                        stock = new StockMaster();
                        stock.ItemMasterId = item.ItemMasterId;
                        stock.stock = item.qty;
                        _IItemService.AddStockMaster(stock);
                    }
                    else
                    {
                        stock.stock = stock.stock + item.qty;
                        _IItemService.UpdateStockMaster(stock);
                    }
                    var master=_IItemService.GetAllItemMaster().Where(x=>x.Id==item.ItemMasterId).FirstOrDefault();
                    //master.PurPrice=item.p
                }
                return Json("Success");
            }
            catch (Exception ex)
            {

                return Json(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult RemovePurchaseOrder(long Id)
        {
            try
            {
                var PurchaseOrderItems = _IPurchaseService.GetAllPurchaseOrderDetail().Where(x => x.PurchaseOrderId == Id).ToList();
                foreach (var item in PurchaseOrderItems)
                {
                    //_IPurchaseService.AddPurchaseOrderDetails(item);
                    var stock = _IItemService.GetStockMaster().Where(x => x.ItemMasterId == item.ItemMasterId && x.PurPrice == item.amount).FirstOrDefault();
                    if (stock == null)
                    {
                        stock = new StockMaster();
                        stock.ItemMasterId = item.ItemMasterId;
                        stock.stock = item.qty;
                        stock.PurPrice = item.amount;
                        _IItemService.AddStockMaster(stock);
                    }
                    else
                    {
                        stock.stock = stock.stock + item.qty;
                        _IItemService.UpdateStockMaster(stock);
                    }
                }
                var order= _IPurchaseService.GetPurchaseOrder(Id);
                order.Status = 0;
                _IPurchaseService.UpdatePurchaseOrder(order);
            }
            catch (Exception ex)
            {
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
            return Json("Success");
        }
        [HttpGet]
        public ActionResult SearchPurchase(string serfromdate = "", string sertodate = "", string serRefNo = "", string serInvNo = "", long serSupplier = 0)
        {
            serRefNo = serRefNo ?? "";
            serInvNo = serInvNo ?? "";
            DateTime From = serfromdate == null ? DateTime.MinValue : Convert.ToDateTime(serfromdate);
            DateTime To = sertodate == null ? DateTime.MaxValue : Convert.ToDateTime(sertodate);
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IPurchaseService.GetAllPurchaseOrder().Where(x =>
            (x.refno.ToLower().Contains(serRefNo.ToLower()) || serRefNo == "")
            && (x.invoiceno.ToLower().Contains(serInvNo.ToLower()) || serInvNo == "")
            && (x.SupplierId==serSupplier || serSupplier == 0)
            && (x.orderdate >= From && x.orderdate <= To)).ToList();
            int totalRecords = Results.Count();
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)10);
            var result = new
            {
                total = Results.Count,
                page = 1,
                records = totalRecords,
                rows = Results
            };
            return Json(result);
        }

        [HttpPost]
        public ActionResult Savepurchasereturn(purchasereturn purchasereturn)
        {
            //_ISalesService.DeleteSalesDetail(7);

            //return Json(new { id = 7 });
            try
            {
                ModelState.Remove("Id");


                if (purchasereturn.Id > 0)
                {
                    _IPurchaseReturnService.Updatepurchasereturn(purchasereturn);
                }
                else
                {

                    _IPurchaseReturnService.Addpurchasereturn(purchasereturn);
                }
                _IPurchaseReturnService.DeletepurchasereturnDetails(purchasereturn.Id);

                return Json(new { id = purchasereturn.Id });

            }
            catch (Exception ex)
            {
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
        }
        [HttpPost]
        public ActionResult SavepurchasereturnDetail(List<purchasereturnDetail> purchasereturnDetail)
        {
            try
            {
                var amount = purchasereturnDetail.Sum(x => x.amount * x.qty);
                var purchasereturn = _IPurchaseReturnService.GetAllpurchasereturn().Where(x => x.Id == purchasereturnDetail[0].purchasereturnId).FirstOrDefault();
                amount = amount * -1;
                var model = new Purchase();

                model.balance = amount;
                model.SupplierId = purchasereturn.Purchase.SupplierId;
                model.details = purchasereturn.Purchase.details;
                model.Discount = 0;
                model.Total = amount;


                purchasereturn.Total = amount;
                _IPurchaseReturnService.Updatepurchasereturn(purchasereturn);
                _IPurchaseService.AddPurchaseOrder(model);
                foreach (var item in purchasereturnDetail)
                {


                    _IPurchaseReturnService.AddpurchasereturnDetail(item);


                    var detail = new PurchaseDetail
                    {
                        amount = item.amount * -1,
                        qty = item.qty,
                        ItemMasterId=item.ItemMasterId,
                        PurchaseOrderId= model.Id,
                    };
                    _IPurchaseService.AddPurchaseOrderDetails(detail);


                   var stock = new StockMaster();
                    stock.ItemMasterId = item.ItemMasterId;
                    stock.stock = item.qty * -1;
                    _IItemService.AddStockMaster(stock);

                }
            }

            catch (Exception ex)
            {
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
            return Json("Success");
        }
        [HttpGet]
        public ActionResult GetPurchaseReturn()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IPurchaseReturnService.GetAllpurchasereturn();
            int totalRecords = Results.Count();
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)10);
            var result = new
            {
                total = Results.Count,
                page = 1,
                records = totalRecords,
                rows = Results
            };
            return Json(result);
        }

        [HttpGet]
        public ActionResult GetPurchaseReturnDetails(long PurchasereturnId)
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IPurchaseReturnService.GetAllpurchasereturnDetail().Where(x => x.purchasereturnId == PurchasereturnId).ToList();
            int totalRecords = Results.Count();
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)10);
            var result = new
            {
                total = Results.Count,
                page = 1,
                records = totalRecords,
                rows = Results
            };
            return Json(result);
        }
        [HttpGet]
        public ActionResult GetPurchaseOrderbyInvoice(string invoiceNo)
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IPurchaseService.GetAllPurchaseOrder().Where(x => x.refno == invoiceNo).FirstOrDefault();
            var result = new
            {
                page = 1,
                rows = Results
            };
            return Json(result);
        }

        public IActionResult PurchaseReturnLoad()
        {
            return View("../Purchase/View_PurchaseReturnList");
        }
        public IActionResult PurchaseReturn()
        {
            return View("../Purchase/View_PurchaseReturn");
        }

        [HttpGet]
        public ActionResult SearchPurchaseReturn(string serfromdate = "", string sertodate = "", string serRefNo = "", string serInvNo = "", long serSupplier = 0)
        {
            serRefNo = serRefNo ?? "";
            serInvNo = serInvNo ?? "";
            DateTime From = serfromdate == null ? DateTime.MinValue : Convert.ToDateTime(serfromdate);
            DateTime To = sertodate == null ? DateTime.MaxValue : Convert.ToDateTime(sertodate);
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IPurchaseReturnService.GetAllpurchasereturn().Where(x =>
            (x.invoiceno.ToLower().Contains(serInvNo.ToLower()) || serInvNo == "")
            && (x.Purchase.refno.ToLower().Contains(serRefNo.ToLower()) || serRefNo == "")
            && (x.Purchase.SupplierId == serSupplier || serSupplier == 0)
            && (x.retdate >= From && x.retdate <= To)).ToList();
            int totalRecords = Results.Count();
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)10);
            var result = new
            {
                total = Results.Count,
                page = 1,
                records = totalRecords,
                rows = Results
            };
            return Json(result);
        }
    }
}