using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SC.Data;
using SC.Service.Interface;
using SC.Web.Models;

namespace SC.Web.Controllers
{
    [EnableCors("AllowOrigin")]
    public class HomeController : Controller
    {
        private readonly IItemService _IItemService;
        private readonly IApplicationUserService _IApplicationUserService;
        private readonly ISalesService _ISalesService;
        private readonly ICustomerService _ICustomerService;
        private readonly IItemCategory _IItemCategory;
        private readonly Data.AppSettings _appEnvironment;

        public HomeController(IItemService iItemService, IOptions<AppSettings> settings, IApplicationUserService ApplicationUserService,
            ISalesService ISalesService, ICustomerService ICustomerService, IItemCategory itemcategory)
        {
            _IItemService = iItemService;
            _IApplicationUserService = ApplicationUserService;
            _ISalesService = ISalesService;
            _ICustomerService = ICustomerService;
            _IItemCategory = itemcategory;
            _appEnvironment = settings.Value;
        }
        public IActionResult Index()
        {
            return View("../Home/Home"); ;
        }
        public IActionResult Products()
        {
            return View("../Home/Index"); ;
        }
        public IActionResult ShopingCart()
        {
            return View("../Home/ShopingCart"); ;
        }
        public IActionResult GetLoctions()
        {
            List<locations> obj = new List<locations>();
            obj.Add(new locations { add = "7 Emirates", lat = "24.4969764", lon = "54.3713098" });
            obj.Add(new locations { add = "Lulu Express", lat = "24.495209", lon = "54.3709532" });
            obj.Add(new locations { add = "Zayed Hospital", lat = "24.433923", lon = "54.4063814" });
            obj.Add(new locations { add = "Khalifa Medical City", lat = "24.46295", lon = "54.3687446" });
            obj.Add(new locations { add = "LLH Hospital", lat = "24.475098", lon = "54.3565996" });
            return Json(obj);

        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private List<string> getAvailablesize(long category)
        {
            List<string> res = new List<string>();
            res.Add(_IItemCategory.GetCategory(category).CategoryName);
            return res;
        }
        [HttpGet]
        public ActionResult GetCartProducts(bool cart = false, bool site = false, int type = 1, int category = 0, string name = "")
        {
            name = name ?? "";
            var Results = _IApplicationUserService.GetProduct_Trademate(true, site, type).Where(x => (x.ItemName.ToLower().Contains(name.ToLower()) || name == ""))
                .Select(x=>new Product { 
                currencyFormat="AED",
                currencyId="aed",
                description=x.Description,
                id=x.Id,
                price=x.BaqalaPrice,
                title=x.ItemName,
                sku=x.ItemCode,
                style="",
                installments=1
                ,image=x.thumb,
                availableSizes= getAvailablesize(x.CategoryId)
                }).ToList();
            
            var result = new CartProducts
            {
                products= Results
            };
            return Json(result);
        }
        [HttpGet]
        public ActionResult GetCartCategory(bool cart = false, bool site = false, int type = 1, int category = 0, string name = "")
        {
            name = name ?? "";
            var Results = _IApplicationUserService.GetProduct_Trademate(cart, site, type).Where(x => (x.ItemName.ToLower().Contains(name.ToLower()) || name == "")).ToList();
            int totalRecords = Results.Count();
            var cateid = Results.Select(x => x.CategoryId).Distinct().ToArray();
            var cate = _IItemCategory.GetAllCategory().Where(x => cateid.Contains(x.Id)).Select(x => new
            {
                id = x.Id,
                name = x.CategoryName,
                image = x.image
            }).ToList();

            var result = new
            {
                category=cate
            };
            return Json(result);
        }
        [HttpGet]
        public ActionResult GetProducts(bool cart = false, bool site = false, int type = 1, int category = 0, string name = "")
        {
            name = name ?? "";
            var Results = _IApplicationUserService.GetProduct_Trademate(cart, site, type).Where(x => (x.ItemName.ToLower().Contains(name.ToLower()) || name == "")).ToList();
            int totalRecords = Results.Count();
            var cateid = Results.Select(x => x.CategoryId).Distinct().ToArray();
            var cate = _IItemCategory.GetAllCategory().Where(x => cateid.Contains(x.Id)).Select(x => new
            {
                id = x.Id,
                name = x.CategoryName,
                image = x.image
            }).ToList();
            var result = new
            {
                total = Results.Count,
                page = 1,
                records = totalRecords,
                category = cate,
                rows = Results.Where(x => x.CategoryId == category || category == 0).ToList()
            };
            return Json(result);
        }

        [HttpGet]
        public ActionResult GetCategory()
        {
            var Results = _IItemService.GetAllItemMaster().Where(x => x.Showcart == true).Select(x => new
            {
                id = x.ItemCategory.Id,
                name = x.ItemCategory.CategoryName,
                image = x.ItemCategory.image
            }).Distinct().ToList();
            return Json(Results);
        }
        [HttpGet]
        public ActionResult GetScrollText(int type = 1)
        {
            var Results = _IItemService.GetAllScrollText().Where(x => x.type == type).Select(x => x.text).FirstOrDefault();
            return Json(Results);
        }

        [HttpPost]
        public ActionResult CreateScrollText(ScrollText ScrollText)
        {

            try
            {
                var item = _IItemService.GetAllScrollText().Where(x => x.type == ScrollText.type).FirstOrDefault();
                if (item == null)
                    item = new ScrollText();
                item.text = ScrollText.text;
                item.type = ScrollText.type;
                if (item.Id == 0)
                    _IItemService.AddScrollText(item);
                else
                    _IItemService.UpdateScrollText(item);
            }

            catch (Exception ex)
            {
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
            return Json("Success");
        }

        [HttpPost]
        public ActionResult CreateServiceOrder(ServiceOrderClass OrderClass)
        {
            try
            {
                var custId = 387;
                // var custId = _ICustomerService.GetAllCustomer().Where(x => x.CustomerName == _appEnvironment.ServiceCustomer).FirstOrDefault().Id;
                var item = _IItemService.GetAllItemMaster().Where(x => x.ItemName == OrderClass.ItemName).FirstOrDefault();
                SalesOrder order = new SalesOrder();
                order.ContactName = OrderClass.contactName;
                order.ContactNumber = OrderClass.contactNumber;
                order.CustomerId = custId;
                order.details = "";
                order.Total = item.Price;
                order.Discount = 0;
                order.orderdate = DateTime.Now;
                order.CreatedUserId = 1;
                order.ModifiedUserId = 1;
                _ISalesService.AddSalesOrder(order);


                var detail = new SalesOrderDetail();
                detail.amount = item.Price;
                detail.ItemMasterId = item.Id;
                detail.SalesOrderId = order.Id;
                detail.qty = 1;
                detail.CreatedUserId = 1;
                detail.ModifiedUserId = 1;
                _ISalesService.AddSalesOrderDetail(detail);
                return Json("Success");
            }

            catch (Exception ex)
            {
                System.IO.File.AppendAllText(@"C:\inetpub\wwwroot\TradeMateSite\Error.txt", ex.Message);
                var errormessage = "Error occured: " + ex.Message;
                return Json(ex);
            }
        }

       
        [HttpPost]
        public ActionResult createDelivery(DeliveryItem deliveryItem)
        {
            Random generator = new Random();
            string ra = string.Format("{0}{1}", DateTime.Now.ToString("yyMMdd"), generator.Next(0, 1000000).ToString("D6"));
            DeliveryItem Item = new DeliveryItem()
            {
                Amount = deliveryItem.Amount,
                OrderNo = ra,
                details = deliveryItem.details,
                FromAddress = deliveryItem.FromAddress,
                ToAddress = deliveryItem.ToAddress,
                DropOf_contact = deliveryItem.DropOf_contact,
                PickUp_contact = deliveryItem.PickUp_contact,
                DropOf_email = deliveryItem.DropOf_email,
                PickUp_email = deliveryItem.PickUp_email,
                subcategoryId = deliveryItem.subcategoryId,
                userAssignedId = 1,
                Status = 1

            };
            _ISalesService.AddDeliveryItem(Item);
            return Json("Success");
        }
        [HttpPost]
        public ActionResult CreateSalesOrder([FromBody]OrderClass OrderClass)
        {

            try
            {
                //return Json("Success");
                System.IO.File.AppendAllText(@"C:\inetpub\wwwroot\TradeMateSite\Error.txt", OrderClass.total.ToString());
                var custId = _ICustomerService.GetAllCustomer().Where(x => x.CustomerName == _appEnvironment.CartCustomer).FirstOrDefault().Id;
                if (OrderClass.type == 2)
                    custId = _ICustomerService.GetAllCustomer().Where(x => x.CustomerName == _appEnvironment.ServiceCustomer).FirstOrDefault().Id;
                SalesOrder order = new SalesOrder();
                order.ContactName = OrderClass.contactName;
                order.ContactNumber = OrderClass.contactNumber;
                order.CustomerId = custId;
                order.details = "";
                order.Total = OrderClass.total;
                order.Discount = 0;
                order.orderdate = DateTime.Now;
                order.CreatedUserId = 1;
                order.ModifiedUserId = 1;
                _ISalesService.AddSalesOrder(order);
                foreach (var item in OrderClass.itemsList)
                {
                    var detail = new SalesOrderDetail();
                    detail.amount = item.price;
                    detail.ItemMasterId = item.id;
                    detail.SalesOrderId = order.Id;
                    detail.qty = item.qty;
                    detail.CreatedUserId = 1;
                    detail.ModifiedUserId = 1;
                    _ISalesService.AddSalesOrderDetail(detail);
                }
                return Json("Success");
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText(@"C:\inetpub\wwwroot\TradeMateSite\Error.txt", ex.Message);
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
        }

        public class Product
        {
            public List<string> availableSizes { get; set; }
            public string currencyFormat { get; set; }
            public string currencyId { get; set; }
            public string description { get; set; }
            public long id { get; set; }
            public int installments { get; set; }
            public bool isFreeShipping { get; set; }
            public double price { get; set; }
            public object sku { get; set; }
            public string style { get; set; }
            public string title { get; set; }
            public string image { get; set; }

        }

        public class CartProducts
        {
            public List<Product> products { get; set; }
        }
        public class ServiceOrderClass
        {
            public string contactName { get; set; }
            public string contactNumber { get; set; }
            public string ItemName { get; set; }
        }
        public class OrderClass
        {
            public string contactName { get; set; }
            public double total { get; set; }
            public string contactNumber { get; set; }
            public string ItemName { get; set; }
            public int type { get; set; }
            public List<OrderItems> itemsList { get; set; }
        }

        public class OrderItems
        {
            public double price { get; set; }
            public int qty { get; set; }
            public long id { get; set; }
        }
        class locations
        {
            public string lat { get; set; }
            public string lon { get; set; }
            public string add { get; set; }
        }
    }
}
