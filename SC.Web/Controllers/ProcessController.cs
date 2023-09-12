using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SC.Data;
using SC.Service.Interface;

namespace SC.Web.Controllers
{
    public class ProcessController : Controller
    {
        private readonly ISalesService _ISalesService;
        private readonly IItemService _IItemService;
        private readonly IMapper _mapper;
        private readonly ICOAService _ICOAService;
        public ProcessController(ISalesService salesService, IMapper mapperService, IItemService itemService, ICOAService COAService)
        {
            _ISalesService = salesService;
            _mapper = mapperService;
            _IItemService = itemService;
            _ICOAService = COAService;

        }
        public IActionResult SalesOrderProcessLoad()
        {
            return View("../Process/View_SalesOrderProcessLoad");
        }
        public IActionResult SalesOrderSplit(long SalesOrderId)
        {
            var data = _ISalesService.GetSalesOrder(SalesOrderId);
            return View("../Process/View_SalesOrderSplit", data);
        }
        public IActionResult NewSales(long SalesOrderId)
        {
            var data = _ISalesService.GetSalesOrder(SalesOrderId);
            var model = new Sales();
            model.salesdate = DateTime.Now;
            model.SalesOrderId = data.Id;
            model.Total = data.Total;
            model.balance = data.Total;
            model.details = data.details;
            model.CustomerId = data.CustomerId;
            return View("../Process/View_NewSales", model);
        }
        [HttpGet]
        public ActionResult GetSalesOrder()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSalesOrder().Where(x => x.Status == 1).ToList();
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
        public ActionResult GetSalesOrderDetails(long SalesOrderId)
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSalesOrderDetail().Where(x => x.SalesOrderId == SalesOrderId).ToList();
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
        public ActionResult SearchSalesOrders(string serfromdate = "", string sertodate = "", string serRefNo = "")
        {
            serRefNo = serRefNo ?? "";
            DateTime From = serfromdate == null ? DateTime.MinValue : Convert.ToDateTime(serfromdate);
            DateTime To = sertodate == null ? DateTime.MaxValue : Convert.ToDateTime(sertodate);
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSalesOrder().Where(x => x.Status == 1 &&
            (x.refno.ToLower().Contains(serRefNo.ToLower()) || serRefNo == "")
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

        private int checkcredit(long CustomerId)
        {
            var sal = _ISalesService.GetAllSales().Where(x => x.balance != 0 && x.CustomerId == CustomerId).Count();
            if (sal == 0)
                return 0;
            var query = _ISalesService.GetAllSales().Where(x => x.balance != 0 && x.CustomerId == CustomerId).GroupBy(x => x.CustomerId).Select(x => new
            {
                CustomerId = x.Max(y => y.CustomerId),
                Total = x.Sum(y => y.balance),
                Due = x.Min(y => y.CreatedDate),
                customerName = x.Max(y => y.Customer.CustomerName),
                creditdays = x.Max(y => y.Customer.creditdays),
                creditlimit = x.Max(y => y.Customer.creditlimit)
            }).FirstOrDefault();
            if (query.Total > query.creditlimit)
                return 1;
            if (query.Due.AddDays(query.creditdays) < DateTime.Now)
                return 2;
            return 0;
        }

        [HttpPost]
        public IActionResult UpdateProcessed(long[] Ids, bool Isvat = false)
        {
            long[] resps = new long[Ids.Length];
            int i = 0;
            var orders = _ISalesService.GetAllSalesOrder().Where(x => Ids.Contains(x.Id)).Distinct().ToList();

            foreach (var item in orders)
            {
                var check = checkcredit(item.CustomerId);
                if (check == 1)
                    return Json(new { resp = resps, message = "Credit Limit Over for Customer " + item.Customer.CustomerName });
                if (check == 2)
                    return Json(new { resp = resps, message = "Credit Date Over for Customer " + item.Customer.CustomerName });
                var order = _ISalesService.GetAllSales().Where(x => x.SalesOrderId == item.Id).FirstOrDefault();
                if (order != null)
                    return Json(new { resp = resps, message = "Invoice already created for the order " + item.refno });
                var items= _ISalesService.GetAllSalesOrderDetail().Where(x => x.SalesOrderId == item.Id).Select(x=>new { x.ItemMasterId,x.qty,x.ItemMaster.ItemName }).ToList();
                
                foreach (var itm in items)
                {
                    var stock=_IItemService.GetStockMaster().Where(x => x.ItemMasterId == itm.ItemMasterId).Select(x=>x.stock).Sum();
                    if (stock < itm.qty)
                        return Json(new { resp = resps, message = string.Format("No Stock for item {0} in order {1}", itm.ItemName, item.refno) });
                }
                
                var total = Isvat ? item.Total * 1.05 : item.Total;
                var model = new Sales();
                model.invoiceno = "INV/" + item.refno;
                model.salesdate = DateTime.Now;
                model.SalesOrderId = item.Id;
                model.Total = total;
                model.lpono = item.lpono;
                model.Discount = item.Discount;
                model.balance = total;
                model.details = item.details;
                model.CustomerId = item.CustomerId;
                model.Isvat = Isvat;
                model.Status = 2;
                _ISalesService.AddSales(model);
                resps[i] = model.Id;
                i++;
                var SalesDetail = _ISalesService.GetAllSalesOrderDetail().Where(x => x.SalesOrderId == item.Id).ToList();
                foreach (var item1 in SalesDetail)
                {
                    var saledetail = new SalesDetail();
                    saledetail.ItemMasterId = item1.ItemMasterId;
                    saledetail.SalesId = model.Id;
                    saledetail.amount = item1.amount;
                    saledetail.qty = item1.qty;
                    saledetail.comments = item1.comments;
                    _ISalesService.AddSalesDetail(saledetail);
                    var stock=new StockMaster();
                    stock.ItemMasterId = item1.ItemMasterId;
                    stock.stock = item1.qty * -1;
                    stock.PurPrice = item1.amount;
                    _IItemService.AddStockMaster(stock);
                }
                item.Status = 2;
                _ISalesService.UpdateSalesOrder(item);
                //if (SalesDetail.Count > 0)
                //{
                //    var sales = _ISalesService.GetAllSales().Where(x => x.Id == model.Id).FirstOrDefault();
                //    var cost = _ISalesService.GetAllSalesDetail().Where(x => x.SalesId == sales.Id).Sum(x => x.cost * x.qty);

                //    ledgertxn led = new ledgertxn();
                //    led.dr = 0;
                //    led.cr = cost;
                //    led.txndate = DateTime.Now.Date;
                //    led.ledgerId = 14;
                //    led.details = sales.details;
                //    led.txnno = sales.invoiceno;
                //    _ICOAService.AddLedgertxn(led);

                //    ledgertxn ledcash = new ledgertxn();
                //    ledcash.cr = 0;
                //    ledcash.dr = cost;
                //    ledcash.txndate = sales.salesdate;
                //    ledcash.ledgerId = 20;
                //    ledcash.details = sales.details;
                //    ledcash.txnno = sales.invoiceno;
                //    _ICOAService.AddLedgertxn(ledcash);
                //}
            }
            return Json(new { resp = resps, message = "Success" });

        }
        [HttpPost]
        public IActionResult UpdateRecipt(List<Salespaiddetail> Salespaiddetails)
        {
            foreach (var item in Salespaiddetails)
            {
                var recipt = _ICOAService.GetAllReceipt().Where(x => x.Id == item.SalesId).FirstOrDefault();
                recipt.balance = recipt.balance - item.amount;
                if (recipt.balance == 0)
                    item.Status = 2;
                _ICOAService.UpdateReceipt(recipt);
                var Trans = new ReceiptTransactions();
                Trans.ReceiptId = recipt.Id;
                Trans.amount = item.amount;
                _ICOAService.AddReceiptTransactions(Trans);

            }
            return Json(new { message = "Success" });
        }
        [HttpPost]
        public IActionResult UpdatePayment(List<Salespaiddetail> Salespaiddetails)
        {
            //var recipt = _ICOAService.GetAllPayment().Where(x => Salespaiddetails.Contains(x.Id)).ToList();
            foreach (var item in Salespaiddetails)
            {
                var recipt= _ICOAService.GetAllPayment().Where(x => x.Id==item.SalesId).FirstOrDefault();
                recipt.balance = recipt.balance - item.amount;
                if (recipt.balance == 0)
                    item.Status = 2;
                _ICOAService.UpdatePayment(recipt);
                PaymentTransactions Trans = new PaymentTransactions();
                Trans.PaymentId = recipt.Id;
                Trans.amount = item.amount;
                _ICOAService.AddPaymentTransactions(Trans);

            }
            return Json(new { message = "Success" });
        }
        [HttpPost]
        public IActionResult SplitOrder(long[] Ids, long OrderId)
        {
            var order = _ISalesService.GetSalesOrder(OrderId);
            var orders = _ISalesService.GetAllSalesOrderDetail().Where(x => Ids.Contains(x.Id)).ToList();
            var data = new SalesOrder
            {
                CustomerId = order.CustomerId,
                details = order.details,
                Discount = 0,
                orderdate = order.orderdate,
                Type = order.Type,
                Total = orders.Sum(x => x.amount),
            };
            _ISalesService.AddSalesOrder(data);
            foreach (var item in orders)
            {
                item.SalesOrderId = data.Id;
                _ISalesService.UpdateSalesOrderDetails(item);
            }
            order.Total = order.Total - data.Total;
            _ISalesService.UpdateSalesOrder(order);
            return Json("Success");

        }

        [HttpPost]
        public ActionResult SaveSales(Sales Sales)
        {
            //_ISalesService.DeleteSalesDetail(7);

            //return Json(new { id = 7 });
            try
            {
                ModelState.Remove("Id");
                if (ModelState.IsValid)
                {

                    if (Sales.Id > 0)
                    {
                        _ISalesService.UpdateSales(Sales);
                    }
                    else
                    {

                        _ISalesService.AddSales(Sales);
                    }
                    _ISalesService.DeleteSalesDetail(Sales.Id);


                    return Json(new { id = Sales.Id });
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
        public ActionResult SaveSalesOrderDetail(List<SalesDetail> SalesDetail)
        {
            try
            {
                Sales Sale = new Sales();
                foreach (var item in SalesDetail)
                {
                    _ISalesService.AddSalesDetail(item);
                    Sale = _ISalesService.GetSales(item.SalesId);
                    var saledetails = _ISalesService.GetAllSalesOrderDetail().Where(x => x.SalesOrderId == Sale.SalesOrderId.Value && x.ItemMasterId == item.ItemMasterId && x.Status == 1).FirstOrDefault();
                    saledetails.qty -= item.qty;
                    _ISalesService.UpdateSalesOrderDetails(saledetails);
                    //if (stock == null)
                    //{
                    //    stock = new StockMaster();
                    //    stock.ItemMasterId = item.ItemMasterId;
                    //    stock.stock -= item.qty;
                    //    _IItemService.AddStockMaster(stock);
                    //}
                    //else
                    //{
                    //    stock.stock = stock.stock - item.qty;
                    //    _IItemService.UpdateStockMaster(stock);
                    //}
                }
                var details = _ISalesService.GetAllSalesOrderDetail().Where(x => x.SalesOrderId == Sale.SalesOrderId.Value && x.qty > 0 && x.Status == 1);
                if (details.Count() == 0)
                {
                    var salesorder = _ISalesService.GetSalesOrder(Sale.SalesOrderId.Value);
                    salesorder.Status = 2;
                    _ISalesService.UpdateSalesOrder(salesorder);
                }
                //if (SalesDetail.Count > 0)
                //{
                //    var sales = _ISalesService.GetAllSales().Where(x => x.Id == SalesDetail[0].SalesId).FirstOrDefault();
                //    var cost = _ISalesService.GetAllSalesDetail().Where(x => x.SalesId == sales.Id).Sum(x => x.cost * x.qty);

                //    ledgertxn led = new ledgertxn();
                //    led.dr = 0;
                //    led.cr = cost;
                //    led.txndate = DateTime.Now.Date;
                //    led.ledgerId = 14;
                //    led.details = sales.details;
                //    led.txnno = sales.invoiceno;
                //    _ICOAService.AddLedgertxn(led);

                //    ledgertxn ledcash = new ledgertxn();
                //    ledcash.cr = 0;
                //    ledcash.dr = cost;
                //    ledcash.txndate = sales.salesdate;
                //    ledcash.ledgerId = 20;
                //    ledcash.details = sales.details;
                //    ledcash.txnno = sales.invoiceno;
                //    _ICOAService.AddLedgertxn(ledcash);
                //}
            }

            catch (Exception ex)
            {
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
            return Json("Success");
        }
    }
}