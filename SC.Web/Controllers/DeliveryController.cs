using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SC.Data;
using SC.Service.Interface;

namespace SC.Web.Controllers
{
    public class DeliveryController : Controller
    {
        private readonly ISalesService _ISalesService;
        private readonly IMapper _mapper;
        private readonly Data.AppSettings _appEnvironment;
        public DeliveryController(ISalesService salesService, IMapper mapperService, IOptions<AppSettings> settings)
        {
            _ISalesService = salesService;
            _mapper = mapperService;
            _appEnvironment = settings.Value;
        }
        public IActionResult DeliveryPickupLoad()
        {
            return View("../Delivery/View_DeliveryPickupLoad");
        }
        public IActionResult DeliveryLoad()
        {
            return View("../Delivery/View_DeliveryLoad");
        }
        public IActionResult LocationLoad()
        {
            return View("../Delivery/View_RouteMaps");
        }
        public IActionResult DeliveryAppLoad()
        {
            return View("../Delivery/View_DeliveryAppLoad");
        }

        [HttpGet]
        public ActionResult GetSalesOrderPickUp()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSales().Where(x => x.Status == 2).ToList();
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
        public ActionResult GetSalesPickUpDetails(long SalesId)
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
        [HttpGet]
        public ActionResult SearchSalesOrdersPickUp(string serfromdate = "", string sertodate = "", string serRefNo = "")
        {
            serRefNo = serRefNo ?? "";
            DateTime From = serfromdate == null ? DateTime.MinValue : Convert.ToDateTime(serfromdate);
            DateTime To = sertodate == null ? DateTime.MaxValue : Convert.ToDateTime(sertodate);
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSales().Where(x => x.Status == 2 &&
            (x.invoiceno.ToLower().Contains(serRefNo.ToLower()) || serRefNo == "")
              && (x.salesdate >= From && x.salesdate <= To)).ToList();
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
        public ActionResult GetSalesOrderDelivery()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSales().Where(x => x.Status == 3).ToList();
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
        public ActionResult GetSalesDeliveryDetails(long SalesId)
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
        [HttpGet]
        public ActionResult SearchSalesOrdersDelivery(string serfromdate = "", string sertodate = "", string serRefNo = "")
        {
            serRefNo = serRefNo ?? "";
            DateTime From = serfromdate == null ? DateTime.MinValue : Convert.ToDateTime(serfromdate);
            DateTime To = sertodate == null ? DateTime.MaxValue : Convert.ToDateTime(sertodate);
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllSales().Where(x => x.Status == 3 &&
            (x.invoiceno.ToLower().Contains(serRefNo.ToLower()) || serRefNo == "")
              && (x.salesdate >= From && x.salesdate <= To)).ToList();
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
        public IActionResult GetLoctions()
        {
            List<locations> obj = new List<locations>();
            var model = _ISalesService.GetAllSales().Where(x => (x.Status == 3) && (!string.IsNullOrWhiteSpace(x.Customer.Lattitude)) && x.Customer.Longitude.Length > 0).Select(x => new locations { add = x.Customer.CustomerName, lat = x.Customer.Lattitude, lon = x.Customer.Longitude }).ToList();
            return Json(model);

        }

        [HttpPost]
        public IActionResult UpdatePickedUp(long[] Ids)
        {
            var orders = _ISalesService.GetAllSales().Where(x => Ids.Contains(x.Id)).ToList();
            foreach (var item in orders)
            {
                item.Status = 3;
                _ISalesService.UpdateSales(item);
                var order = _ISalesService.GetAllSalesOrder().Where(x => x.Id == item.SalesOrderId).First();
                order.Status = 3;
                _ISalesService.UpdateSalesOrder(order);
            }
            
            return Json("Success");

        }
        [HttpGet]
        public IActionResult GetDeliveryAddress(long Id)
        {
            var address = _ISalesService.GetSales(Id).details;
            return Json(new { to = address, from = _appEnvironment.CompanyAddress });
        }

        [HttpGet]
        public ActionResult GetDeliverItem(string orderno = "", long UserId = 0, long AssignedUserId = 0)
        {
            orderno = orderno ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllDeliveryItem()
                .Where(x => (x.OrderNo.Contains(orderno) || orderno == "") && (x.userAssignedId == AssignedUserId || AssignedUserId == 0)
                && (x.CreatedUserId == UserId || UserId == 0)).OrderByDescending(x => x.Id).ToList();
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
        public ActionResult GetUnassignedDeliverItem(string orderno = "", long UserId = 0)
        {
            orderno = orderno ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllDeliveryItem()
                .Where(x => (x.OrderNo.Contains(orderno) || orderno == "")
                && (x.CreatedUserId == UserId || UserId == 0)&&(x.userAssignedId==null)).OrderByDescending(x => x.Id).ToList();
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
        public ActionResult GetDeliveryCategory(int MaincategoryId=0)
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllDeliverycategory()
                .Where(x => (x.DeliveryId==null)).OrderByDescending(x => x.Id).ToList();
            if (MaincategoryId > 0)
            {
                Results = _ISalesService.GetAllDeliverycategory()
                .Where(x => (x.DeliveryId == MaincategoryId)).OrderByDescending(x => x.Id).ToList();
            }
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
        public ActionResult GetDeliverySubCategory(int Id = 0)
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetAllDeliverycategory()
                .Where(x => (x.Id == Id)).OrderByDescending(x => x.Id).FirstOrDefault();
            var result = new
            {
                page = 1,
                rows = Results
            };
            return Json(result);
        }

        [HttpPost]
        public IActionResult UpdateDeliveryItem([FromForm] long Id, int status,long vendorId=0)
        {
            try
            {
                var item = _ISalesService.GetDeliveryItem(Id);
                item.Status = status;
                if(vendorId > 0)
                    item.userAssignedId = vendorId;
                _ISalesService.UpdateDeliveryItem(item);
                return Json("Success");
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        [HttpPost]
        public ActionResult createPament(DeliveryPayment deliveryPayment)
        {
            _ISalesService.AddDeliveryPayment(deliveryPayment);
            return Json(deliveryPayment);
        }
        [HttpPost]
        public ActionResult updatePayment(DeliveryPayment deliveryPayment)
        {
            var model = _ISalesService.GetDeliveryPayment()
                .Where(x => (x.deliveryItemId == deliveryPayment.deliveryItemId)).FirstOrDefault();
            if(model==null)
                return Json("Payment Not Created for OrderId " + deliveryPayment.deliveryItemId);
            model.Status = deliveryPayment.Status;
            _ISalesService.UpdateDeliveryPayment(model);
            return Json(model);
        }
        [HttpGet]
        public ActionResult GetPayment(int deliveryId = 0)
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISalesService.GetDeliveryPayment()
                .Where(x => (x.deliveryItemId == deliveryId)).FirstOrDefault();
           
                       return Json(Results);
        }
        [HttpPost]
        public IActionResult CreateDeliveryItem(DeliveryItem DeliveryItem)
        {
            try
            {
                Random generator = new Random();
                string ra = string.Format("{0}{1}", DateTime.Now.ToString("yyMMdd"), generator.Next(0, 1000000).ToString("D6"));
                DeliveryItem.OrderNo = ra;
                //DeliveryItem.CreatedUserId = 1;
                _ISalesService.AddDeliveryItem(DeliveryItem);
                return Json(DeliveryItem);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult CreateDelivery(long[] Ids, string from, string to, bool pay, long userId)
        {
            var orders = _ISalesService.GetAllSales().Where(x => Ids.Contains(x.Id)).ToList();
            string invoiceno = "";
            double amount = 0;
            foreach (var item in orders)
            {
                invoiceno += item.invoiceno + "; ";
                amount += item.Total;
                item.Status = 4;
                _ISalesService.UpdateSales(item);
                var order = _ISalesService.GetAllSalesOrder().Where(x => x.Id == item.SalesOrderId).First();
                order.Status = 4;
                _ISalesService.UpdateSalesOrder(order);
            }
            Random generator = new Random();
            string ra = string.Format("{0}{1}", DateTime.Now.ToString("yyMMdd"), generator.Next(0, 1000000).ToString("D6"));
            DeliveryItem Item = new DeliveryItem()
            {
                Amount = pay ? amount : 0,
                OrderNo = ra,
                details = invoiceno,
                FromAddress = from,
                ToAddress = to,
                userAssignedId = userId,
                Status = 1

            };
            
            _ISalesService.AddDeliveryItem(Item);
            return Json("Success");
        }


        [HttpPost]
        public IActionResult UpdateDelivered(long[] Ids)
        {
            var orders = _ISalesService.GetAllSales().Where(x => Ids.Contains(x.Id)).ToList();
            foreach (var item in orders)
            {
                item.Status = 4;
                _ISalesService.UpdateSales(item);
                var order = _ISalesService.GetAllSalesOrder().Where(x => x.Id == item.SalesOrderId).First();
                order.Status = 4;
                _ISalesService.UpdateSalesOrder(order);
            }
            return Json("Success");

        }
        [HttpPost]
        public IActionResult UpdateCancelled(long[] Ids)
        {
            var orders = _ISalesService.GetAllSalesOrder().Where(x => Ids.Contains(x.Id)).ToList();
            foreach (var item in orders)
            {
                item.Status = 5;
                _ISalesService.UpdateSalesOrder(item);
            }
            return Json("Success");

        }
        class locations
        {
            public string lat { get; set; }
            public string lon { get; set; }
            public string add { get; set; }
            public decimal distance { get; set; }
        }
    }
}