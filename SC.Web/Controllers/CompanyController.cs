using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SC.Service;
using Newtonsoft.Json;
using System.Collections.Generic;
using SC.Service.Interface;
using SC.Web.Models;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using SC.Web;
using System.IO;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Hosting;
using SC.Data;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.AspNetCore.Http;
using System.Text.RegularExpressions;

namespace SC.Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly IItemCategory _ItemCategoryService;
        private readonly ISupplierService _ISupplierService;
        private readonly IApplicationUserService _IApplicationUserService;
        private readonly IItemService _IItemService;
        private readonly ICustomerService _ICustomerService;
        private readonly IStoreService _IStoreService;
        private readonly IMapper _mapper;
        private readonly Data.AppSettings _appEnvironment;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IAssetService _IAssetService;
        private readonly IBranchService _IBranchService;
        private readonly IDepartmentService _IDepartmentService;
        private readonly IDesignationService _IDesignationService;
        private readonly IBankService _IBankService;
        private readonly ICreditCardService _ICreditCardService;
        private readonly IEmployeeService _IEmployeeService;
        private readonly IFinancialYearService _IFinancialYearService;
        private readonly ITaxMasterService _ITaxMasterService;
        private readonly ICurrencyService _ICurrencyService;
        private readonly ICityService _ICityService;
        private readonly ICOAService _ICOAService;
        private readonly IServiceService _IServiceService;
        private readonly ISalesService _ISalesService;
        private readonly IPurchaseService _IPurchaseService;

        public CompanyController(IApplicationUserService IApplicationUserService, IOptions<AppSettings> settings, IItemCategory ItemCategoryService, IItemService ItemService, ICustomerService CustomerService, IStoreService StoreService, IHostingEnvironment hostingEnvironment, IMapper mapperService, ISupplierService SupplierService, IAssetService AssetService, IBranchService BranchService, IDepartmentService DepartmentService, IDesignationService DesignationService, IBankService BankService, ICreditCardService CreditCardService, IEmployeeService EmployeeService, IFinancialYearService FinancialYearService, ITaxMasterService TaxMasterService, ICurrencyService CurrencyService, ICityService CityService,
            ICOAService COAService, IServiceService ServiceService, ISalesService salesService, IPurchaseService purchaseService)
        {
            _IApplicationUserService = IApplicationUserService;
            _ISalesService = salesService;
            _IPurchaseService = purchaseService;
            _ISupplierService = SupplierService;
            _ItemCategoryService = ItemCategoryService;
            _IItemService = ItemService;
            _ICustomerService = CustomerService;
            _IStoreService = StoreService;
            _hostingEnvironment = hostingEnvironment;
            _mapper = mapperService;
            _IAssetService = AssetService;
            _IBranchService = BranchService;
            _IDepartmentService = DepartmentService;
            _IDesignationService = DesignationService;
            _IBankService = BankService;
            _ICreditCardService = CreditCardService;
            _IEmployeeService = EmployeeService;
            _IFinancialYearService = FinancialYearService;
            _ITaxMasterService = TaxMasterService;
            _ICurrencyService = CurrencyService;
            _ICityService = CityService;
            _ICOAService = COAService;
            _IServiceService = ServiceService;
            _appEnvironment = settings.Value;
        }
        #region FormLoad
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CurrencyListLoad()
        {
            return View("../Company/View_CurrencyList");
        }
        public IActionResult FinancialYearListLoad()
        {
            return View("../Company/View_FinancialYearList");
        }
        public IActionResult TaxListLoad()
        {
            return View("../Company/View_TaxMasterList");
        }
        public IActionResult CategoryListLoad()
        {
            return View("../Company/View_CategoryList");
        }
        public IActionResult ItemsListLoad()
        {
            return View("../Company/View_ItemsList");
        }
        public IActionResult ItemAttachmentsListLoad()
        {
            return View("../Company/View_ItemAttachments");
        }

        public IActionResult StoreListLoad()
        {
            return View("../Company/View_StoreList");
        }
        public IActionResult SupplierTypeListLoad()
        {
            return View("../Company/View_SupplierTypeListLoad");
        }
        public IActionResult SupplierListLoad()
        {
            return View("../Company/View_SupplierListLoad");
        }
        public IActionResult CustomerTypeListLoad()
        {
            return View("../Company/View_CustomerTypeListLoad");
        }
        public IActionResult CustomerListLoad()
        {
            return View("../Company/View_CustomerList");
        }
        public IActionResult UsersListLoad()
        {
            return View("../Company/UsersList");
        }
        public IActionResult AssetCategoryListLoad()
        {
            return View("../Company/View_AssetCategoryLoad");
        }
        public IActionResult AssetListLoad()
        {
            return View("../Company/View_AssetLoad");
        }
        public IActionResult BankListLoad()
        {
            return View("../Company/View_BankListLoad");
        }
        public IActionResult BranchCategoryListLoad()
        {
            return View("../Company/View_BranchCategoryListLoad");
        }
        public IActionResult BranchListLoad()
        {
            return View("../Company/View_BranchListLoad");
        }
        public IActionResult CreditCardListLoad()
        {
            return View("../Company/View_CreditCardListLoad");
        }
        public IActionResult CustomerGroupListLoad()
        {
            return View("../Company/View_CustomerGroupListLoad");
        }
        public IActionResult DeptCategoryListLoad()
        {
            return View("../Company/View_DeptCategoryListLoad");
        }
        public IActionResult DeptListLoad()
        {
            return View("../Company/View_DeptListLoad");
        }
        public IActionResult DesgCategoryListLoad()
        {
            return View("../Company/View_DesgCategoryListLoad");
        }
        public IActionResult DesgListLoad()
        {
            return View("../Company/View_DesgListLoad");
        }
        public IActionResult EmpCategoryListLoad()
        {
            return View("../Company/View_EmpCategoryListLoad");
        }
        public IActionResult EmpGroupListLoad()
        {
            return View("../Company/View_EmpGroupListLoad");
        }
        public IActionResult EmpListLoad()
        {
            return View("../Company/View_EmpListLoad");
        }
        public IActionResult SupplierGroupListLoad()
        {
            return View("../Company/View_SupplierGroupListLoad");
        }
        public IActionResult ItemBrandListLoad()
        {
            return View("../Company/View_ItemBrandListLoad");
        }
        public IActionResult COAListLoad()
        {
            return View("../Company/View_COALoad");
        }
        public IActionResult LedgerListLoad()
        {
            return View("../Company/View_LedgerList");
        }
        public IActionResult ItemStockListLoad()
        {
            return View("../Company/View_ItemStockListLoad");
        }
        public IActionResult BankcategoryLoad()
        {
            return View("../Company/View_BankcategoryLoad");
        }
        public IActionResult CreditCardcategoryLoad()
        {
            return View("../Company/View_CreditCardcategoryLoad");
        }
        public IActionResult PaymentLoad()
        {
            return View("../Company/View_PaymentList");
        }
        public IActionResult ReceiptLoad()
        {
            return View("../Company/View_ReceiptList");
        }
        public IActionResult BankTxnLoad()
        {
            return View("../Company/View_BankTxnList");
        }
        public IActionResult ServiceTypeLoad()
        {
            return View("../Company/View_ServiceTypeLoad");
        }
        public IActionResult ServiceLoad()
        {
            return View("../Company/View_ServiceLoad");
        }
        #endregion
        #region "Select Functions"
        [HttpGet]
        public ActionResult GetCategory()
        {

            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ItemCategoryService.GetAllCategory();
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
        public ActionResult GetItemMaster()
        {

            try
            {
                System.IO.File.AppendAllText(@"C:\inetpub\wwwroot\TradeMateSite\Error.txt", "In Function");
                int pageIndex = Convert.ToInt32(1) - 1;
                var Results = _IItemService.GetAllItemMaster().Where(x => x.Status == 1).OrderBy(x => x.ItemName).ToList();
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
            catch (Exception ex)
            {
                System.IO.File.AppendAllText(@"C:\inetpub\wwwroot\TradeMateSite\Error.txt", ex.Message);
                throw;
            }
        }
        [HttpGet]
        public ActionResult GetAllItemMaster()
        {

            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IItemService.GetAllItemMaster().Where(x => x.Status >0).OrderBy(x => x.ItemName).ToList();
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
        public ActionResult GetCustomer()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICustomerService.GetAllCustomer().Where(x => x.Status > 0).OrderBy(x => x.CustomerName).ToList();
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
        public ActionResult GetStore()
        {

            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IStoreService.GetAllStore();
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
        public ActionResult GetUser()
        {

            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IApplicationUserService.GetAllApplicationUser();
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
        public ActionResult GetCustomerCategory()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICustomerService.GetAllCustomerCategory();
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
        public ActionResult GetSupplierCategory()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISupplierService.GetAllSupplierCategory();
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
        public ActionResult GetSupplier()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISupplierService.GetAllSupplier();
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
        public ActionResult GetAssetCategory()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IAssetService.GetAllAssetCategory();
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
        public ActionResult GetAsset()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IAssetService.GetAllAsset();
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
        public ActionResult GetBranchCategory()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IBranchService.GetAllBranchGroup();
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
        public ActionResult GetBranch()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IBranchService.GetAllBranch();
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
        public ActionResult GetDepartmentCategory()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IDepartmentService.GetAllDepartmentGroup();
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
        public ActionResult GetDepartment()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IDepartmentService.GetAllDepartment();
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
        public ActionResult GetDesignationCategory()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IDesignationService.GetAllDesignationGroup();
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
        public ActionResult GetDesignation()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IDesignationService.GetAllDesignation();
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
        public ActionResult GetSupplierGroup()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISupplierService.GetAllSuppliergroup();
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
        public ActionResult GetCustomerGroup()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICustomerService.GetAllCustomergroup();
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
        public ActionResult GetItemBrand()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IItemService.GetAllItemBrand();
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
        public ActionResult GetBank()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IBankService.GetAllBank();
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
        public ActionResult GetCreditCard()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICreditCardService.GetAllCreditCard();
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
        public ActionResult GetEmployeeCategory()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IEmployeeService.GetAllEmployeeCategory();
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
        public ActionResult GetEmployeeGroup()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IEmployeeService.GetAllEmployeeGroup();
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
        public ActionResult GetEmployee()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IEmployeeService.GetAllEmployee();
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
        public ActionResult GetTaxMaster()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ITaxMasterService.GetAllTaxMaster();
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
        public ActionResult GetFinanceYear()
        {

            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IFinancialYearService.GetAllFinanceYear();
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
        public ActionResult GetCurrency()
        {

            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICurrencyService.GetAllCurrency();
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
        public ActionResult GetCity()
        {

            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICityService.GetAllCity();
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
        public ActionResult GetSupplierContact(long id = 0)
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISupplierService.GetAllSupplierContact().Where(x => x.SupplierId == id).ToList();
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
        public ActionResult GetCustomerContact(long id = 0)
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICustomerService.GetAllCustomerContact().Where(x => x.CustomerId == id).ToList();
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
        public ActionResult GetCOA(long id = 0)
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICOAService.GetAllcoa().ToList();
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
        public ActionResult GetCOAType()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICOAService.GetAllCOAType().ToList();
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
        public ActionResult GetStockMaster(long id)
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IItemService.GetAllStockMaster().Where(x=>x.Stock!=0).ToList();
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
        public ActionResult GetStockMasterList(long ItemId = 0)
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IItemService.GetStockMaster().Where(x=>x.ItemMasterId==ItemId).Select(x=>new StockList
            {
                ItemId=x.Id,
                ItemCode=x.ItemMaster.ItemCode,
                ItemName=x.ItemMaster.ItemName,
                Stock=x.stock,
                PurPrice=x.PurPrice,
                Date=x.CreatedDate
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


        [HttpPost]
        public ActionResult RemoveStock(long Id)
        {
            try
            {
                var stock=_IItemService.GetStockMaster(Id);
                if (stock != null)
                {
                    stock.Status = 0;
                    _IItemService.UpdateStockMaster(stock);
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
            var Results = _ICOAService.GetAlllLedgertxn().Where(x => x.ledgerId == LedgerId).ToList();
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
        public ActionResult GetBankCategory()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IBankService.GetAllBankcategory().ToList();
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
        public ActionResult GetCreditCardCategory()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICreditCardService.GetAllCreditCardcategory().ToList();
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
        public ActionResult GetPayments()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICOAService.GetAllPayment().Where(x => x.Status == 1).ToList();
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
        public ActionResult GetReceipts()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICOAService.GetAllReceipt().Where(x=>x.Status==1).ToList();
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
        public ActionResult GetBankTxn()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IBankService.GetAllBankTxn();
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
        public ActionResult GetServiceType()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IServiceService.GetAllServicetype();
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
        public ActionResult GetService()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IServiceService.GetAllService();
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
        #region "New"
        public IActionResult NewBranchCategory(long Id = 0)
        {
            var model = new BranchGroup();

            if (Id > 0)
            {
                model = _IBranchService.GetBranchGroup(Id);
            }
            else
            {
                model = new BranchGroup();
            }
            return View("../Company/View_NewBranchCategory", model);
        }
        public IActionResult NewBranch(long Id = 0)
        {
            var model = new Branch();

            if (Id > 0)
            {
                model = _IBranchService.GetBranch(Id);
            }
            else
            {
                model = new Branch();
            }
            return View("../Company/View_NewBranch", model);
        }
        public IActionResult NewDeptCategory(long Id = 0)
        {
            var model = new DepartmentGroup();

            if (Id > 0)
            {
                model = _IDepartmentService.GetDepartmentGroup(Id);
            }
            else
            {
                model = new DepartmentGroup();
            }
            return View("../Company/View_NewDepartmentGroup", model);
        }
        public IActionResult NewDepartment(long Id = 0)
        {
            var model = new Department();

            if (Id > 0)
            {
                model = _IDepartmentService.GetDepartment(Id);
            }
            else
            {
                model = new Department();
            }
            return View("../Company/View_NewDepartment", model);
        }
        public IActionResult NewDesgCategory(long Id = 0)
        {
            var model = new DesignationGroup();

            if (Id > 0)
            {
                model = _IDesignationService.GetDesignationGroup(Id);
            }
            else
            {
                model = new DesignationGroup();
            }
            return View("../Company/View_NewDesignationGroup", model);
        }
        public IActionResult NewDesignation(long Id = 0)
        {
            var model = new Designation();

            if (Id > 0)
            {
                model = _IDesignationService.GetDesignation(Id);
            }
            else
            {
                model = new Designation();
            }
            return View("../Company/View_NewDesignation", model);
        }
        public IActionResult NewStore(long Id = 0)
        {
            Store Model = new Store();
            if (Id > 0)
            {
                Model = _IStoreService.GetStore(Id);
            }
            else
            {
                Model = new Store();
            }
            return View("../Company/View_NewStore", Model);
        }
        public IActionResult NewSupplierCategory(long Id = 0)
        {
            var model = new suppliercategory();

            if (Id > 0)
            {
                model = _ISupplierService.GetSuppliercategory(Id);
            }
            else
            {
                model = new suppliercategory();
            }
            return View("../Company/View_NewSuppliercategory", model);
        }
        public IActionResult NewSupplierGroup(long Id = 0)
        {
            var model = new suppliergroup();

            if (Id > 0)
            {
                model = _ISupplierService.GetSuppliergroup(Id);
            }
            else
            {
                model = new suppliergroup();
            }
            return View("../Company/View_NewSupplierGroup", model);
        }
        public IActionResult NewSupplier(long Id = 0)
        {
            Supplier Model = new Supplier();
            if (Id > 0)
            {
                Model = _ISupplierService.GetSupplier(Id);
            }
            else
            {
                Model = new Supplier();
            }
            return View("../Company/View_NewSupplier", Model);
        }
        public IActionResult NewCustomerCategory(long Id = 0)
        {
            var model = new customercategory();

            if (Id > 0)
            {
                model = _ICustomerService.GetCustomerCategory(Id);
            }
            else
            {
                model = new customercategory();
            }
            return View("../Company/View_NewCustomerCategory", model);
        }
        public IActionResult NewCustomergroup(long Id = 0)
        {
            var model = new customergroup();

            if (Id > 0)
            {
                model = _ICustomerService.GetCustomergroup(Id);
            }
            else
            {
                model = new customergroup();
            }
            return View("../Company/View_NewCustomergroup", model);
        }
        public IActionResult NewCustomer(long Id = 0)
        {
            var Model = new Customer();
            if (Id > 0)
                Model = _ICustomerService.GetCustomer(Id);
            else
                Model = new Customer();
            return View("../Company/View_NewCustomer", Model);
        }
        public IActionResult NewItemCategory(long Id = 0)
        {
            var Model = new ItemCategory();
            if (Id > 0)
                Model = _ItemCategoryService.GetCategory(Id);
            else
                Model = new ItemCategory();
            return View("../Company/View_NewItemCategory", Model);
        }
        public IActionResult NewItemBrand(long Id = 0)
        {
            var Model = new ItemBrand();
            if (Id > 0)
                Model = _IItemService.GetItemBrand(Id);
            else
                Model = new ItemBrand();
            return View("../Company/View_NewItemBrand", Model);
        }
        public IActionResult NewItem(long Id = 0)
        {
            var Model = new ItemMaster();
            if (Id > 0)
                Model = _IItemService.GetItemMaster(Id);
            else
                Model = new ItemMaster();
            return View("../Company/View_NewItemMaster", Model);
        }
        public IActionResult NewAssetCategory(long Id = 0)
        {
            var Model = new AssetCategory();
            if (Id > 0)
                Model = _IAssetService.GetAssetCategory(Id);
            else
                Model = new AssetCategory();
            return View("../Company/View_NewAssetCategory", Model);
        }
        public IActionResult NewAsset(long Id = 0)
        {
            var Model = new Asset();
            if (Id > 0)
                Model = _IAssetService.GetAsset(Id);
            else
                Model = new Asset();
            return View("../Company/View_NewAsset", Model);
        }
        public IActionResult NewBank(long Id = 0)
        {
            var Model = new Bank();
            if (Id > 0)
                Model = _IBankService.GetBank(Id);
            else
                Model = new Bank();
            return View("../Company/View_NewBank", Model);
        }
        public IActionResult NewCreditCard(long Id = 0)
        {
            var Model = new CreditCard();
            if (Id > 0)
                Model = _ICreditCardService.GetCreditCard(Id);
            else
                Model = new CreditCard();
            return View("../Company/View_NewCreditCard", Model);
        }
        public IActionResult NewEmployeeCategory(long Id = 0)
        {
            var Model = new EmployeeCategory();
            if (Id > 0)
                Model = _IEmployeeService.GetEmployeeCategory(Id);
            else
                Model = new EmployeeCategory();
            return View("../Company/View_NewEmployeeCategory", Model);
        }
        public IActionResult NewEmployeeGroup(long Id = 0)
        {
            var Model = new EmployeeGroup();
            if (Id > 0)
                Model = _IEmployeeService.GetEmployeeGroup(Id);
            else
                Model = new EmployeeGroup();
            return View("../Company/View_NewEmployeeGroup", Model);
        }
        public IActionResult NewEmployee(long Id = 0)
        {
            var Model = new Employee();
            if (Id > 0)
                Model = _IEmployeeService.GetEmployee(Id);
            else
                Model = new Employee();
            return View("../Company/View_NewEmployee", Model);
        }
        public IActionResult NewCurrency(long Id = 0)
        {
            var Model = new Currency();
            if (Id > 0)
                Model = _ICurrencyService.GetCurrency(Id);
            else
                Model = new Currency();
            return View("../Company/View_NewCurrency", Model);
        }
        public IActionResult NewTaxMaster(long Id = 0)
        {
            var Model = new TaxMaster();
            if (Id > 0)
                Model = _ITaxMasterService.GetTaxMaster(Id);
            else
                Model = new TaxMaster();
            return View("../Company/View_NewTaxMaster", Model);
        }
        public IActionResult NewFinanceYear(long Id = 0)
        {
            var Model = new FinanceYear();
            if (Id > 0)
                Model = _IFinancialYearService.GetFinanceYear(Id);
            else
                Model = new FinanceYear();
            return View("../Company/View_NewFinanceYear", Model);
        }
        public IActionResult NewCOA(long Id = 0)
        {
            var Model = new coa();
            if (Id > 0)
                Model = _ICOAService.Getcoa(Id);
            else
                Model = new coa();
            return View("../Company/View_Newcoa", Model);
        }
        public IActionResult Newledger(long Id = 0)
        {
            var Model = new ledger();
            if (Id > 0)
                Model = _ICOAService.Getledger(Id);
            else
                Model = new ledger();
            return View("../Company/View_Newledger", Model);
        }
        public IActionResult NewBankCategory(long Id = 0)
        {
            var Model = new Bankcategory();
            if (Id > 0)
                Model = _IBankService.GetBankcategory(Id);
            else
                Model = new Bankcategory();
            return View("../Company/View_NewBankcategory", Model);
        }
        public IActionResult NewCreditCardCategory(long Id = 0)
        {
            var Model = new CreditCardcategory();
            if (Id > 0)
                Model = _ICreditCardService.GetCreditCardcategory(Id);
            else
                Model = new CreditCardcategory();
            return View("../Company/View_NewCreditCardcategory", Model);
        }
        public IActionResult NewPayment(long Id = 0)
        {
            var model = _ICOAService.GetPayment(Id);
            if (model == null)
            {
                model = new Payment();
                model.trandate = DateTime.Now;
            }
            return View("../Company/View_NewPayment", model);
        }
        public IActionResult NewReceipt(long Id = 0)
        {
            var model = _ICOAService.GetReceipt(Id);
            if (model == null)
            {
                model = new Receipt();
                model.trandate = DateTime.Now;
            }
            return View("../Company/View_NewReceipt", model);
        }
        public IActionResult NewBankTxn(long Id = 0)
        {
            var model = new BankTxn();

            if (Id > 0)
            {
                model = _IBankService.GetBankTxn(Id);
            }
            else
            {
                model = new BankTxn();
                model.trandate = DateTime.Now.Date;
            }
            return View("../Company/View_NewBankTxn", model);
        }
        public IActionResult NewServiceType(long Id = 0)
        {
            var model = new servicetype();

            if (Id > 0)
            {
                model = _IServiceService.GetServicetype(Id);
            }
            else
            {
                model = new servicetype();
            }
            return View("../Company/View_NewServiceType", model);
        }
        public IActionResult NewService(long Id = 0)
        {
            var model = new service();

            if (Id > 0)
            {
                model = _IServiceService.GetService(Id);
            }
            else
            {
                model = new service();
            }
            return View("../Company/View_NewService", model);
        }
        #endregion
        #region "Insert Functions"
        public ActionResult SaveBranchGroup(BranchGroup BranchGroup)
        {
            if (BranchGroup.Id > 0)
            {
                _IBranchService.UpdateBranchGroup(BranchGroup);
            }
            else
            {
                _IBranchService.AddBranchGroup(BranchGroup);
            }

            return RedirectToAction("BranchCategoryListLoad");
        }
        public ActionResult SaveBranch(Branch Branch)
        {
            if (Branch.Id > 0)
            {
                _IBranchService.UpdateBranch(Branch);
            }
            else
            {
                _IBranchService.AddBranch(Branch);
            }

            return RedirectToAction("BranchListLoad");
        }
        public ActionResult SaveDepartmentGroup(DepartmentGroup DepartmentGroup)
        {
            if (DepartmentGroup.Id > 0)
            {
                _IDepartmentService.UpdateDepartmentGroup(DepartmentGroup);
            }
            else
            {
                _IDepartmentService.AddDepartmentGroup(DepartmentGroup);
            }

            return RedirectToAction("DeptCategoryListLoad");
        }
        public ActionResult SaveDepartment(Department Department)
        {
            if (Department.Id > 0)
            {
                _IDepartmentService.UpdateDepartment(Department);
            }
            else
            {
                _IDepartmentService.AddDepartment(Department);
            }

            return RedirectToAction("DeptListLoad");
        }
        public ActionResult SaveDesignationGroup(DesignationGroup DesignationGroup)
        {
            if (DesignationGroup.Id > 0)
            {
                _IDesignationService.UpdateDesignationGroup(DesignationGroup);
            }
            else
            {
                _IDesignationService.AddDesignationGroup(DesignationGroup);
            }

            return RedirectToAction("DesgCategoryListLoad");
        }
        public ActionResult SaveDesignation(Designation Designation)
        {
            if (Designation.Id > 0)
            {
                _IDesignationService.UpdateDesignation(Designation);
            }
            else
            {
                _IDesignationService.AddDesignation(Designation);
            }

            return RedirectToAction("DesgListLoad");
        }
        public ActionResult SaveStore(Store Store)
        {
            if (Store.Id > 0)
            {
                _IStoreService.UpdateStore(Store);
            }
            else
            {
                _IStoreService.AddStore(Store);
            }

            return RedirectToAction("StoreListLoad");
        }
        public ActionResult SaveSuppliercategory(suppliercategory suppliercategory)
        {
            if (suppliercategory.Id > 0)
            {
                _ISupplierService.UpdateSuppliercategory(suppliercategory);
            }
            else
            {
                _ISupplierService.AddSuppliercategory(suppliercategory);
            }

            return RedirectToAction("SupplierTypeListLoad");
        }
        public ActionResult SaveSuppliergroup(suppliergroup suppliergroup)
        {
            if (suppliergroup.Id > 0)
            {
                _ISupplierService.UpdateSuppliergroup(suppliergroup);
            }
            else
            {
                _ISupplierService.AddSuppliergroup(suppliergroup);
            }

            return RedirectToAction("SupplierGroupListLoad");
        }
        [HttpPost]
        public ActionResult SaveSupplier(Supplier Supplier)
        {
            if (Supplier.Id > 0)
            {
                _ISupplierService.UpdateSupplier(Supplier);
            }
            else
            {
                var partner = new partner();
                partner.name = Supplier.SupplierName;
                partner.code = Supplier.code;
                partner.details = Supplier.Details;
                _IAssetService.AddPartner(partner);
                Supplier.partnerId = partner.Id;
                _ISupplierService.AddSupplier(Supplier);
                var suppcat = _ISupplierService.GetSuppliercategory(Supplier.categoryId);
                ledger ledger = new ledger();
                ledger.partnerId = Supplier.partnerId;
                ledger.coaId = suppcat.coaId;
                ledger.details = "Supplier";
                ledger.name = Supplier.SupplierName;
                _ICOAService.Addledger(ledger);

                ledgertxn led = new ledgertxn();
                led.dr = Supplier.dr;
                led.cr = Supplier.cr;
                led.txndate = DateTime.Now.Date;
                led.ledgerId = ledger.Id;
                led.details = "Opening Balance";
                _ICOAService.AddLedgertxn(led);

                ledgertxn ledcash = new ledgertxn();
                ledcash.cr = Supplier.dr;
                ledcash.dr = Supplier.cr;
                ledcash.txndate = DateTime.Now.Date;
                ledcash.ledgerId = 21;
                ledcash.details = "Opening Balance for " + Supplier.SupplierName;
                _ICOAService.AddLedgertxn(ledcash);

            }
            _ISupplierService.DeleteSupplierContact(Supplier.Id);

            return Json(Supplier);
        }
        [HttpPost]
        public ActionResult SaveSupplierContact(List<SupplierContact> SupplierContact)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                foreach (var item in SupplierContact)
                {
                    _ISupplierService.AddSupplierContact(item);
                }
            }

            catch (Exception ex)
            {
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
            return Json("Success");
        }
        public ActionResult SaveCustomercategory(customercategory customercategory)
        {
            if (customercategory.Id > 0)
            {
                _ICustomerService.UpdateCustomerCategory(customercategory);
            }
            else
            {
                _ICustomerService.AddCustomerCategory(customercategory);
            }

            return RedirectToAction("CustomerTypeListLoad");
        }
        public ActionResult SaveCustomergroup(customergroup customergroup)
        {
            if (customergroup.Id > 0)
            {
                _ICustomerService.UpdateCustomergroup(customergroup);
            }
            else
            {
                _ICustomerService.AddCustomergroup(customergroup);
            }

            return RedirectToAction("CustomerGroupListLoad");
        }
        public ActionResult SaveItemCategory(ItemCategory ItemCategory)
        {
            if (ItemCategory.Id > 0)
            {
                _ItemCategoryService.UpdateCategory(ItemCategory);
            }
            else
            {
                _ItemCategoryService.AddCategory(ItemCategory);
            }
            if (ItemCategory.iformFile != null)
            {
                if (ItemCategory.iformFile.Length > 0)
                {
                    string filePath = Path.Combine(_hostingEnvironment.WebRootPath+_appEnvironment.ItemImagepath,ItemCategory.iformFile.FileName);
                    using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        ItemCategory.iformFile.CopyTo(fileStream);
                    }
                    ItemCategory.image = Path.Combine(_appEnvironment.ItemImagepath, ItemCategory.iformFile.FileName);
                    _ItemCategoryService.UpdateCategory(ItemCategory);
                }

            }
            return RedirectToAction("CategoryListLoad");
        }
        public ActionResult SaveItemBrand(ItemBrand ItemBrand)
        {
            if (ItemBrand.Id > 0)
            {
                _IItemService.UpdateItemBrand(ItemBrand);
            }
            else
            {
                _IItemService.AddItemBrand(ItemBrand);
            }

            return RedirectToAction("ItemBrandListLoad");
        }
        public ActionResult SaveItemMaster(ItemMaster ItemMaster)
        {
            try
            {
                System.IO.File.AppendAllText(@"C:\inetpub\wwwroot\TradeMateSite\Error.txt", " In SaveMaster ");
                if (ItemMaster.Id > 0)
                {
                    _IItemService.UpdateItemMaster(ItemMaster);
                }
                else
                {
                    _IItemService.AddItemMaster(ItemMaster);
                }
                var stock = _IItemService.GetStockMaster().Where(x => x.ItemMasterId == ItemMaster.Id).FirstOrDefault();
                if (stock == null)
                {
                    stock = new StockMaster();
                    stock.ItemMasterId = ItemMaster.Id;
                    stock.stock = ItemMaster.qty;
                    _IItemService.AddStockMaster(stock);
                }
                else
                {
                    stock.stock = stock.stock + ItemMaster.qty;
                    _IItemService.UpdateStockMaster(stock);
                }
                return RedirectToAction("ItemsListLoad");
            }
            catch (Exception ex)
            {
                while (ex != null)
                {
                    ex = ex.InnerException;
                System.IO.File.AppendAllText(@"C:\inetpub\wwwroot\TradeMateSite\Error.txt", ex.Message);
                System.IO.File.AppendAllText(@"C:\inetpub\wwwroot\TradeMateSite\Error.txt", ex.StackTrace);
                }
               
                throw;
            }
        }
        public ActionResult SaveAssetCategory(AssetCategory AssetCategory)
        {
            if (AssetCategory.Id > 0)
            {
                _IAssetService.UpdateAssetCategory(AssetCategory);
            }
            else
            {
                _IAssetService.AddAssetCategory(AssetCategory);
            }

            return RedirectToAction("AssetCategoryListLoad");
        }
        public ActionResult SaveAsset(Asset Asset)
        {
            if (Asset.Id > 0)
            {
                _IAssetService.UpdateAsset(Asset);
            }
            else
            {
                _IAssetService.AddAsset(Asset);
            }

            return RedirectToAction("AssetListLoad");
        }
        public ActionResult SaveBankcategory(Bankcategory Bankcategory)
        {
            if (Bankcategory.Id > 0)
            {
                _IBankService.UpdateBankcategory(Bankcategory);
            }
            else
            {

                _IBankService.AddBankcategory(Bankcategory);
            }

            return RedirectToAction("BankcategoryLoad");
        }
        public ActionResult SaveBank(Bank Bank)
        {
            if (Bank.Id > 0)
            {
                _IBankService.UpdateBank(Bank);
            }
            else
            {
                var partner = new partner();
                partner.name = Bank.bankname;
                partner.code = Bank.code;
                partner.details = Bank.accno;
                _IAssetService.AddPartner(partner);
                Bank.partnerId = partner.Id;
                _IBankService.AddBank(Bank);
                var bankcat = _IBankService.GetBankcategory(Bank.BankcategoryId);
                ledger ledger = new ledger();
                ledger.partnerId = Bank.partnerId;
                ledger.coaId = bankcat.coaId;
                ledger.details = "Bank";
                ledger.name = Bank.bankname;
                _ICOAService.Addledger(ledger);
                ledgertxn led = new ledgertxn();
                led.dr = Bank.dr;
                led.cr = Bank.cr;
                led.txndate = DateTime.Now.Date;
                led.ledgerId = ledger.Id;
                led.details = "Opening Balance";
                _ICOAService.AddLedgertxn(led);
            }

            return RedirectToAction("BankListLoad");
        }
        public ActionResult SaveCreditCardcategory(CreditCardcategory CreditCardcategory)
        {
            if (CreditCardcategory.Id > 0)
            {
                _ICreditCardService.UpdateCreditCardcategory(CreditCardcategory);
            }
            else
            {
                _ICreditCardService.AddCreditCardcategory(CreditCardcategory);
            }

            return RedirectToAction("CreditCardcategoryLoad");
        }
        public ActionResult SaveCreditCard(CreditCard CreditCard)
        {
            if (CreditCard.Id > 0)
            {
                _ICreditCardService.UpdateCreditCard(CreditCard);
            }
            else
            {
                var partner = new partner();
                partner.name = CreditCard.number;
                partner.code = CreditCard.code;
                partner.details = CreditCard.details;
                _IAssetService.AddPartner(partner);
                CreditCard.partnerId = partner.Id;
                _ICreditCardService.AddCreditCard(CreditCard);
                var creditcat = _ICreditCardService.GetCreditCardcategory(CreditCard.categoryId);
                ledger ledger = new ledger();
                ledger.partnerId = CreditCard.partnerId;
                ledger.coaId = creditcat.coaId;
                ledger.details = "Credit Card";
                ledger.name = CreditCard.number;
                _ICOAService.Addledger(ledger);
                ledgertxn led = new ledgertxn();
                led.dr = CreditCard.dr;
                led.cr = CreditCard.cr;
                led.txndate = DateTime.Now.Date;
                led.ledgerId = ledger.Id;
                led.details = "Opening Balance";
                _ICOAService.AddLedgertxn(led);
            }

            return RedirectToAction("CreditCardListLoad");
        }
        public ActionResult SaveEmployeeCategory(EmployeeCategory EmployeeCategory)
        {
            if (EmployeeCategory.Id > 0)
            {
                _IEmployeeService.UpdateEmployeeCategory(EmployeeCategory);
            }
            else
            {
                _IEmployeeService.AddEmployeeCategory(EmployeeCategory);
            }

            return RedirectToAction("EmpCategoryListLoad");
        }
        public ActionResult SaveEmployeeGroup(EmployeeGroup EmployeeGroup)
        {
            if (EmployeeGroup.Id > 0)
            {
                _IEmployeeService.UpdateEmployeeGroup(EmployeeGroup);
            }
            else
            {
                _IEmployeeService.AddEmployeeGroup(EmployeeGroup);
            }

            return RedirectToAction("EmpGroupListLoad");
        }
        public ActionResult SaveCurrency(Currency Currency)
        {
            if (Currency.Id > 0)
            {
                _ICurrencyService.UpdateCurrency(Currency);
            }
            else
            {
                _ICurrencyService.AddCurrency(Currency);
            }

            return RedirectToAction("CurrencyListLoad");
        }
        public ActionResult SaveTaxMaster(TaxMaster TaxMaster)
        {
            if (TaxMaster.Id > 0)
            {
                _ITaxMasterService.UpdateTaxMaster(TaxMaster);
            }
            else
            {
                _ITaxMasterService.AddTaxMaster(TaxMaster);
            }

            return RedirectToAction("TaxListLoad");
        }
        public ActionResult SaveFinanceYear(FinanceYear FinanceYear)
        {
            if (FinanceYear.Id > 0)
            {
                _IFinancialYearService.UpdateFinanceYear(FinanceYear);
            }
            else
            {
                _IFinancialYearService.AddFinanceYear(FinanceYear);
            }

            return RedirectToAction("FinancialYearListLoad");
        }
        public ActionResult Savecoa(coa coa)
        {
            if (coa.Id > 0)
            {
                _ICOAService.Updatecoa(coa);
            }
            else
            {
                _ICOAService.Addcoa(coa);
            }

            return RedirectToAction("COAListLoad");
        }
        public ActionResult Saveledger(ledger ledger)
        {
            if (ledger.Id > 0)
            {
                _ICOAService.Updateledger(ledger);
            }
            else
            {
                partner partner = new partner();
                partner.code = ledger.name;
                partner.name = ledger.name;
                partner.details = ledger.details;
                _IAssetService.AddPartner(partner);
                ledger.partnerId = partner.Id;
                _ICOAService.Addledger(ledger);
                ledgertxn led = new ledgertxn();
                led.dr = ledger.dr;
                led.cr = ledger.cr;
                led.txndate = DateTime.Now.Date;
                led.ledgerId = ledger.Id;
                led.details = "Opening Balance";
                _ICOAService.AddLedgertxn(led);
                // cash ledger flow
                ledgertxn cashled = new ledgertxn();
                cashled.dr = ledger.cr;
                cashled.cr = ledger.dr;
                cashled.txndate = DateTime.Now.Date;
                cashled.ledgerId = 21;
                cashled.details = "Opening Balance" + ledger.name;
                _ICOAService.AddLedgertxn(cashled);

            }
            return RedirectToAction("LedgerListLoad");
        }
        [HttpPost]
        public ActionResult SaveCustomerr(Customer Customer)
        {
            if (Customer.Id > 0)
            {
                _ICustomerService.UpdateCustomer(Customer);
            }
            else
            {
                var partner = new partner();
                partner.name = Customer.CustomerName;
                partner.code = Customer.code;
                partner.details = Customer.Details;
                _IAssetService.AddPartner(partner);
                Customer.partnerId = partner.Id;
                _ICustomerService.AddCustomer(Customer);
                var custcat = _ICustomerService.GetCustomerCategory(Customer.customercategoryId);
                ledger ledger = new ledger();
                ledger.partnerId = Customer.partnerId;
                ledger.coaId = custcat.coaId;
                ledger.details = "Customer";
                ledger.name = Customer.CustomerName;
                _ICOAService.Addledger(ledger);
                ledgertxn led = new ledgertxn();
                led.dr = Customer.dr;
                led.cr = Customer.cr;
                led.txndate = DateTime.Now.Date;
                led.ledgerId = ledger.Id;
                led.details = "Opening Balance";
                _ICOAService.AddLedgertxn(led);

                ledgertxn ledcash = new ledgertxn();
                ledcash.cr = Customer.dr;
                ledcash.dr = Customer.cr;
                ledcash.txndate = DateTime.Now.Date;
                ledcash.ledgerId = 21;
                ledcash.details = "Opening Balance for " + Customer.CustomerName;
                _ICOAService.AddLedgertxn(ledcash);
            }
            _ICustomerService.DeleteCustomerContact(Customer.Id);
            return Json(Customer);
        }
        [HttpPost]
        public ActionResult SaveCustomerrContact(List<CustomerContact> CustomerContact)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                foreach (var item in CustomerContact)
                {
                    _ICustomerService.AddCustomerContact(item);
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
        public ActionResult SaveCustomerUserAssign(CustomerUserAssign CustomerUserAssign)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                var data=_ICustomerService.GetAllCustomerUserAssign().Where(x=>x.CustomerId==CustomerUserAssign.CustomerId).FirstOrDefault();
                if (data == null)
                    data = new CustomerUserAssign();
                data.CustomerId = CustomerUserAssign.CustomerId;
                data.assignedDay = CustomerUserAssign.assignedDay;
                data.AssignedUserId = CustomerUserAssign.AssignedUserId;
                if (data.Id > 0)
                    _ICustomerService.UpdateCustomerUserAssign(data);
                else
                    _ICustomerService.AddCustomerUserAssign(data);
            }

            catch (Exception ex)
            {
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
            return Json("Success");
        }
        public ActionResult SaveEmployee(Employee Employee)
        {
            if (Employee.Id > 0)
            {
                _IEmployeeService.UpdateEmployee(Employee);
            }
            else
            {
                var partner = new partner();
                partner.name = Employee.firstname + " " + Employee.middlename + " " + Employee.lastname;
                partner.code = Employee.code;
                partner.details = Employee.phone;
                _IAssetService.AddPartner(partner);
                Employee.partnerId = partner.Id;
                _IEmployeeService.AddEmployee(Employee);
                var empcat = _IEmployeeService.GetEmployeeCategory(Employee.EmployeeCategoryId);
                ledger ledger = new ledger();
                ledger.partnerId = Employee.partnerId;
                ledger.coaId = empcat.coaId;
                ledger.details = "Employee";
                ledger.name = Employee.firstname + " " + Employee.middlename + " " + Employee.lastname;
                _ICOAService.Addledger(ledger);
                ledgertxn led = new ledgertxn();
                led.dr = Employee.dr;
                led.cr = Employee.cr;
                led.txndate = DateTime.Now.Date;
                led.ledgerId = ledger.Id;
                led.details = "Opening Balance";
                _ICOAService.AddLedgertxn(led);
            }

            return RedirectToAction("EmpListLoad");
        }
        [HttpPost]
        public ActionResult SavePayment(Payment Payment)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                ModelState.Remove("Id");
                if (ModelState.IsValid)
                {

                    if (Payment.Id > 0)
                    {
                        _ICOAService.UpdatePayment(Payment);
                    }
                    else
                    {
                        Payment.balance = Payment.amount;
                        _ICOAService.AddPayment(Payment);

                    }
                    return RedirectToAction("PaymentLoad");
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
        public ActionResult SaveReceipt(Receipt Receipt)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                ModelState.Remove("Id");
                if (ModelState.IsValid)
                {
                    if (Receipt.Id > 0)
                    {
                        _ICOAService.UpdateReceipt(Receipt);
                    }
                    else
                    {
                        Receipt.balance = Receipt.amount;
                        _ICOAService.AddReceipt(Receipt);
                    }
                    return RedirectToAction("ReceiptLoad");
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
        public ActionResult SaveBankTxn(BankTxn BankTxn)
        {
            if (BankTxn.Id > 0)
            {
                _IBankService.UpdateBankTxn(BankTxn);
            }
            else
            {
                _IBankService.AddBankTxn(BankTxn);
            }

            return RedirectToAction("BankTxnLoad");
        }
        public ActionResult SaveServiceType(servicetype servicetype)
        {
            if (servicetype.Id > 0)
            {
                _IServiceService.UpdateServicetype(servicetype);
            }
            else
            {
                _IServiceService.AddServicetype(servicetype);
            }

            return RedirectToAction("ServiceTypeLoad");
        }
        public ActionResult SaveService(service service)
        {
            if (service.Id > 0)
            {
                _IServiceService.UpdateService(service);
            }
            else
            {
                _IServiceService.AddService(service);
            }

            return RedirectToAction("ServiceLoad");
        }
        #endregion
        #region AjaxFunctions
        [HttpGet]
        public JsonResult GetAllStore()
        {
            var data = _IStoreService.GetAllStore().Where(x => x.Status > 0).ToList();
            return Json(data);
        }
        #endregion
        #region "Search"
        [HttpGet]
        public ActionResult SearchItemMaster(string serCode = "", string serName = "", long serCategory = 0, long serBrand = 0)
        {

            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IItemService.GetAllItemMaster().Where(x =>
            (x.ItemName.ToLower().Contains(serName.ToLower()) || serName == "")
            &&(x.ItemBrandId==serBrand||serBrand==0)
            &&(x.CategoryId==serCategory||serCategory==0)
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
        public ActionResult SearchStore(string serName = "", string serCode = "", long serCity = 0)
        {
            serName = serName ?? "";
            serCode = serCode ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;

            var Results = _IStoreService.GetAllStore().Where(x =>
           (x.StoreName.ToLower().Contains(serName.ToLower()) || serName == "")
           && (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
           && (x.CityId == serCity || serCity == 0)
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
        public ActionResult Searchcategory(string serCategoryName = "")
        {
            serCategoryName = serCategoryName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ItemCategoryService.GetAllCategory().Where(x =>
            (x.CategoryName.ToLower().Contains(serCategoryName.ToLower()) || serCategoryName == "")).ToList();
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
        public ActionResult SearchSuppliercategory(string serCode = "", string serName = "")
        {
            serCode = serCode ?? "";
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISupplierService.GetAllSupplierCategory().Where(x =>
            (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
             && (x.name.ToLower().Contains(serName.ToLower()) || serName == "")
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
        public ActionResult SearchSupplier(string serCode = "", string serName = "", long serCity = 0, long serCategory = 0, long serGroup = 0)
        {
            serCode = serCode ?? "";
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISupplierService.GetAllSupplier().Where(x =>
            (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
            && (x.SupplierName.ToLower().Contains(serName.ToLower()) || serName == "")
            && (x.CityId == serCity || serCity == 0)
            && (x.categoryId == serCategory || serCategory == 0)
            && (x.suppliergroupId == serGroup || serGroup == 0)
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
        public ActionResult SearchCustomercategory(string serCode = "", string serName = "")
        {
            serCode = serCode ?? "";
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICustomerService.GetAllCustomerCategory().Where(x =>
              (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
            && (x.name.ToLower().Contains(serName.ToLower()) || serName == "")
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
        public ActionResult SearchCustomer(string serCode = "", string serName = "", long serCity = 0, long serCategory = 0, long serGroup = 0)
        {
            serCode = serCode ?? "";
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICustomerService.GetAllCustomer().Where(x =>
            (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
            && (x.CustomerName.ToLower().Contains(serName.ToLower()) || serName == "")
            && (x.CityId == serCity || serCity == 0)
            && (x.customercategoryId == serCategory || serCategory == 0)
            && (x.customergroupId == serGroup || serGroup == 0)
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
        public ActionResult SearchEmployeeCategory(string serCode = "", string serName = "")
        {
            serCode = serCode ?? "";
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IEmployeeService.GetAllEmployeeCategory().Where(x =>
           (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
           && (x.name.ToLower().Contains(serName.ToLower()) || serName == "")
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
        public ActionResult SearchEmployeeGroup(string serCode = "", string serName = "")
        {
            serCode = serCode ?? "";
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IEmployeeService.GetAllEmployeeGroup().Where(x =>
           (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
           && (x.name.ToLower().Contains(serName.ToLower()) || serName == "")
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
        public ActionResult SearchEmployee(string serCode = "", string serFirstName = "", string serLastName = "", string serEmail = "", string serPhone = "", long serDepartment = 0, long serDesignation = 0, long serCategory = 0, long serGroup = 0)
        {
            serCode = serCode ?? "";
            serFirstName = serFirstName ?? "";
            serLastName = serLastName ?? "";
            serEmail = serEmail ?? "";
            serPhone = serPhone ?? "";


            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IEmployeeService.GetAllEmployee().Where(x =>
           (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
           && (x.firstname.ToLower().Contains(serFirstName.ToLower()) || serFirstName == "")
           && (x.lastname.ToLower().Contains(serLastName.ToLower()) || serLastName == "")
           && (x.mail.ToLower().Contains(serEmail.ToLower()) || serEmail == "")
           && (x.phone.ToLower().Contains(serPhone.ToLower()) || serPhone == "")
           && (x.EmployeeCategoryId == serCategory || serCategory == 0)
           && (x.EmployeeGroupId == serGroup || serGroup == 0)
           && (x.DepartmentId == serDepartment || serDepartment == 0)
           && (x.DesignationId == serDesignation || serDesignation == 0)
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
        public ActionResult SearchCreditCard(string serCode = "", string serName = "", long serBank = 0)
        {
            serCode = serCode ?? "";
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICreditCardService.GetAllCreditCard().Where(x =>
           (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
         && (x.number.ToLower().Contains(serName.ToLower()) || serName == "")
           && (x.BankId == serBank || serBank == 0)
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
        public ActionResult SearchBank(string serCode = "", string serAccount = "", string serBank = "", long serCurrency = 0)
        {
            serCode = serCode ?? "";
            serAccount = serAccount ?? "";
            serBank = serBank ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IBankService.GetAllBank().Where(x =>
           (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
         && (x.accno.ToLower().Contains(serAccount.ToLower()) || serAccount == "")
          && (x.bankname.ToLower().Contains(serBank.ToLower()) || serBank == "")
           && (x.CurrencyId == serCurrency || serCurrency == 0)
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
        public ActionResult SearchAsset(string serCode = "", string serName = "", long serCategory = 0)
        {
            serCode = serCode ?? "";
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IAssetService.GetAllAsset().Where(x =>
           (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
         && (x.name.ToLower().Contains(serName.ToLower()) || serName == "")
           && (x.AssetCategoryId == serCategory || serCategory == 0)
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
        public ActionResult SearchAssetCategory(string serCode = "", string serName = "")
        {
            serCode = serCode ?? "";
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IAssetService.GetAllAssetCategory().Where(x =>
           (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
         && (x.name.ToLower().Contains(serName.ToLower()) || serName == "")
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
        public ActionResult SearchItemCategory(string serCode = "", string serName = "")
        {
            serCode = serCode ?? "";
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ItemCategoryService.GetAllCategory().Where(x =>
           (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
         && (x.CategoryName.ToLower().Contains(serName.ToLower()) || serName == "")
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
        public ActionResult SearchItemBrand(string serName = "")
        {
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IItemService.GetAllItemBrand().Where(x =>
           (x.brnadname.ToLower().Contains(serName.ToLower()) || serName == "")
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
        public ActionResult SearchItem(string serCode = "", string serName = "", long serCategory = 0, long serBrand = 0)
        {
            serCode = serCode ?? "";
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IItemService.GetAllItemMaster().Where(x =>
           (x.ItemCode.ToLower().Contains(serCode.ToLower()) || serCode == "")
         && (x.ItemName.ToLower().Contains(serName.ToLower()) || serName == "")
         && (x.CategoryId == serCategory || serCategory == 0)
           && (x.ItemBrandId == serBrand || serBrand == 0)
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
        public ActionResult SearchCustomerGroup(string serCode = "", string serName = "")
        {
            serCode = serCode ?? "";
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICustomerService.GetAllCustomergroup().Where(x =>
           (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
         && (x.name.ToLower().Contains(serName.ToLower()) || serName == "")
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
        public ActionResult SearchSupplierGroup(string serCode = "", string serName = "")
        {
            serCode = serCode ?? "";
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ISupplierService.GetAllSuppliergroup().Where(x =>
            (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
             && (x.name.ToLower().Contains(serName.ToLower()) || serName == "")
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
        public ActionResult SearchDesignationCategory(string serCode = "", string serName = "")
        {
            serCode = serCode ?? "";
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IDesignationService.GetAllDesignationGroup().Where(x =>
            (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
             && (x.name.ToLower().Contains(serName.ToLower()) || serName == "")
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
        public ActionResult SearchDesignation(string serCode = "", string serName = "", long serCategory = 0)
        {
            serCode = serCode ?? "";
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IDesignationService.GetAllDesignation().Where(x =>
            (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
             && (x.DesignationGroupsId == serCategory || serCategory == 0)
             && (x.name.ToLower().Contains(serName.ToLower()) || serName == "")
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
        public ActionResult SearchDepartmentCategory(string serCode = "", string serName = "")
        {
            serCode = serCode ?? "";
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IDepartmentService.GetAllDepartmentGroup().Where(x =>
            (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
             && (x.name.ToLower().Contains(serName.ToLower()) || serName == "")
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
        public ActionResult SearchDepartment(string serCode = "", string serName = "", long serCategory = 0)
        {
            serCode = serCode ?? "";
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IDepartmentService.GetAllDepartment().Where(x =>
            (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
             && (x.DepartmentGroupId == serCategory || serCategory == 0)
             && (x.name.ToLower().Contains(serName.ToLower()) || serName == "")
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
        public ActionResult SearchBranchCategory(string serCode = "", string serName = "")
        {
            serCode = serCode ?? "";
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IBranchService.GetAllBranchGroup().Where(x =>
            (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
             && (x.name.ToLower().Contains(serName.ToLower()) || serName == "")
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
        public ActionResult SearchBranch(string serCode = "", string serName = "", long serCategory = 0)
        {
            serCode = serCode ?? "";
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IBranchService.GetAllBranch().Where(x =>
            (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
             && (x.BranchGroupId == serCategory || serCategory == 0)
             && (x.name.ToLower().Contains(serName.ToLower()) || serName == "")
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
        public ActionResult SearchCurrency(string serName = "", string serSUnit = "")
        {
            serName = serName ?? "";
            serSUnit = serSUnit ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICurrencyService.GetAllCurrency().Where(x =>
            (x.name.ToLower().Contains(serName.ToLower()) || serName == "")
             && (x.smallunit.ToLower().Contains(serSUnit.ToLower()) || serSUnit == "")
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
        public ActionResult SearchFinancialYear(string serName = "")
        {
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IFinancialYearService.GetAllFinanceYear().Where(x =>
            (x.YearName.ToLower().Contains(serName.ToLower()) || serName == "")
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
        public ActionResult SearchTaxMaster(string serName = "", double serPer = 0)
        {
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ITaxMasterService.GetAllTaxMaster().Where(x =>
            (x.TaxName.ToLower().Contains(serName.ToLower()) || serName == "")
             && (x.percentage == serPer || serPer == 0)
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
        public ActionResult SearchCOA(string serCode = "", string serName = "", long serCategory = 0)
        {
            serCode = serCode ?? "";
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICOAService.GetAllcoa().Where(x =>
            (x.code.ToLower().Contains(serCode.ToLower()) || serCode == "")
             && (x.name.ToLower().Contains(serName.ToLower()) || serName == "")
               && (x.COATypeId == serCategory || serCategory == 0)
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
        public ActionResult SearchLedger(string serName = "", long serCategory = 0)
        {
            serName = serName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICOAService.GetAllledger().Where(x =>
            (x.name.ToLower().Contains(serName.ToLower()) || serName == "")
            && (x.coa.COATypeId == serCategory || serCategory == 0)
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
        public ActionResult SearchPayments(string serfromdate = "", string sertodate = "", string serVoucherNo = "", string serRefNo = "")
        {
            serRefNo = serRefNo ?? "";
            serVoucherNo = serVoucherNo ?? "";
            DateTime From = serfromdate == null ? DateTime.MinValue : Convert.ToDateTime(serfromdate);
            DateTime To = sertodate == null ? DateTime.MaxValue : Convert.ToDateTime(sertodate);
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICOAService.GetAllPayment().Where(x =>
            (x.transno.ToLower().Contains(serVoucherNo.ToLower()) || serVoucherNo == "")
            && (x.refno.ToLower().Contains(serRefNo.ToLower()) || serRefNo == "")
              && (x.trandate >= From && x.trandate <= To)).ToList();
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
        public ActionResult SearchReceipts(string serfromdate = "", string sertodate = "", string serVoucherNo = "", string serRefNo = "")
        {
            serRefNo = serRefNo ?? "";
            serVoucherNo = serVoucherNo ?? "";
            DateTime From = serfromdate == null ? DateTime.MinValue : Convert.ToDateTime(serfromdate);
            DateTime To = sertodate == null ? DateTime.MaxValue : Convert.ToDateTime(sertodate);
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICOAService.GetAllReceipt().Where(x =>
            (x.transno.ToLower().Contains(serVoucherNo.ToLower()) || serVoucherNo == "")
            && (x.refno.ToLower().Contains(serRefNo.ToLower()) || serRefNo == "")
              && (x.trandate >= From && x.trandate <= To)).ToList();
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
        public ActionResult GetReceipts(long Id)
        {
          
            var Results = _ICOAService.GetAllReceipt().Where(x =>x.Id==Id).FirstOrDefault();
            
            return Json(Results);
        }
        #endregion


        [HttpPost]
        public ActionResult DeleteCustomer(Customer Customer)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                var model = _ICustomerService.GetCustomer(Customer.Id);
                model.Status = 0;
                _ICustomerService.UpdateCustomer(model);
                return Json("Deleted Successfully");
            }
            catch (Exception ex)
            {
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
        }

        [HttpPost]
        public ActionResult DeleteItem(long Id)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                var model = _IItemService.GetItemMaster(Id);
                if (model != null)
                {
                    var sales=_ISalesService.GetAllSalesDetail().Where(x=>x.ItemMasterId==Id &&x.qty!=0).FirstOrDefault().qty;
                    var pur=_IPurchaseService.GetAllPurchaseOrderDetail().Where(x=>x.ItemMasterId==Id&&x.qty!=0).FirstOrDefault().qty;
                    if (sales != 0 || pur != 0)
                        return Json("Item Cannot Delete");
                    _IItemService.DeleteItemMaster(model);
                }
                return Json("Success");
            }
            catch (Exception ex)
            {
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
        }
        [HttpPost]
        public ActionResult ShowItem(long Id)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                var model = _IItemService.GetItemMaster(Id);
                //var model = _IItemService.GetItemMaster(Id);
                if (model != null)
                {
                    model.Showcart = !model.Showcart;
                    _IItemService.UpdateItemMaster(model);
                }
                return Json("Success");
            }
            catch (Exception ex)
            {
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
        }
        [HttpPost]
        public ActionResult UpdatePrice(long Id, double price, double mobileprice, double baqalaprice, double stationaryprice, int type)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                var model = _IItemService.GetItemMaster(Id);
                if (model != null)
                {
                    model.Offerprice = price;
                    model.MobilePrice = mobileprice;
                    model.BaqalaPrice = baqalaprice;
                    model.StationaryPrice = stationaryprice;
                    model.type = type;
                    _IItemService.UpdateItemMaster(model);
                }
                return Json("Success");
            }
            catch (Exception ex)
            {
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
        }
        [HttpPost]
        public ActionResult DeleteAttachmentItem(long Id)
        {
            try
            {
                var model = _IItemService.GetItemImage(Id);
                if (model != null)
                {
                    model.Status = 0;
                    _IItemService.UpdateItemImage(model);
                    string filePath = _hostingEnvironment.WebRootPath+ model.thumb;
                    if (System.IO.File.Exists(filePath))
                    {
                        System.IO.File.Delete(filePath);
                    }
                }
                return Json("Success");
            }
            catch (Exception ex)
            {
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
        }

        [HttpPost]
        public ActionResult AddImageattachment(IFormCollection data)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                var id=Convert.ToInt64(data["attachid"].ToString());
                foreach (var file in data.Files)
                {
                    if (file.Length > 0)
                    {
                        string filePath = Path.Combine(_hostingEnvironment.WebRootPath+_appEnvironment.ItemImagepath,data["attachid"].ToString()+ file.FileName);
                        using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                        {
                            file.CopyTo(fileStream);
                        }
                        var imagedata=new ItemImage();
                        imagedata.ItemMasterId = id;
                        imagedata.thumb = Path.Combine(_appEnvironment.ItemImagepath, data["attachid"].ToString() + file.FileName);
                        _IItemService.AddItemImage(imagedata);
                    }


                }
                return Json("Success");
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText(@"C:\inetpub\wwwroot\TradeMateSite\Error.txt", ex.InnerException.ToString());
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
        }
        [HttpGet]
        public ActionResult GetItemStock(long Id)
        {

            var response = _IItemService.GetStockMaster().Where(x => x.ItemMasterId == Id).GroupBy(x => x.ItemMasterId).Select(x => new { PurPrice = x.First().ItemMaster.PurPrice, stock = x.Sum(y => y.stock) });
            return Json(response);
        }
        [HttpGet]
        public ActionResult GetUserAssigned(long UserId = 0)
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ItemCategoryService.GetAllUserPagesAssigned().Where(x => x.UserId == UserId).ToList();
            //var Results = _ItemCategoryService.GetAllUserPagesAssigned().ToList();
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
        public ActionResult UpdateMapping(List<UserPagesAssigned> userPagesAssigneds, long type = 0)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                foreach (var item in userPagesAssigneds)
                {
                    var model=_ItemCategoryService.GetAllUserPagesAssigned().Where(x=>x.UserId==item.UserId &&x.pagename==item.pagename).FirstOrDefault();
                    if (model == null)
                    {
                        model = new UserPagesAssigned();
                        model.UserId = item.UserId;
                        model.pagename = item.pagename;
                        model.IsActive = item.IsActive;
                        _ItemCategoryService.AddUserPagesAssigned(model);
                    }
                    else
                    {
                        model.IsActive = item.IsActive;
                        _ItemCategoryService.UpdateUserPagesAssigned(model);
                    }
                }
                if (type != 0)
                {
                    var user=_IApplicationUserService.GetApplicationUser(userPagesAssigneds[0].UserId);
                    user.UserTypeId = type;
                    _IApplicationUserService.UpdateApplicationUser(user);
                }
                return Json("Success");
            }
            catch (Exception ex)
            {
                var errormessage = "Error occured: " + ex.Message;
                return Json(errormessage);
            }
        }

        [HttpGet]
        public ActionResult GetItemAttachment(long Id)
        {
            var data=_IItemService.GetItemMaster(Id);
            var images = _IItemService.GetAllItemImage().Where(x=>x.ItemMasterId==Id).ToList();
            var result = new
            {
                data ,
                images
            };
            return Json(result);
        }


    }
}