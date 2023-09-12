using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SC.Service;
using SC.Service.Interface;
using SC.Web.Models;
using SC.Data;
using System.Text;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Threading;
using System.Net.Mail;
using System.Net;

namespace SC.Web.Controllers
{
    public class SalesController : Controller
    {
        private readonly ISalesService _ISalesService;
        private readonly ISaleReturnService _ISaleReturnService;
        private readonly IItemService _IItemService;
        private readonly IMapper _mapper;
        private readonly ICOAService _ICOAService;
        public SalesController(ISalesService salesService, IMapper mapperService, IItemService itemService, ICOAService COAService, ISaleReturnService saleReturnService)
        {
            _ISalesService = salesService;
            _mapper = mapperService;
            _IItemService = itemService;
            _ICOAService = COAService;
            _ISaleReturnService = saleReturnService;
        }
        public IActionResult SalesOrderLoad()
        {
            return View("../Sales/View_SalesOrdersList");
        }

        public IActionResult SalesList()
        {
            return View("../Sales/View_SalesList");
        }


        public IActionResult CustomerPayment()
        {
            return View("../Sales/View_CustomerPayment");
        }

        public IActionResult NewSalesOrder(long Id = 0)
        {
            var model = _ISalesService.GetSalesOrder(Id);
            if (model == null)
            {
                model = new SalesOrder();
                model.orderdate = DateTime.Now.Date;
            }
            return View("View_NewSalesOrder", model);
        }

        public IActionResult NewSales(long Id = 0)
        {
            var model = _ISalesService.GetSales(Id);
            if (model == null)
            {
                model = new Sales();
                model.salesdate = DateTime.Now.Date;
            }
            return View("View_NewSales", model);
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
            var Results = _ISalesService.GetAllSalesOrder().OrderByDescending(x => x.Id).Where(x => (x.CreatedUserId == UserId || UserType == "Admin") && x.Status <= 3).ToList();
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
            var UserType = HttpContext.Session.GetString("UserType");
            long UserId = int.Parse(HttpContext.Session.GetString("UserId"));
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
        [HttpPost]
        public ActionResult SaveSalesOrder(SalesOrder SalesOrder)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                ModelState.Remove("Id");
                if (ModelState.IsValid)
                {

                    if (SalesOrder.Id > 0)
                    {
                        _ISalesService.UpdateSalesOrder(SalesOrder);
                    }
                    else
                    {
                        _ISalesService.AddSalesOrder(SalesOrder);
                    }

                    return Json(new { id = SalesOrder.Id });
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
        public ActionResult Savesalespaiddetail(List<Salespaiddetail> Salespaiddetails)
        {
            //SendSMTPEmail("accounts@need.ae", "info@need.ae;shani@need.ae", "Payment", "Payment Recieved", "");
            StringBuilder msg = new StringBuilder();
            List<string> vouchers=new List<string>();
            try
            {
                foreach (var item in Salespaiddetails)
                {
                    item.paiddate = DateTime.Now;
                    _ISalesService.addSalespaiddetail(item);

                    var model = _ISalesService.GetAllSales().Where(x => x.Id == item.SalesId).FirstOrDefault();
                    var voucherno = "VR/"+model.invoiceno;
                    item.voucherno = voucherno;
                    _ISalesService.updateSalespaiddetail(item);



                    model.balance = model.balance - item.amount;
                    model.details = item.details;
                    _ISalesService.UpdateSales(model);


                    vouchers.Add(voucherno);
                }
            }

            catch (Exception ex)
            {
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
            return Json(new { vouchers, message = "Success" });
        }


        public static void SendSMTPEmail(string senderMailAddress, string recipientMailAddress, string mailSubject, string mailBody, string attachementpatch)
        {

            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("accounts@need.ae");
                message.To.Add(new MailAddress("info@need.ae"));
                message.CC.Add(new MailAddress("baiju.c05@gmail.com"));
                message.Subject = "Test";
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = "Testing";
                smtp.Port = 465;
                smtp.Host = "majlis.tasjeel.ae"; //for gmail host  
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("accounts@need.ae", "Strength#123");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception ex) {
                throw ex;
            }


            try
            {
                Thread mail = new Thread(delegate ()
                {
                    //Create MailMessage to send an email.
                    // string AdminMailID = ConfigurationManager.AppSettings["GHQAdminMailID"];
                    string status = string.Empty;

                    MailMessage message = new MailMessage();
                    //MailMessage objMailMessage = new MailMessage();
                    message.From = new MailAddress(senderMailAddress);
                    var address = recipientMailAddress.Split(';');
                    foreach (var ad in address)
                        message.To.Add(new MailAddress(ad));
                    //  message.CC.Add(new MailAddress(AdminMailID));
                    message.Subject = mailSubject;
                    message.Body = mailBody;
                    message.IsBodyHtml = true;
                    message.CC.Add(new MailAddress("baiju.c05@gmail.com"));
                    //message.CC.Add(new MailAddress("baiju@ntravel.ae"));
                    Attachment attachment = new Attachment(attachementpatch);

                    if (attachementpatch != "")
                    {
                        message.Attachments.Add(attachment);
                    }
                    
                    SmtpClient client = new SmtpClient("majlis.tasjeel.ae", 465);
                    var SmtpUser = new System.Net.NetworkCredential("accounts@need.ae", "Strength#123", "majlis.tasjeel.ae");
                    client.EnableSsl = false;
                    client.Credentials = SmtpUser;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.Send(message);
                    attachment.Dispose();
                    status = "Success";
                });
                mail.IsBackground = true;
                mail.Start();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [HttpPost]
        public ActionResult SaveSalesOrderDetail(List<SalesOrderDetail> SalesOrderDetail)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                _ISalesService.DeleteSalesOrderDetail(SalesOrderDetail[0].SalesOrderId);
                foreach (var item in SalesOrderDetail)
                {
                    _ISalesService.AddSalesOrderDetail(item);


                    //var stock = _IItemService.GetStockMaster().Where(x => x.ItemMasterId == item.ItemMasterId).FirstOrDefault();
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
                var Order = _ISalesService.GetAllSalesOrder().Where(x => x.Id == SalesOrderDetail[0].Id).FirstOrDefault();
                //var amount=_ISalesService.GetAllSalesOrderDetail().Where(x => x.Id == SalesOrderDetail[0].Id).Select(x=>x.amount)
            }

            catch (Exception ex)
            {
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
            return Json("Success");
        }
        [HttpGet]
        public ActionResult SearchSalesOrders(string serfromdate = "", string sertodate = "", string serRefNo = "",long serCustomer=0, long serStatus =0)
        {
            serRefNo = serRefNo ?? "";
            DateTime From = serfromdate == null ? DateTime.MinValue : Convert.ToDateTime(serfromdate);
            DateTime To = sertodate == null ? DateTime.MaxValue : Convert.ToDateTime(sertodate);
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSalesOrder().Where(x =>
            (x.refno.ToLower().Contains(serRefNo.ToLower()) || serRefNo == "")
            &&(x.CustomerId==serCustomer|| serCustomer==0)
            &&(x.Status==serStatus|| serStatus==0)
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
        public ActionResult GetStatusChangeList(long Id)
        {
            var Results = _ISalesService.GetAllSales().Where(x => x.Id == Id).Select(x=>x.statusChange).FirstOrDefault().Split("$$$").ToList();
            return Json(Results);
        }
        [HttpGet]
        public ActionResult SaveStatusChange(long Id, string text)
        {
            var Results = _ISalesService.GetAllSales().Where(x => x.Id == Id).FirstOrDefault();
            string UserName = "";
            if (HttpContext.Session.GetString("UserName") != null)
            {
                UserName = HttpContext.Session.GetString("UserName");
            }
            TimeZoneInfo UAETimeZone = TimeZoneInfo.FindSystemTimeZoneById("Arabian Standard Time");
            DateTime utc = DateTime.UtcNow;
            string UAE = TimeZoneInfo.ConvertTimeFromUtc(utc, UAETimeZone).ToString("dd-MMM-yyyy HH:mm:ss");
            Results.statusChange = string.Format("{0}{1}&&&{2}&&&{3}", string.IsNullOrEmpty(Results.statusChange) ? "" : Results.statusChange + "$$$", text, UserName, UAE);
            _ISalesService.UpdateSales(Results);
            return Json(Results);
        }
        [HttpGet]
        public IActionResult DeleteSalesOrder(long Id, string text)
        {
            var Results = _ISalesService.GetAllSalesOrder().Where(x => x.Id == Id).FirstOrDefault();
            string UserName = "";
            if (HttpContext.Session.GetString("UserName") != null)
            {
                UserName = HttpContext.Session.GetString("UserName");
            }
            TimeZoneInfo UAETimeZone = TimeZoneInfo.FindSystemTimeZoneById("Arabian Standard Time");
            DateTime utc = DateTime.UtcNow;
            string UAE = TimeZoneInfo.ConvertTimeFromUtc(utc, UAETimeZone).ToString("dd-MMM-yyyy HH:mm:ss");
            Results.Status = 5;
            Results.statusChange = string.Format("{0}{1}&&&{2}&&&{3}", string.IsNullOrEmpty(Results.statusChange) ? "" : Results.statusChange + "$$$", text, UserName, UAE);
            _ISalesService.UpdateSalesOrder(Results);
            //return Json(Results);
            return Json("Success");
        }
        [HttpGet]
        public ActionResult GetOrderStatusChangeList(long Id)
        {
            var Results = _ISalesService.GetAllSalesOrder().Where(x => x.Id == Id).Select(x => x.statusChange).FirstOrDefault().Split("$$$").ToList();
            return Json(Results);
        }
        [HttpGet]
        public ActionResult SaveOrderStatusChange(long Id, string text)
        {
            var Results = _ISalesService.GetAllSalesOrder().Where(x => x.Id == Id).FirstOrDefault();
            string UserName = "";
            if (HttpContext.Session.GetString("UserName") != null)
            {
                UserName = HttpContext.Session.GetString("UserName");
            }
            TimeZoneInfo UAETimeZone = TimeZoneInfo.FindSystemTimeZoneById("Arabian Standard Time");
            DateTime utc = DateTime.UtcNow;
            string UAE = TimeZoneInfo.ConvertTimeFromUtc(utc, UAETimeZone).ToString("dd-MMM-yyyy HH:mm:ss");
            Results.statusChange = string.Format("{0}{1}&&&{2}&&&{3}", string.IsNullOrEmpty(Results.statusChange) ? "" : Results.statusChange + "$$$", text, UserName, UAE);
            _ISalesService.UpdateSalesOrder(Results);
            return Json(Results);
        }


        [HttpGet]
        public ActionResult GetSaleDetails(long SalesId)
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSalesDetail().Where(x => x.SalesId == SalesId).ToList();
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
        public ActionResult SaveSales(Sales Sales)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                ModelState.Remove("Id");
                if (ModelState.IsValid)
                {
                    var data = _ISalesService.GetAllSales().Where(x => x.SalesOrderId == Sales.SalesOrderId).FirstOrDefault();
                    if (Sales.Id > 0)
                    {
                        _ISalesService.UpdateSales(Sales);
                    }
                    else
                    {
                        if (data == null || Sales.SalesOrderId == null)
                            _ISalesService.AddSales(Sales);
                        else
                            Sales = data;
                    }

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
        public ActionResult SaveSalesDetail(List<SalesDetail> SalesDetail)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                foreach (var itm in SalesDetail)
                {
                    var stock = _IItemService.GetAllStockMaster().Where(x => x.ItemId == itm.ItemMasterId).Select(x=>x.Stock).Sum();
                    if (stock < itm.qty)
                        return Json(new { message = string.Format("No Stock for item {0}", itm.ItemMaster.ItemName) });
                }
                _ISalesService.DeleteSalesDetail(SalesDetail[0].SalesId);
                foreach (var item in SalesDetail)
                {
                    _ISalesService.AddSalesDetail(item);
                    var stock = new StockMaster();
                    stock.ItemMasterId = item.ItemMasterId;
                    stock.stock = item.qty * -1;
                    _IItemService.AddStockMaster(stock);
                }
                var sales = _ISalesService.GetAllSales().Where(x => x.Id == SalesDetail[0].SalesId).FirstOrDefault();
                sales.Total = sales.Isvat ? sales.Total * 1.05 : sales.Total;
                sales.balance = sales.Total;
                _ISalesService.UpdateSales(sales);

                var ledid = _ICOAService.GetAllledger().Where(x => x.partnerId == sales.Customer.partnerId).Select(x => x.Id).First();
                
                
                ledgertxn custled = new ledgertxn();
                custled.cr = 0;
                custled.dr = sales.Total;
                custled.txndate = DateTime.Now.Date;
                custled.ledgerId = ledid;
                custled.details = "Sale For" + sales.invoiceno;
                custled.txnno = sales.invoiceno;
                _ICOAService.AddLedgertxn(custled);
                ledgertxn led = new ledgertxn();
                led.cr = sales.Total;
                led.dr = 0;
                led.txndate = DateTime.Now.Date;
                led.ledgerId = 26;
                led.details = "Sale For" + sales.invoiceno;
                led.txnno = sales.invoiceno;
                _ICOAService.AddLedgertxn(led);

            }
            catch (Exception ex)
            {
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
            return Json(new { msg = "Success" });
        }
        [HttpPost]
        public ActionResult Savesalereturn(salereturn salereturn)
        {
            //_ISalesService.DeleteSalesDetail(7);

            //return Json(new { id = 7 });
            try
            {

                if (salereturn.Id > 0)
                {
                    _ISaleReturnService.Updatesalereturn(salereturn);
                }
                else
                {
                    salereturn.retdate = DateTime.Now;
                    _ISaleReturnService.Addsalereturn(salereturn);

                }
                _ISaleReturnService.DeletesalereturnDetails(salereturn.Id);

                return Json(new { id = salereturn.Id });

            }
            catch (Exception ex)
            {
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
        }
        [HttpPost]
        public ActionResult SavesalereturnDetail(List<salereturnDetail> salereturnDetail)
        {
            try
            {
                var amount = salereturnDetail.Sum(x => x.amount * x.qty);
                var salereturn = _ISaleReturnService.GetAllsalereturn().Where(x => x.Id == salereturnDetail[0].salereturnId).FirstOrDefault();
                amount = salereturn.Sales.Isvat ? amount * -1.05 : amount * -1;
                var model = new Sales();

                model.balance = amount;
                model.CustomerId = salereturn.Sales.CustomerId;
                model.details = salereturn.Sales.details;
                model.Discount = salereturn.Sales.Discount*-1;
                model.Isvat = salereturn.Sales.Isvat;
                model.salesdate = DateTime.Now;
                model.Total = amount;
                model.SalesOrderId = salereturn.Sales.SalesOrderId;


                salereturn.Total = amount;
                _ISaleReturnService.Updatesalereturn(salereturn);
                _ISalesService.AddSales(model);
                foreach (var item in salereturnDetail)
                {
                    _ISaleReturnService.AddsalereturnDetail(item);
                    var detail = new SalesDetail
                    {
                        amount = item.amount * -1,
                        comments ="",
                        cost = item.amount,
                        qty = item.qty,
                        ItemMasterId = item.ItemMasterId,
                        SalesId = model.Id,

                    };
                    _ISalesService.AddSalesDetail(detail);

                    var stock = new StockMaster();
                    stock.ItemMasterId = item.ItemMasterId;
                    stock.stock = item.qty;
                    _IItemService.AddStockMaster(stock);

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
        public IActionResult SaleReturnLoad()
        {
            return View("../Sales/View_saleReturnList");
        }
        public IActionResult NewSaleReturn()
        {
            return View("../Sales/View_saleReturn");
        }
        public IActionResult InvoicePayments()
        {
            return View("../Sales/View_InvoicePayments");
        }
        [HttpPost]
        public IActionResult UpdatePaymentDetails(long[] Ids, string Details)
        {
            var orders = _ISalesService.GetAllSalespaiddetail().Where(x => Ids.Contains(x.Id)).ToList();
            foreach (var item in orders)
            {
                item.Status = 2;
                _ISalesService.updateSalespaiddetail(item);
            }
            return Json("Success");
        }
        [HttpGet]
        public IActionResult CancelSalesOrder(long Id)
        {
            var orders = _ISalesService.GetSalesOrder(Id);
            if (orders != null)
            {
                orders.Status = 5;
                _ISalesService.UpdateSalesOrder(orders);
            }
            return Json("Success");
        }
        [HttpGet]
        public ActionResult GetsalePaymentDetails(string serfromdate = "", string sertodate = "", long serStatus = 1, long serCustomer = 0)
        {
            DateTime From = string.IsNullOrEmpty(serfromdate) ? DateTime.MinValue : Convert.ToDateTime(serfromdate);
            DateTime To = string.IsNullOrEmpty(sertodate) ? DateTime.MaxValue : Convert.ToDateTime(sertodate);
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSalespaiddetail().Where(x => x.CreatedDate >= From
            && x.CreatedDate <= To
            && (x.Status == serStatus || serStatus == 0)
            && (x.Sales.CustomerId == serCustomer || serCustomer == 0)
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
        public ActionResult GetsaleReturn()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISaleReturnService.GetAllsalereturn();
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
        public ActionResult GetsaleReturnDetails(long salereturnId)
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISaleReturnService.GetAllsalereturnDetail().Where(x => x.salereturnId == salereturnId).ToList();
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
        public ActionResult GetsaleOrderbyInvoice(string invoiceNo)
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSales().Where(x => x.invoiceno == invoiceNo).FirstOrDefault();
            var result = new
            {
                page = 1,
                rows = Results
            };
            return Json(result);
        }
        [HttpGet]
        public ActionResult SearchSalesReturn(string serfromdate = "", string sertodate = "", string serRefNo = "", string serInvNo = "", long serCustomer = 0)
        {
            serRefNo = serRefNo ?? "";
            serInvNo = serInvNo ?? "";
            DateTime From = serfromdate == null ? DateTime.MinValue : Convert.ToDateTime(serfromdate);
            DateTime To = sertodate == null ? DateTime.MaxValue : Convert.ToDateTime(sertodate);
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISaleReturnService.GetAllsalereturn().Where(x =>
            (x.Sales.invoiceno.ToLower().Contains(serRefNo.ToLower()) || serRefNo == "")
              && (x.invoiceno.ToLower().Contains(serInvNo.ToLower()) || serInvNo == "")
              && (x.Sales.CustomerId == serCustomer || serCustomer == 0)
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