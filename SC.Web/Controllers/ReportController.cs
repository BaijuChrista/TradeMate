using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SC.Data;
using SC.Service.Interface;

namespace SC.Web.Controllers
{
    public class ReportController : Controller
    {

        private readonly IItemService _IItemService;
        private readonly IApplicationUserService _IApplicationUserService;
        private readonly ICOAService _ICOAService;
        private readonly IPurchaseService _IPurchaseService;
        private readonly ISalesService _ISalesService;
        private readonly ICustomerService _ICustomerService;
        private readonly ICurrencyService _ICurrencyService;
        public ReportController(IItemService iItemService, ICurrencyService currencyService, IApplicationUserService ApplicationUserService, ICOAService COAService, IPurchaseService purchaseService, ISalesService salesService, ICustomerService CustomerService)
        {
            _ICurrencyService = currencyService;
            _IItemService = iItemService;
            _IApplicationUserService = ApplicationUserService;
            _ICOAService = COAService;
            _IPurchaseService = purchaseService;
            _ISalesService = salesService;
            _ICustomerService = CustomerService;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult TransactionSummary()
        {
            return View("../Reports/View_TransactionSummary");
        }

        public IActionResult Dashboard1()
        {
            return View("../Reports/Dashboard1");
        }
        public IActionResult Dashboard2()
        {
            return View("../Reports/Dashboard2");
        }
        public IActionResult Dashboard3()
        {
            return View("../Reports/Dashboard3");
        }
        public IActionResult Dashboard4()
        {
            return View("../Reports/Dashboard4");
        }
        public IActionResult SalesOrderList()
        {
            return View("../Reports/View_SalesOrders");
        }
        public IActionResult NoStockItems()
        {
            return View("../Reports/View_NoStockItems");
        }
        public IActionResult OrderedItems()
        {
            return View("../Reports/View_OrderedItems");
        }
        public IActionResult SalesList()
        {
            return View("../Reports/View_SalesList");
        }
        public IActionResult Sheduler()
        {
            return View("../Reports/View_Sheduler");
        }
        public IActionResult DailyProcess()
        {
            return View("../Reports/View_DailyProcess");
        }

        public IActionResult MarginReport()
        {
            return View("../Reports/View_MarginReport");
        }
        public IActionResult VatSummary()
        {
            return View("../Reports/View_VatSummary");
        }

        #region "Financial"
        public IActionResult ProfitandLoss()
        {
            return View("../Reports/View_ProfitandLoss");
        }
        public IActionResult BalanceSheet()
        {
            return View("../Reports/View_BalanceSheet");
        }
        #endregion
        #region "Ledger"
        public IActionResult TrailBalance()
        {
            return View("../Reports/View_TrialBalance");
        }
        public IActionResult LedgerSummary()
        {
            return View("../Reports/View_LedgerSummary");
        }
        public IActionResult LedgerTransactions()
        {
            return View("../Reports/View_LedgerTransactions");
        }
        #endregion
        #region "Customers"
        public IActionResult AgedReceivables()
        {
            return View("../Reports/View_AgedReceivables");
        }
        public IActionResult CustomerSummary()
        {
            return View("../Reports/View_CustomerSummary");
        }
        public IActionResult ItemSummary()
        {
            return View("../Reports/View_ItemSummary");
        }
        public IActionResult CustomerSOA()
        {
            return View("../Reports/View_CustomerSOA");
        }
        public IActionResult DepositedAmount()
        {
            return View("../Reports/View_DepositedAmount");
        }
        #endregion
        #region "Supplier"
        public IActionResult AgedPayables()
        {
            return View("../Reports/View_AgedPayables");
        }
        public IActionResult SupplierSummary()
        {
            return View("../Reports/View_SupplierSummary");
        }
        public IActionResult SupplierSOA()
        {
            return View("../Reports/View_SupplierSOA");
        }
        #endregion
        #region "Inventory"
        public IActionResult InventoryValue()
        {
            return View("../Reports/View_InventoryValue");
        }
        public IActionResult InventoryQty()
        {
            return View("../Reports/View_InventoryQty");
        }
        public IActionResult InventoryProfitMargin()
        {
            return View("../Reports/View_InventoryProfitMargin");
        }
        #endregion

        [HttpGet]
        public ActionResult GetCOAType()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICOAService.GetAllCOAType().OrderBy(x => x.odr).ToList();
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
        public ActionResult GetCOATB()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICOAService.gettrialbalance();
            //int totalRecords = Results();
            var totalPages = (int)Math.Ceiling((float)100 / (float)10);
            var result = new
            {
                total = 100,
                page = 1,
                records = 100,
                rows = Results
            };
            return Json(result);
        }
        [HttpGet]
        public ActionResult GetBalanceSheet()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICOAService.getBalanceSheet();
            //int totalRecords = Results();
            var totalPages = (int)Math.Ceiling((float)100 / (float)10);
            var result = new
            {
                total = 100,
                page = 1,
                records = 100,
                rows = Results
            };
            return Json(result);
        }
        [HttpGet]
        public ActionResult GetPandL()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICOAService.getPandL();
            //int totalRecords = Results();
            var totalPages = (int)Math.Ceiling((float)100 / (float)10);
            var result = new
            {
                total = 100,
                page = 1,
                records = 100,
                rows = Results
            };
            return Json(result);
        }
        [HttpGet]
        public ActionResult GetCOATypePandL()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICOAService.GetAllCOAType().Where(x => x.Coabase.fs == 2).OrderBy(x => x.odr).ToList();
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
        public ActionResult GetCOATypeBalanceSheet()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICOAService.GetAllCOAType().Where(x => x.Coabase.fs == 1).OrderBy(x => x.odr).ToList();
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
        public ActionResult GetLedger()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICOAService.GetAllledger().ToList();
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
        public ActionResult GetLedgerDetails(long LedgerId)
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICOAService.GetAlllLedgertxn().Where(x => x.ledgerId == LedgerId).GroupBy(x => x.ledgerId).
                Select(x => new
                {
                    LedgerId = x.Key,
                    Dr = x.Sum(y => y.dr),
                    Cr = x.Sum(y => y.cr),
                })
                .ToList();
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
        public ActionResult GetLedgerTxns()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICOAService.GetAlllLedgertxn().ToList();
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
        public ActionResult SearchLedgerTxns(long serLedger = 0, long serCategory = 0, string serfromdate = "", string sertodate = "")
        {
            DateTime From = serfromdate == null ? DateTime.MinValue : Convert.ToDateTime(serfromdate);
            DateTime To = sertodate == null ? DateTime.MaxValue : Convert.ToDateTime(sertodate).AddDays(1).AddSeconds(-1);
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICOAService.GetAlllLedgertxn().Where(x =>
            (x.ledgerId == serLedger || serLedger == 0)
            && (x.ledger.coa.COATypeId == serCategory || serCategory == 0)
            && (x.txndate >= From && x.CreatedDate <= To)
            ).ToList();
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
        public ActionResult SearchPandL(string serfromdate = "", string sertodate = "")
        {
            DateTime From = serfromdate == null ? DateTime.MinValue : Convert.ToDateTime(serfromdate);
            DateTime To = sertodate == null ? DateTime.MaxValue : Convert.ToDateTime(sertodate).AddDays(1).AddSeconds(-1);
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICOAService.getPandL(From, To);
            int totalRecords = 100;
            var totalPages = (int)Math.Ceiling((float)100 / (float)10);
            var result = new
            {
                total = 100,
                page = 1,
                records = totalRecords,
                rows = Results
            };
            return Json(result);
        }
        [HttpGet]
        public ActionResult GetAgedPayables()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IPurchaseService.GetAllPurchaseOrder().Where(x => x.balance > 0).Select(x => new
            {
                x.SupplierId,
                x.Supplier.code,
                x.Supplier.SupplierName,
                First = (DateTime.Now - x.orderdate).Days <= 30 ? x.balance : 0,
                Second = ((DateTime.Now - x.orderdate).Days > 30 && (DateTime.Now - x.orderdate).Days <= 60) ? x.balance : 0,
                Third = ((DateTime.Now - x.orderdate).Days > 60 && (DateTime.Now - x.orderdate).Days <= 90) ? x.balance : 0,
                Fourth = ((DateTime.Now - x.orderdate).Days > 90 && (DateTime.Now - x.orderdate).Days <= 120) ? x.balance : 0,
                Fifth = (DateTime.Now - x.orderdate).Days > 120 ? x.balance : 0,
                total = x.balance
            }).GroupBy(x => x.SupplierId).Select(x => new
            {
                SupplierCode = x.Max(y => y.code),
                SupplierName = x.Max(y => y.SupplierName),
                First = x.Sum(y => y.First),
                Second = x.Sum(y => y.Second),
                Third = x.Sum(y => y.Third),
                Fourth = x.Sum(y => y.Fourth),
                Fifth = x.Sum(y => y.Fifth),
                total = x.Sum(y => y.total)
            }).ToList();
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
        public ActionResult GetAgedRecievables()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSales().Where(x => x.Total > 0).Select(x => new
            {
                x.CustomerId,
                x.Customer.code,
                x.Customer.CustomerName,
                First = (DateTime.Now - x.salesdate).Days <= 30 ? x.balance : 0,
                Second = ((DateTime.Now - x.salesdate).Days > 30 && (DateTime.Now - x.salesdate).Days <= 60) ? x.balance : 0,
                Third = ((DateTime.Now - x.salesdate).Days > 60 && (DateTime.Now - x.salesdate).Days <= 90) ? x.balance : 0,
                Fourth = ((DateTime.Now - x.salesdate).Days > 90 && (DateTime.Now - x.salesdate).Days <= 120) ? x.balance : 0,
                Fifth = (DateTime.Now - x.salesdate).Days > 120 ? x.balance : 0,
                total = x.balance
            }).GroupBy(x => x.CustomerId).Select(x => new
            {
                CustomerCode = x.Max(y => y.code),
                CustomerName = x.Max(y => y.CustomerName),
                First = x.Sum(y => y.First),
                Second = x.Sum(y => y.Second),
                Third = x.Sum(y => y.Third),
                Fourth = x.Sum(y => y.Fourth),
                Fifth = x.Sum(y => y.Fifth),
                total = x.Sum(y => y.total)
            }).ToList();
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
        public ActionResult GetSupplierSummery()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IPurchaseService.GetAllPurchaseOrder().Where(x => x.balance > 0).Select(x => new
            {
                x.SupplierId,
                x.Supplier.code,
                x.Supplier.SupplierName,
                Opening = (x.Supplier.dr - x.Supplier.cr),
                x.balance,
                total = x.Total
            }).GroupBy(x => x.SupplierId).Select(x => new
            {
                SupplierCode = x.Max(y => y.code),
                SupplierName = x.Max(y => y.SupplierName),
                balance = x.Sum(y => y.balance),
                Opening = x.Sum(y => y.Opening),
                total = x.Sum(y => y.total)
            }).ToList();
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
        public ActionResult GetCustomerSummery()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSales().Where(x => x.balance > 0).Select(x => new
            {
                x.CustomerId,
                x.Customer.code,
                x.Customer.CustomerName,
                Opening = (x.Customer.dr - x.Customer.cr),
                x.balance,
                total = x.Total
            }).GroupBy(x => x.CustomerId).Select(x => new
            {
                CustomerCode = x.Max(y => y.code),
                CustomerName = x.Max(y => y.CustomerName),
                balance = x.Sum(y => y.balance),
                Opening = x.Sum(y => y.Opening),
                total = x.Sum(y => y.total)
            }).ToList();
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
        public ActionResult GetInventoryProfitMargin()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSalesDetail().Select(x => new
            {
                x.ItemMasterId,
                x.ItemMaster.ItemCode,
                x.ItemMaster.ItemName,
                Profit = (x.amount * x.qty) - (x.cost * x.qty),
                amount = x.amount * x.qty,
                cost = x.cost * x.qty
            }).GroupBy(x => x.ItemMasterId).Select(x => new
            {
                ItemCode = x.Max(y => y.ItemCode),
                ItemName = x.Max(y => y.ItemName),
                Profit = x.Sum(y => y.Profit),
                amount = x.Sum(y => y.amount),
                cost = x.Sum(y => y.cost),
                margin = x.Sum(y => ((y.Profit) / y.amount) * 100)
            }).ToList();
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
        public ActionResult GetSupplierSOA()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IPurchaseService.GetAllPurchaseOrder().Where(x => x.balance > 0).Select(x => new
            {
                x.Id,
                x.details,
                x.orderdate,
                x.refno,
                x.invoiceno,
                x.Total,
                x.Supplier.SupplierName,
                Due = (DateTime.Now - x.orderdate).Days,
                x.balance
            }).ToList();
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
        public ActionResult GetCustomerSOA()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var test = _ISalesService.GetAllSales().ToList();
            var Results = _ISalesService.GetAllSales().Where(x => x.balance != 0).Select(x => new
            {
                x.Id,
                x.details,
                x.salesdate,
                refno = x.SalesOrder == null ? "" : x.SalesOrder.refno,
                x.invoiceno,
                x.Total,
                x.Customer.CustomerName,
                Due = (DateTime.Now - x.salesdate).Days,
                x.balance,
                x.Isvat
            }).ToList();
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
        public ActionResult GetSalesOrder()
        {
            long UserId = 0;
            var UserType = "";
            if (HttpContext.Session.GetString("UserId") != null)
            {
                UserId = int.Parse(HttpContext.Session.GetString("UserId"));
                UserType = HttpContext.Session.GetString("UserType");
            }
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSalesOrder().Where(x => (x.CreatedUserId == UserId || UserType == "Admin")).ToList();
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
        public ActionResult GetNoStockItems()
        {
            int pageIndex = Convert.ToInt32(1) - 1;


            var Results = _ISalesService.GetAllSalesOrderDetail().Where(x => x.SalesOrder.Status == 1).GroupBy(x => x.ItemMasterId).Select(x => new
            {
                ItemMasterId = x.Max(y => y.ItemMasterId),
                ItemName = x.Max(y => y.ItemMaster.ItemName),
                ItemCode = x.Max(y => y.ItemMaster.ItemCode),
                salesQty = x.Sum(y => y.qty)
            }).ToList()
            .Join(_IItemService.GetStockMaster().GroupBy(x => x.ItemMasterId).Select(x => new
            {
                ItemMasterId = x.Max(y => y.ItemMasterId),
                stock = x.Sum(y => y.stock),
                price = x.Max(y => y.PurPrice)
            }).ToList(),
                        sales => sales.ItemMasterId,
                        stock => stock.ItemMasterId,
                        (sales, stock) => new
                        {
                            orderd = sales.salesQty,
                            onHand = stock.stock,
                            balance = sales.salesQty - stock.stock,
                            Id = sales.ItemMasterId,
                            sales.ItemName,
                            sales.ItemCode,
                            stock.price
                        }).Where(x => x.balance > 0).ToList();
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
        public ActionResult GetOrderedList()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSalesOrderDetail().Where(x => x.SalesOrder.Status == 1).ToList();
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
        public ActionResult GetReOrderList(long ItemId = 0)
        {
            int pageIndex = Convert.ToInt32(1) - 1;

            var Results = _IItemService.GetStockMaster().Where(x => x.ItemMasterId == ItemId || ItemId == 0).GroupBy(x => x.ItemMasterId).Select(x => new
            {
                itemMasterId = x.Max(y => y.ItemMasterId),
                stock = x.Sum(y => y.stock),
                price = x.Max(y => y.PurPrice),
                rol = x.Max(y => y.ItemMaster.rol),
                itemName = x.Max(y => y.ItemMaster.ItemName),
                itemCode = x.Max(y => y.ItemMaster.ItemCode)
            }).Where(x => x.rol > x.stock).ToList();
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
        public ActionResult GetsaleDepositDetails()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSalespaiddetail().Where(x => x.Status == 2 && DateTime.Today == x.ModifiedDate.Date).GroupBy(x => x.CreatedUserId).Select(x => new
            {
                Total = x.Sum(y => y.amount),
                Count = x.Count(),
                Details = (x.Select(y => y.details)).Distinct().Aggregate((a, b) => (a + ", " + b)),
                Name = x.Max(y => y.ApplicationUser.Username)
            }).ToList();
            return Json(Results);
        }
        [HttpGet]
        public ActionResult GetInventoryValue(string serfromdate = "", string sertodate = "")
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            DateTime From = string.IsNullOrEmpty(serfromdate) ? DateTime.MinValue : Convert.ToDateTime(serfromdate);
            DateTime To = string.IsNullOrEmpty(sertodate) ? DateTime.MaxValue : Convert.ToDateTime(sertodate);
            var leftOuterJoin = from purchase in _IPurchaseService.GetAllPurchaseOrderDetail().Where(x => x.CreatedDate >= From && x.CreatedDate <= To && x.Purchase.Status == 2)
                                join sales in _ISalesService.GetAllSalesDetail()
                                on purchase.ItemMasterId equals sales.ItemMasterId
                                into temp
                                from sales in temp.DefaultIfEmpty()
                                select new
                                {
                                    SalesQty = 0.00,
                                    SalesAmt = 0.00,
                                    Qty = purchase.qty,
                                    Amount = purchase.amount * purchase.qty,
                                    ItemCode = purchase.ItemMaster.ItemCode,
                                    ItemName = purchase.ItemMaster.ItemName,

                                };
            var rightOuterJoin = from sales in _ISalesService.GetAllSalesDetail().Where(x => x.CreatedDate >= From && x.CreatedDate <= To)
                                 join purchase in _IPurchaseService.GetAllPurchaseOrderDetail()
                                 on sales.ItemMasterId equals purchase.ItemMasterId
                                 into temp
                                 from purchase in temp.DefaultIfEmpty()
                                 select new
                                 {
                                     SalesQty = sales.amount < 0 ? sales.qty * -1 : sales.qty,
                                     SalesAmt = sales.amount * sales.qty,
                                     Qty = 0.00,
                                     Amount = 0.00,
                                     ItemCode = sales.ItemMaster.ItemCode,
                                     ItemName = sales.ItemMaster.ItemName,
                                 };

            var Results = leftOuterJoin.Union(rightOuterJoin).GroupBy(x => x.ItemCode).Select(x => new
            {

                ItemCode = x.Max(y => y.ItemCode),
                ItemName = x.Max(y => y.ItemName),
                purchaseQty = x.Sum(y => y.Qty),
                purchaseAmt = x.Sum(y => y.Amount),
                salesQty = x.Sum(y => y.SalesQty),
                salesAmt = x.Sum(y => y.SalesAmt)
            }).ToList(); ;



            //var Results = _IPurchaseService.GetAllPurchaseOrderDetail().Join(_ISalesService.GetAllSalesDetail(),
            //     purchase => purchase.ItemMasterId,
            //    sales => sales.ItemMasterId,                       
            //            (purchase, sales) => new
            //            {


            //                purchaseQty = purchase.qty,
            //                purchaseAmt= purchase.amount * purchase.qty,
            //                salesQty = sales.qty,
            //                salesAmt= sales.amount * sales.qty,
            //               // balanceqty = purchase.qty - sales.qty,
            //               // balanceamt = (purchase.amount * purchase.qty) - (sales.amount * sales.qty),
            //                purchase.ItemMasterId,
            //                purchase.ItemMaster.ItemName,
            //                purchase.ItemMaster.ItemCode,
            //            }).GroupBy(x => x.ItemMasterId).Select(x => new
            //            {
            //                Id = x.Max(y => y.ItemMasterId),
            //                ItemCode = x.Max(y => y.ItemCode),
            //                ItemName = x.Max(y => y.ItemName),
            //                purchaseQty = x.Sum(y => y.purchaseQty),
            //                purchaseAmt= x.Sum(y => y.purchaseAmt),
            //                salesQty = x.Sum(y => y.salesQty),
            //                salesAmt = x.Sum(y => y.salesAmt)                           
            //            }).ToList();
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

        public ActionResult GetReciptprint(long id)
        {
            var voucher = _ISalesService.GetAllSalespaiddetail().Where(x => x.Id == id).FirstOrDefault();
            string details = "";
            if (voucher != null)
                details = voucher.details;
            var Results = _ISalesService.GetAllSalespaiddetail().Where(x => x.details == details).ToList();
            int totalRecords = Results.Count();
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)10);
            var result = new
            {
                total = Results.Count,
                page = 1,
                records = totalRecords,
                rows = Results.OrderByDescending(x => x.CreatedDate).ToList()
            };
            return Json(result);
        }
        [HttpGet]
        public ActionResult GettransationDetails(string serfrom = "", string serto = "", string servoucher = "", string serrv = "")
        {
            try
            {

                servoucher = servoucher ?? "";
                serrv = serrv ?? "";
                DateTime From = string.IsNullOrEmpty(serfrom) ? DateTime.MinValue : Convert.ToDateTime(serfrom);
                DateTime To = string.IsNullOrEmpty(serto) ? DateTime.MaxValue : Convert.ToDateTime(serto).AddDays(1).AddSeconds(-1);
                int pageIndex = Convert.ToInt32(1) - 1;
                var salestran = _ISalesService.GetAllSalespaiddetail().Where(x => x.CreatedDate >= From && x.CreatedDate <= To && (x.voucherno == servoucher || servoucher == "") && (x.details == serrv || serrv == "")).ToList();
                var purcahsetran = _IPurchaseService.GetPurchasePaidDetails().Where(x => x.CreatedDate >= From && x.CreatedDate <= To && (x.voucherno == servoucher || servoucher == "") && (x.details == serrv || serrv == "")).ToList();
                var Results = salestran.Select(x => new
                {
                    id = x.Id,
                    RefNo = x.details,
                    purchaseAmt = 0.0,
                    salesAmt = x.amount,
                    customername = x.Sales.Customer.CustomerName,
                    suppliername = "",
                    employee = x.ApplicationUser.Username,
                    trndate = x.paiddate,
                    x.Status,
                    voucher = x.voucherno,
                    x.Sales.invoiceno
                }).ToList();
                foreach (var x in purcahsetran)
                {
                    Results.Add(new
                    {
                        id = x.Id,
                        RefNo = x.details,
                        purchaseAmt = x.amount,
                        salesAmt = 0.0,
                        customername = "",
                        suppliername = x.Purchase.Supplier.SupplierName,
                        employee = x.ApplicationUser.Username,
                        trndate = x.paiddate,
                        x.Status,
                        voucher = x.voucherno,
                        x.Purchase.invoiceno
                    });
                }
                int totalRecords = Results.Count();
                var totalPages = (int)Math.Ceiling((float)totalRecords / (float)10);
                var result = new
                {
                    total = Results.Count,
                    page = 1,
                    records = totalRecords,
                    rows = Results.OrderByDescending(x => x.trndate).ToList()
                };
                return Json(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        [HttpGet]
        public ActionResult GetSalesList()
        {
            long UserId = 0;
            var UserType = "";
            if (HttpContext.Session.GetString("UserId") != null)
            {
                UserId = int.Parse(HttpContext.Session.GetString("UserId"));
                UserType = HttpContext.Session.GetString("UserType");
            }

            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSales().Where(x => (x.CreatedUserId == UserId || UserType == "Admin")).ToList();
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
        public ActionResult GetCustomerAlertList()
        {
            try
            {

                long UserId = 0;
                var UserType = "";
                if (HttpContext.Session.GetString("UserId") != null)
                {
                    UserId = int.Parse(HttpContext.Session.GetString("UserId"));
                    UserType = HttpContext.Session.GetString("UserType");
                }

                var salecust = _ISalesService.GetAllSales().GroupBy(x => x.CustomerId).Select(g => new
                {
                    date = g.Max(y => y.CreatedDate),
                    id = g.Key
                }).Where(x => x.date < DateTime.Now.AddDays(-30)).Select(y => y.id).ToArray();

                var query = _ICustomerService.GetAllCustomer().Where(x => salecust.Contains(x.Id)).ToList();
                var Result = new
                {
                    Alert = query.OrderBy(x => x.Zipcode).ToList()
                };
                return Json(Result);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpGet]
        public ActionResult GetItemAlertList()
        {
            try
            {

                long UserId = 0;
                var UserType = "";
                if (HttpContext.Session.GetString("UserId") != null)
                {
                    UserId = int.Parse(HttpContext.Session.GetString("UserId"));
                    UserType = HttpContext.Session.GetString("UserType");
                }

                var salecust = _ISalesService.GetAllSalesDetail().GroupBy(x => x.ItemMasterId).Select(g => new
                {
                    date = g.Max(y => y.CreatedDate),
                    id = g.Key
                }).Where(x => x.date < DateTime.Now.AddDays(-30)).Select(y => y.id).ToArray();

                var query = _IItemService.GetAllStockMaster().Where(x => x.Stock > 0 && salecust.Contains(x.ItemId)).GroupBy(x => x.ItemId).Select(g => new
                {
                    itemName = g.Max(y => y.ItemName),
                    stock = g.Sum(y => y.Stock)
                }).ToList();
                var Result = new
                {
                    Alert = query
                };
                return Json(Result);
            }
            catch (Exception ex)
            {

                throw;
            }
        }




        [HttpGet]
        public ActionResult GetAlertList()
        {
            try
            {

                long UserId = 0;
                var UserType = "";
                if (HttpContext.Session.GetString("UserId") != null)
                {
                    UserId = int.Parse(HttpContext.Session.GetString("UserId"));
                    UserType = HttpContext.Session.GetString("UserType");
                }

                var Shedule = _ICustomerService.GetAllCustomerUserAssign().Where(x => (x.AssignedUserId == UserId || UserType == "Admin")).Select(x => x.CustomerId).ToList();
                var query = _ISalesService.GetAllSales().Where(x => x.balance != 0 && Shedule.Contains(x.CustomerId)).GroupBy(x => x.CustomerId).Select(x => new
                {
                    CustomerId = x.Max(y => y.CustomerId),
                    Total = x.Sum(y => y.balance),
                    Due = x.Min(y => y.CreatedDate),
                    customerName = x.Max(y => y.Customer.CustomerName),
                    creditdays = x.Max(y => y.Customer.creditdays),
                    creditlimit = x.Max(y => y.Customer.creditlimit)
                }).Where(x => x.Total > x.creditlimit || x.Due.AddDays(x.creditdays) < DateTime.Now).Select(y => new
                {
                    y.CustomerId,
                    y.Total,
                    Due = y.Due.AddDays(y.creditdays),
                    y.customerName
                }).ToList();
                var Result = new
                {
                    Alert = query
                };
                return Json(Result);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpGet]
        public ActionResult CheckLimit(long CustomerId)
        {
            var sal = _ISalesService.GetAllSales().Where(x => x.balance != 0 && x.CustomerId == CustomerId).Count();
            if (sal == 0)
                return Json(new { msg = "Success" });
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
                return Json(new { msg = "Credit Limit Over for Customer " + query.customerName });
            if (query.Due.AddDays(query.creditdays) < DateTime.Now)
                return Json(new { msg = "Credit Days Over for Customer " + query.customerName });
            return Json(new { msg = "Success" });
        }

        [HttpGet]
        public ActionResult GetCreditCustomer()
        {

            var query = _ISalesService.GetAllSales().Where(x => x.balance != 0).GroupBy(x => x.CustomerId).Select(x => new
            {
                CustomerId = x.Max(y => y.CustomerId),
                Total = x.Sum(y => y.balance),
                Due = x.Min(y => y.CreatedDate),
                customerName = x.Max(y => y.Customer.CustomerName),
                creditdays = x.Max(y => y.Customer.creditdays),
                creditlimit = x.Max(y => y.Customer.creditlimit)
            }).ToList().Where(x => x.Total > x.creditlimit || x.Due.AddDays(x.creditdays) < DateTime.Now).Select(x => x.CustomerId).ToList();

            return Json(query);
        }

        [HttpGet]
        public ActionResult getDailyProcess(string serfrom = "", string serto = "")
        {
            try
            {

                DateTime From = string.IsNullOrEmpty(serfrom) ? DateTime.Now : Convert.ToDateTime(serfrom);
                DateTime To = string.IsNullOrEmpty(serto) ? DateTime.Now : Convert.ToDateTime(serto).AddDays(1);
                var sales = _ISalesService.GetAllSales().Where(x => x.CreatedDate.Date >= From.Date && x.CreatedDate.Date < To.Date).Select(x => x.Total).Sum();
                var purchase = _IPurchaseService.GetAllPurchaseOrder().Where(x => x.CreatedDate.Date >= From.Date && x.CreatedDate.Date < To.Date).Select(x => x.Total).Sum();
                var recipt = _ICOAService.GetReceiptTransactions().Where(x => x.CreatedDate.Date >= From.Date && x.CreatedDate.Date < To.Date).Select(x => x.amount).Sum();
                var payables = _ICOAService.GetPaymentTransactions().Where(x => x.CreatedDate.Date >= From.Date && x.CreatedDate.Date < To.Date).Select(x => x.amount).Sum();
                var paid = _ICOAService.GetPaymentTransactions().Where(x => x.CreatedDate.Date >= From.Date && x.CreatedDate.Date < To.Date).Select(x => x.amount).Sum();
                var custpay = _ISalesService.GetAllSalespaiddetail().Where(x => x.CreatedDate.Date >= From.Date && x.CreatedDate.Date < To.Date).Select(x => x.amount).Sum();
                var suplpay = _IPurchaseService.GetPurchasePaidDetails().Where(x => x.CreatedDate.Date >= From.Date && x.CreatedDate.Date < To.Date).Select(x => x.amount).Sum();
                var CashInhand = _IPurchaseService.GetPurchasePaidDetails().Where(x => x.CreatedDate.Date >= From.Date && x.CreatedDate.Date < To.Date).Select(x => x.amount).Sum();

                var payment = _ICOAService.GetPaymentTransactions().Select(x => x.amount).Sum();
                var recipttra = _ICOAService.GetReceiptTransactions().Select(x => x.amount).Sum();
                var salespaid = _ISalesService.GetAllSalespaiddetail().Where(x => x.Status == 2).Select(x => x.amount).Sum();
                var purchasepaid = _IPurchaseService.GetPurchasePaidDetails().Select(x => x.amount).Sum();

                var cashInHand = (salespaid + recipttra) - (purchasepaid + payment);


                var result = new
                {
                    sales,
                    purchase,
                    recipt,
                    payables,
                    custpay,
                    suplpay,
                    cashInHand
                };
                return Json(result);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpGet]
        public ActionResult GetCustomerSheduler()
        {
            try
            {
                long UserId = 0;
                var UserType = "";
                if (HttpContext.Session.GetString("UserId") != null)
                {
                    UserId = int.Parse(HttpContext.Session.GetString("UserId"));
                    UserType = HttpContext.Session.GetString("UserType");
                }

                DateTime today = DateTime.Today;

                var SOAs = _ISalesService.GetAllSales().Where(x => x.balance != 0).GroupBy(x => x.CustomerId).Select(x => new SalesOrder
                {
                    CustomerId = x.Max(y => y.CustomerId),
                    Total = x.Sum(y => y.balance),
                }).ToList();
                var Shedule = _ICustomerService.GetAllCustomerUserAssign().Where(x => (x.AssignedUserId == UserId || UserType == "Admin") && (int)today.DayOfWeek == x.assignedDay && x.ModifiedDate.Day != today.Day).ToList();


                var query1 = (from left in Shedule
                              join right in SOAs on left.CustomerId equals right.CustomerId into joinedList
                              from sub in joinedList.DefaultIfEmpty()
                              select new
                              {
                                  customerName = left.Customer.CustomerName,
                                  customerId = left.CustomerId,
                                  Name = left.AssignedUser.Username,
                                  Number = left.Customer.SupportNo,
                                  Balance = sub == null ? 0 : sub.Total
                              }).ToList();

                var query = (from left in query1
                             join right in _ICustomerService.GetAllCustomerContact() on left.customerId equals right.CustomerId into joinedList
                             from sub in joinedList.DefaultIfEmpty()
                             select new
                             {
                                 left.customerName,
                                 left.Name,
                                 left.Balance,
                                 number = string.IsNullOrEmpty(left.Number) ? sub == null ? "" : sub.Number : left.Number
                             }).ToList();
                var purchase = _IPurchaseService.GetAllPurchaseOrder().Where(x => x.balance != 0).Select(x => x.Total).Sum();
                var recipt = _ICOAService.GetAllReceipt().Where(x => x.Status == 1).Select(x => x.amount - x.balance).Sum();
                var Payables = _ICOAService.GetAllPayment().Where(x => x.Status == 1).Select(x => x.amount - x.balance).Sum();
                var Results = _ISalesService.GetAllSales().
                Where(x => x.CreatedUserId == UserId && x.CreatedDate.Month == DateTime.Now.Month).GroupBy(x => x.CreatedUserId).Select(x => new
                {
                    Total = x.Sum(y => y.Total),
                    Count = x.Count()
                }).FirstOrDefault();
                var PreviusResults = _ISalesService.GetAllSales().
                Where(x => x.CreatedUserId == UserId && x.CreatedDate.Month == (DateTime.Now.Month) - 1).GroupBy(x => x.CreatedUserId).Select(x => new
                {
                    Total = x.Sum(y => y.Total),
                    Count = x.Count(),
                }).FirstOrDefault();
                var taskResults = _ICurrencyService.GetAllTask().Where(x => x.Status == 1).ToList();
                var result = new
                {
                    Total = Results == null ? 0 : Results.Total,
                    Count = Results == null ? 0 : Results.Count,
                    PreviusTotal = PreviusResults == null ? 0 : PreviusResults.Total,
                    PreviusCount = PreviusResults == null ? 0 : PreviusResults.Count,
                    Shedule = query,
                    Sales = SOAs.Select(x => x.Total).Sum(),
                    Recivables = recipt,
                    Payables,
                    Purchase = purchase,
                    Task= taskResults
                };
                return Json(result);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpGet]
        public ActionResult UpdateVisited(long Id)
        {
            try
            {
                var data = _ICustomerService.GetCustomerUserAssign(Id);
                data.ModifiedDate = DateTime.Now;
                _ICustomerService.UpdateCustomerUserAssign(data);
                return Json(new { msg = "Success" });
            }
            catch (Exception ex)
            {
                return Json(new { msg = ex.Message });
            }

        }



        [HttpGet]
        public ActionResult GetTask()
        {
            try
            {
                long UserId = 0;
                var UserType = "";
                if (HttpContext.Session.GetString("UserId") != null)
                {
                    UserId = int.Parse(HttpContext.Session.GetString("UserId"));
                    UserType = HttpContext.Session.GetString("UserType");
                }
                var Results = _ICurrencyService.GetAllTask().Where(x => x.Status == 1).ToList();
                var result = new
                {
                    Total = Results == null ? 0 : Results.Count,
                    Count = Results == null ? 0 : Results.Count,
                    rows = Results
                };
                return Json(result);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpGet]
        public ActionResult UpdateTask(long Id)
        {
            try
            {
                var data = _ICurrencyService.GetTask(Id);
                data.ModifiedDate = DateTime.Now;
                data.Status = 2;
                _ICurrencyService.UpdateTask(data);
                return Json(new { msg = "Success" });
            }
            catch (Exception ex)
            {
                return Json(new { msg = ex.Message });
            }

        }
        [HttpGet]
        public ActionResult UpdateTaskcommant(long Id,string comment)
        {
            try
            {
                var data = _ICurrencyService.GetTask(Id);
                data.ModifiedDate = DateTime.Now;
                data.details =string.Format("{0}; {1}",data.details, comment);
                _ICurrencyService.UpdateTask(data);
                return Json(new { msg = "Success" });
            }
            catch (Exception ex)
            {
                return Json(new { msg = ex.Message });
            }

        }
        [HttpGet]
        public ActionResult CreateTask(string name, string comment)
        {
            try
            {
                var data = new SC.Data.Task();
                data.ModifiedDate = DateTime.Now;
                data.details = comment;
                data.name = name;
                _ICurrencyService.AddTask(data);
                return Json(new { msg = "Success" });
            }
            catch (Exception ex)
            {
                return Json(new { msg = ex.Message });
            }

        }

        [HttpGet]
        public ActionResult GetCustomerAssigned(long Id)
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICustomerService.GetAllCustomerUserAssign().Where(x => x.CustomerId == Id).FirstOrDefault();
            var result = new
            {
                CustomerId = Results == null ? 0 : Results.AssignedUserId,
                assignedDay = Results == null ? 0 : Results.assignedDay
            };
            return Json(result);
        }
        [HttpGet]
        public ActionResult GetCashInHand()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var payment = _ICOAService.GetPaymentTransactions().Select(x => x.amount).Sum();
            var recipt = _ICOAService.GetReceiptTransactions().Select(x => x.amount).Sum();
            var salespaid = _ISalesService.GetAllSalespaiddetail().Where(x => x.Status == 2).Select(x => x.amount).Sum();
            var purchasepaid = _IPurchaseService.GetPurchasePaidDetails().Select(x => x.amount).Sum();
            var CashInHand = (salespaid + recipt) - (purchasepaid + payment);
            return Json(CashInHand);
        }
        #region Search
        [HttpGet]
        public ActionResult SearchSalesOrders(string serfromdate = "", string sertodate = "", string serRefNo = "", long serCustomer = 0, long serUser = 0)
        {
            serRefNo = serRefNo ?? "";
            DateTime From = serfromdate == null ? DateTime.MinValue : Convert.ToDateTime(serfromdate);
            DateTime To = sertodate == null ? DateTime.MaxValue : Convert.ToDateTime(sertodate);
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSalesOrder().Where(x => x.Status >= 1 &&
            (x.refno.ToLower().Contains(serRefNo.ToLower()) || serRefNo == "")
            && (x.CustomerId == serCustomer || serCustomer == 0)
            && (x.CreatedUserId == serUser || serUser == 0)
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
        [HttpGet]
        public ActionResult SearchSales(string serfromdate = "", string sertodate = "", string serRefNo = "", long serCustomer = 0, long serUser = 0)
        {
            serRefNo = serRefNo ?? "";
            DateTime From = serfromdate == null ? DateTime.MinValue : Convert.ToDateTime(serfromdate);
            DateTime To = sertodate == null ? DateTime.MaxValue : Convert.ToDateTime(sertodate);
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSales().Where(x => x.Status >= 1 &&
            (x.invoiceno.ToLower().Contains(serRefNo.ToLower()) || serRefNo == "")
            && (x.CustomerId == serCustomer || serCustomer == 0)
            //&& (x.SalesOrder != null && (x.SalesOrder.CreatedUserId == serUser || serUser == 0))
            && (x.salesdate >= From && x.salesdate <= To)).ToList();
            int totalRecords = Results.Count();
            var totalPages = (int)Math.Ceiling((float)totalRecords / (float)10);
            if (serUser != 0)
            {
                Results = Results.Where(x => x.SalesOrder != null).Where(x => x.SalesOrder.CreatedUserId == serUser).ToList();
            }
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
        public ActionResult SearchAgedPayables(string serCode = "", long serName = 0, long serCity = 0, long serCategory = 0, long serGroup = 0)
        {
            serCode = serCode ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IPurchaseService.GetAllPurchaseOrder().Where(x => x.balance != 0
             && (x.Supplier.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
            && (x.SupplierId == serName || serName == 0)
             && (x.Supplier.CityId == serCity || serCity == 0)
               && (x.Supplier.categoryId == serCategory || serCategory == 0)
                  && (x.Supplier.suppliergroupId == serGroup || serGroup == 0)).
                Select(x => new
                {
                    x.SupplierId,
                    x.Supplier.code,
                    x.Supplier.SupplierName,
                    First = (DateTime.Now - x.orderdate).Days <= 30 ? x.balance : 0,
                    Second = ((DateTime.Now - x.orderdate).Days > 30 && (DateTime.Now - x.orderdate).Days <= 60) ? x.balance : 0,
                    Third = ((DateTime.Now - x.orderdate).Days > 60 && (DateTime.Now - x.orderdate).Days <= 90) ? x.balance : 0,
                    Fourth = ((DateTime.Now - x.orderdate).Days > 90 && (DateTime.Now - x.orderdate).Days <= 120) ? x.balance : 0,
                    Fifth = (DateTime.Now - x.orderdate).Days > 120 ? x.balance : 0,
                    total = x.balance
                }).GroupBy(x => x.SupplierId).Select(x => new
                {
                    SupplierCode = x.Max(y => y.code),
                    SupplierName = x.Max(y => y.SupplierName),
                    First = x.Sum(y => y.First),
                    Second = x.Sum(y => y.Second),
                    Third = x.Sum(y => y.Third),
                    Fourth = x.Sum(y => y.Fourth),
                    Fifth = x.Sum(y => y.Fifth),
                    total = x.Sum(y => y.total)
                }).ToList();
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
        public ActionResult SearchSupplierSummary(string serCode = "", long serName = 0, long serCity = 0, long serCategory = 0, long serGroup = 0)
        {
            serCode = serCode ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IPurchaseService.GetAllPurchaseOrder().Where(x => x.balance != 0
                && (x.Supplier.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
                && (x.SupplierId == serName || serName == 0)
                && (x.Supplier.CityId == serCity || serCity == 0)
                && (x.Supplier.categoryId == serCategory || serCategory == 0)
                && (x.Supplier.suppliergroupId == serGroup || serGroup == 0))
                .Select(x => new
                {
                    x.SupplierId,
                    x.Supplier.code,
                    x.Supplier.SupplierName,
                    Opening = (x.Supplier.dr - x.Supplier.cr),
                    x.balance,
                    total = x.Total
                }).GroupBy(x => x.SupplierId).Select(x => new
                {
                    SupplierCode = x.Max(y => y.code),
                    SupplierName = x.Max(y => y.SupplierName),
                    balance = x.Sum(y => y.balance),
                    Opening = x.Sum(y => y.Opening),
                    total = x.Sum(y => y.total)
                }).ToList();
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
        public ActionResult SearchSupplierSOA(string serfromdate = "", string sertodate = "", long serName = 0, long serCity = 0, long serCategory = 0, long serGroup = 0)
        {
            DateTime From = serfromdate == null ? DateTime.MinValue : Convert.ToDateTime(serfromdate);
            DateTime To = sertodate == null ? DateTime.MaxValue : Convert.ToDateTime(sertodate);
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IPurchaseService.GetAllPurchaseOrder().Where(x => x.balance != 0
                && (x.orderdate >= From && x.orderdate <= To)
                && (x.SupplierId == serName || serName == 0)
                && (x.Supplier.CityId == serCity || serCity == 0)
                && (x.Supplier.categoryId == serCategory || serCategory == 0)
                && (x.Supplier.suppliergroupId == serGroup || serGroup == 0)).
                Select(x => new
                {
                    x.Id,
                    x.details,
                    x.orderdate,
                    x.refno,
                    x.invoiceno,
                    x.Total,
                    x.Supplier.SupplierName,
                    Due = (DateTime.Now - x.orderdate).Days,
                    x.balance
                }).ToList();
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
        public ActionResult SearchAgedReceivables(string serCode = "", long serName = 0, long serCity = 0, long serCategory = 0, long serGroup = 0)
        {
            serCode = serCode ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSales().Where(x => x.balance > 0
             && (x.Customer.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
            && (x.CustomerId == serName || serName == 0)
             && (x.Customer.CityId == serCity || serCity == 0)
               && (x.Customer.customercategoryId == serCategory || serCategory == 0)
                  && (x.Customer.customergroupId == serGroup || serGroup == 0)).
                Select(x => new
                {
                    x.CustomerId,
                    x.Customer.code,
                    x.Customer.CustomerName,
                    First = (DateTime.Now - x.salesdate).Days <= 30 ? x.balance : 0,
                    Second = ((DateTime.Now - x.salesdate).Days > 30 && (DateTime.Now - x.salesdate).Days <= 60) ? x.balance : 0,
                    Third = ((DateTime.Now - x.salesdate).Days > 60 && (DateTime.Now - x.salesdate).Days <= 90) ? x.balance : 0,
                    Fourth = ((DateTime.Now - x.salesdate).Days > 90 && (DateTime.Now - x.salesdate).Days <= 120) ? x.balance : 0,
                    Fifth = (DateTime.Now - x.salesdate).Days > 120 ? x.balance : 0,
                    total = x.balance
                }).GroupBy(x => x.CustomerId).Select(x => new
                {
                    CustomerCode = x.Max(y => y.code),
                    CustomerName = x.Max(y => y.CustomerName),
                    First = x.Sum(y => y.First),
                    Second = x.Sum(y => y.Second),
                    Third = x.Sum(y => y.Third),
                    Fourth = x.Sum(y => y.Fourth),
                    Fifth = x.Sum(y => y.Fifth),
                    total = x.Sum(y => y.total)
                }).ToList();
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
        public ActionResult SearchCustomerSummary(string serCode = "", long serName = 0, long serCity = 0, long serCategory = 0, long serGroup = 0)
        {
            serCode = serCode ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSales().Where(x => x.balance != 0
                && (x.Customer.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
                && (x.CustomerId == serName || serName == 0)
                && (x.Customer.CityId == serCity || serCity == 0)
                && (x.Customer.customercategoryId == serCategory || serCategory == 0)
                && (x.Customer.customergroupId == serGroup || serGroup == 0))
                .Select(x => new
                {
                    x.CustomerId,
                    x.Customer.code,
                    x.Customer.CustomerName,
                    Opening = (x.Customer.dr - x.Customer.cr),
                    x.balance,
                    total = x.Total
                }).GroupBy(x => x.CustomerId).Select(x => new
                {
                    CustomerCode = x.Max(y => y.code),
                    CustomerName = x.Max(y => y.CustomerName),
                    balance = x.Sum(y => y.balance),
                    Opening = x.Sum(y => y.Opening),
                    total = x.Sum(y => y.total)
                }).ToList();
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
        public ActionResult SearchCustomerSOA(string serfromdate = "", string sertodate = "", long serName = 0, long serCity = 0, long serCategory = 0, long serGroup = 0)
        {
            DateTime From = serfromdate == null ? DateTime.MinValue : Convert.ToDateTime(serfromdate);
            DateTime To = sertodate == null ? DateTime.MaxValue : Convert.ToDateTime(sertodate).AddDays(1).AddMilliseconds(-1);
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSales().Where(x => x.balance > 0
                && (x.salesdate >= From && x.salesdate <= To)
                && (x.CustomerId == serName || serName == 0)
                && (x.Customer.CityId == serCity || serCity == 0)
                && (x.Customer.customercategoryId == serCategory || serCategory == 0)
                && (x.Customer.customergroupId == serGroup || serGroup == 0)).
                Select(x => new
                {
                    x.Id,
                    x.details,
                    x.salesdate,
                    refno = x.SalesOrder == null ? "" : x.SalesOrder.refno,
                    x.invoiceno,
                    x.Total,
                    x.Customer.CustomerName,
                    Due = (DateTime.Now - x.salesdate).Days,
                    x.balance
                }).ToList();
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

        public ActionResult GetMarginReport(string serfromdate = "", string sertodate = "", long serName = 0, long serItem = 0, long serCreated = 0)
        {
            DateTime From = string.IsNullOrEmpty(serfromdate) ? DateTime.MinValue : Convert.ToDateTime(serfromdate);
            DateTime To = string.IsNullOrEmpty(sertodate) ? DateTime.MaxValue : Convert.ToDateTime(sertodate).AddDays(1).AddMilliseconds(-1);
            int pageIndex = Convert.ToInt32(1) - 1;
            var sales = _ISalesService.GetAllSalesDetail().Where(x =>
                (x.Sales.salesdate >= From && x.Sales.salesdate <= To)
                && (x.Sales.CustomerId == serName || serName == 0)
                && (x.Sales.CreatedUserId == serCreated || serCreated == 0)
                && (x.ItemMasterId == serItem || serItem == 0)).GroupBy(x => x.ItemMasterId).
                Select(x => new
                {
                    Itemid = x.Max(y => y.ItemMasterId),
                    Total = x.Sum(y => y.amount),
                    qty = x.Sum(y => y.qty),
                    Itemname = x.Max(y => y.ItemMaster.ItemName),
                    itemCode = x.Max(y => y.ItemMaster.ItemCode)


                }).ToList();
            var stock = _IItemService.GetStockMaster().GroupBy(x => x.ItemMasterId).
                Select(x => new
                {
                    Itemid = x.Max(y => y.ItemMasterId),
                    Price = x.Sum(y => y.stock) == 0 ? 0 : x.Sum(y => (y.PurPrice * y.stock)) / x.Sum(y => y.stock)

                }).ToList();
            var Results = (from left in sales
                           join right in stock on left.Itemid equals right.Itemid into joinedList
                           from sub in joinedList.DefaultIfEmpty()
                           select new
                           {
                               ItemName = left.Itemname,
                               Total = left.Total,
                               left.qty,
                               left.itemCode,
                               cost = sub == null ? 0 : sub.Price,
                               Profit = sub == null ? left.Total : left.Total - (sub.Price * left.qty)
                           }).ToList();


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
        #endregion
        [HttpGet]
        public ActionResult GetCustomerInfo(long CustomerId = 0)
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IApplicationUserService.getCustomerInfo_Trademates(CustomerId);
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
        public ActionResult GetItemSummary(long ItemId = 0)
        {
            try
            {
                int pageIndex = Convert.ToInt32(1) - 1;
                var Results = _IApplicationUserService.GetItemInfo_Trademate(ItemId).OrderByDescending(x => x.date).ToList();
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
            catch (Exception)
            {

                var result = new
                {
                    total = 0,
                    page = 1,
                    records = 0
                };
                return Json(result);
            }
        }
        [HttpGet]
        public ActionResult GetVatInfo(long CustomerId = 0, long SuplierId = 0)
        {
            try
            {
                int pageIndex = Convert.ToInt32(1) - 1;
                var Results = _IApplicationUserService.GetVatInfo_Trademate(CustomerId, SuplierId).OrderByDescending(x => x.date).ToList();
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
            catch (Exception)
            {

                var result = new
                {
                    total = 0,
                    page = 1,
                    records = 0
                };
                return Json(result);
            }
        }

    }

}