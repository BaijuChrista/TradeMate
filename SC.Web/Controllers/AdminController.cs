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

namespace SC.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly ICountryService _ICountryService;
        private readonly IStateService _IStateService;
        private readonly ICityService _ICityService;        
        private readonly IUserTypeService _IUserTypeService;
        private readonly IApplicationUserService _IApplicationUserService;
        private readonly IMotherCompanyService _IMotherCompanyService;
        private readonly IFinancialYearService _IFinancialYearService;
        private readonly ITaxMasterService _ITaxMasterService;                                            
        private readonly ICompanyService _ICompanyService;              
        private readonly ICurrencyService _ICurrencyService;                       
        private readonly IMapper _mapper;
        private readonly Data.AppSettings _appEnvironment;
        private readonly IHostingEnvironment _hostingEnvironment;

        public AdminController(ICountryService CountryService, ICustomerService CustomerServiceService, IHostingEnvironment hostingEnvironment, IOptions<SC.Data.AppSettings> appSettings, IStateService StateService, ICityService CityService,  IUserTypeService UserTypeService, IApplicationUserService ApplicationUserService, IMotherCompanyService MotherCompanyService, IFinancialYearService FinanceYearService, ITaxMasterService TaxMasterService,  ICompanyService CompanyService, ICustomerService CustomerService,  IMapper mapperService, ICurrencyService currencyService, IStoreService StoreService)
        {
            _ICountryService = CountryService;
            _IStateService = StateService;
            _ICityService = CityService;            
            _IUserTypeService = UserTypeService;
            _IApplicationUserService = ApplicationUserService;
            _IMotherCompanyService = MotherCompanyService;
            _IFinancialYearService = FinanceYearService;
            _ITaxMasterService = TaxMasterService;                    
            _ICompanyService = CompanyService;            
            _ICurrencyService = currencyService;                     
            _mapper = mapperService;
            _appEnvironment = appSettings.Value;
            _hostingEnvironment = hostingEnvironment;
        }
        public IActionResult Index()
        {
            return View("../Home/Index");
        }

        public IActionResult MotherCompanyLoad(long Id = 1)
        {
            MotherCompany Model = new MotherCompany();
            if (Id > 0)
            {
                Model = _mapper.Map<Data.MotherCompany, MotherCompany>(_IMotherCompanyService.GetMotherCompany(1));
                if (Model.image != null)
                    Model.image = Path.Combine(_appEnvironment.MotherCompanyImagepath, Model.image);
            }
            else
            {
                Model = new MotherCompany();
            }
            return View("../Admin/MotherCompany", Model);
        }
        
        public IActionResult UserTypeListLoad()
        {
            return View("../Admin/UserType");
        }
        public IActionResult CountryListLoad()
        {
            return View("../Admin/Country");
        }
        public IActionResult StateListLoad()
        {
            return View("../Admin/State");
        }
        public IActionResult CityListLoad()
        {
            return View("../Admin/City");
        }
        public IActionResult CompanyListLoad()
        {
            return View("../Admin/CompanyList");
        }
       


       


        public IActionResult NewCompany(long Id = 0)
        {
            Company Model = new Company();
            if (Id > 0)
            {
                Model = _mapper.Map<Data.Company, Company>(_ICompanyService.GetCompany(Id));
            }
            else
            {
                Model = new Company();
            }
            return View("../Admin/View_NewCompany", Model);
        }

        [HttpPost]
        public IActionResult CreateCompany(Data.Company Company)
        {
            StringBuilder msg = new StringBuilder();
            try
            {
                ModelState.Remove("Id");
                if (ModelState.IsValid)
                {

                    if (Company.Id > 0)
                    {
                        _ICompanyService.UpdateCompany(Company);
                    }
                    else
                    {
                        _ICompanyService.AddCompany(Company);
                    }

                    return Redirect("CompanyListLoad");
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
















        #region "Select Functions"
        [HttpGet]
        public ActionResult GetuserType()
        {

            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IUserTypeService.GetAllUserType();
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
        public ActionResult GetApplicationUser()
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
        public ActionResult GetMotherCompany()
        {

            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IMotherCompanyService.GetAllMotherCompany();
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
        public ActionResult GetCompany()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICompanyService.GetAllCompany();
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
        public ActionResult GetCountry()
        {

            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICountryService.GetAllCountries();
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
        public ActionResult GetState()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IStateService.GetAllState();
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
        
       
              
        #endregion

        #region "Insert Functions"

        [HttpPost]
        public JsonResult CreateUserType(UserType UserType)
        {
            StringBuilder msg = new StringBuilder();

            try
            {
                ModelState.Remove("Id");
                if (ModelState.IsValid)
                {
                    var model = _mapper.Map<UserType, SC.Data.UserType>(UserType);
                    _IUserTypeService.AddUserType(model);
                    return Json("Saved Successfully");
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
        public JsonResult CreateApplicationUser(ApplicationUser ApplicationUser)
        {
            StringBuilder msg = new StringBuilder();

            try
            {
                ModelState.Remove("Id");
                if (ModelState.IsValid)
                {
                    var model = _mapper.Map<ApplicationUser, SC.Data.ApplicationUser>(ApplicationUser);
                    _IApplicationUserService.AddApplicationUser(model);
                    return Json("Saved Successfully");
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
       
    
     
        
        //[HttpPost]
        //public IActionResult CreateMotherCompany(MotherCompany MotherCompany)
        //{
        //    StringBuilder msg = new StringBuilder();
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            var files = HttpContext.Request.Form.Files;

        //            var model = _mapper.Map<MotherCompany, SC.Data.MotherCompany>(MotherCompany);
        //            foreach (var Image in files)
        //            {
        //                if (Image != null && Image.Length > 0)
        //                {
        //                    var file = Image;
        //                    //There is an error here
        //                    var uploads = _hostingEnvironment.WebRootPath + "\\" + _appEnvironment.MotherCompanyImagepath; ;
        //                    if (file.Length > 0)
        //                    {
        //                        var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
        //                        using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
        //                        {
        //                            file.CopyToAsync(fileStream);
        //                            model.image = fileName;
        //                        }

        //                    }
        //                }
        //            }
        //            if (MotherCompany.Id > 0)
        //            {
        //                _IMotherCompanyService.UpdateMotherCompany(model);
        //            }
        //            else
        //            {
        //                _IMotherCompanyService.AddMotherCompany(model);
        //            }

        //            return Redirect("MotherCompanyLoad");
        //        }
        //        else
        //        {
        //            var errorList = (from item in ModelState
        //                             where item.Value.Errors.Any()
        //                             select item.Value.Errors[0].ErrorMessage).ToList();

        //            return Json(errorList);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        var errormessage = "Error occured: " + ex.Message;
        //        return Json(errormessage);
        //    }

        //}

        //[HttpPost]
        //public JsonResult CreateSupplierContact(SupplierContact SupplierContact)
        //{
        //    StringBuilder msg = new StringBuilder();
        //    try
        //    {
        //        ModelState.Remove("Id");
        //        if (ModelState.IsValid)
        //        {
        //            var model = _mapper.Map<SupplierContact, SC.Data.SupplierContact>(SupplierContact);
        //            _ISupplierService.AddSupplierContact(model);
        //            return Json("Saved Successfully");
        //        }
        //        else
        //        {
        //            var errorList = (from item in ModelState
        //                             where item.Value.Errors.Any()
        //                             select item.Value.Errors[0].ErrorMessage).ToList();

        //            return Json(errorList);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        var errormessage = "Error occured: " + ex.Message;
        //        return Json(errormessage);
        //    }

        //}
        [HttpPost]
        public JsonResult CreateCountry(Country Country)
        {
            StringBuilder msg = new StringBuilder();

            try
            {
                ModelState.Remove("Id");
                if (ModelState.IsValid)
                {
                    var model = _mapper.Map<Country, SC.Data.Country>(Country);
                    _ICountryService.AddCountry(model);
                    return Json("Saved Successfully");
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
        public JsonResult CreateState(State State)
        {
            StringBuilder msg = new StringBuilder();

            try
            {
                ModelState.Remove("Id");
                if (ModelState.IsValid)
                {
                    var model = _mapper.Map<State, SC.Data.State>(State);
                    _IStateService.AddState(model);
                    return Json("Saved Successfully");
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
        public JsonResult CreateCity(City City)
        {
            StringBuilder msg = new StringBuilder();

            try
            {
                ModelState.Remove("Id");
                if (ModelState.IsValid)
                {
                    var model = _mapper.Map<City, SC.Data.City>(City);
                    _ICityService.AddCity(model);
                    return Json("Saved Successfully");
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
       
       

      




       

        #endregion

        #region "Update Functions"
        public string EditCountry(Country Country)
        {
            string msg;
            try
            {
                if (ModelState.IsValid)
                {
                    var model = _mapper.Map<Country, SC.Data.Country>(Country);
                    _ICountryService.UpdateCountry(model);
                    msg = "Saved Successfully";
                }
                else
                {
                    msg = "Some Validation ";
                }
            }
            catch (Exception ex)
            {
                msg = "Error occured:" + ex.Message;
            }
            return msg;
        }
        public string EditState(State State)
        {
            string msg;
            try
            {
                if (ModelState.IsValid)
                {
                    var model = _mapper.Map<State, SC.Data.State>(State);
                    _IStateService.UpdateState(model);
                    msg = "Saved Successfully";
                }
                else
                {
                    msg = "Some Validation ";
                }
            }
            catch (Exception ex)
            {
                msg = "Error occured:" + ex.Message;
            }
            return msg;
        }
        public string EditCity(City City)
        {
            string msg;
            try
            {
                if (ModelState.IsValid)
                {
                    var model = _mapper.Map<City, SC.Data.City>(City);
                    _ICityService.UpdateCity(model);
                    msg = "Saved Successfully";
                }
                else
                {
                    msg = "Some Validation ";
                }
            }
            catch (Exception ex)
            {
                msg = "Error occured:" + ex.Message;
            }
            return msg;
        }       
      
        public string EditUserType(UserType UserType)
        {
            string msg;
            try
            {
                if (ModelState.IsValid)
                {
                    var model = _mapper.Map<UserType, SC.Data.UserType>(UserType);
                    _IUserTypeService.UpdateUserType(model);
                    msg = "Saved Successfully";
                }
                else
                {
                    msg = "Some Validation ";
                }
            }
            catch (Exception ex)
            {
                msg = "Error occured:" + ex.Message;
            }
            return msg;
        }
        
       
        //public string EditStore(Store Store)
        //{
        //    string msg;
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            var model = _mapper.Map<Store, SC.Data.Store>(Store);
        //            _IStoreService.UpdateStore(model);
        //            msg = "Saved Successfully";
        //        }
        //        else
        //        {
        //            msg = "Some Validation ";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        msg = "Error occured:" + ex.Message;
        //    }
        //    return msg;
        //}
        #endregion

        #region AjaxFunctions
     
       
        [HttpGet]
        public JsonResult GetAllTaxMaster()
        {
            var data = _ITaxMasterService.GetAllTaxMaster().Where(x => x.Status > 0).ToList();
            return Json(data);
        }
             
         
        #endregion

        #region "Search"
       
      
        [HttpGet]
        public ActionResult SearchCompany(string serName = "", string serCity = "", string serlicense = "")
        {
            serName = serName ?? "";
            serCity = serCity ?? "";
            serlicense = serlicense ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICompanyService.GetAllCompany().Where(x =>
            (x.CompanyName.ToLower().Contains(serName.ToLower()) || serName == "")
            && (x.City.Name.ToLower().Contains(serCity.ToLower()) || serCity == "")
            && (x.License.ToLower().Contains(serlicense.ToLower()) || serlicense == "")
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
        public ActionResult SearchCity(string serCountry = "",string serStateName = "", string serCityName = "")
        {
            serStateName = serStateName ?? "";
            serCityName = serCityName ?? "";
            serCountry = serCountry ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICityService.GetAllCity().Where(x =>
            (x.State.Country.CountryName.ToLower().Contains(serCountry.ToLower()) || serCountry == "")
            && (x.State.Name.ToLower().Contains(serStateName.ToLower()) || serStateName == "")
            && (x.Name.ToLower().Contains(serCityName.ToLower()) || serCityName == "")
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
        public ActionResult SearchState(string serCountry = "", string serStateName = "")
        {
            serStateName = serStateName ?? "";          
            serCountry = serCountry ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IStateService.GetAllState().Where(x =>
            (x.Country.CountryName.ToLower().Contains(serCountry.ToLower()) || serCountry == "")
            && (x.Name.ToLower().Contains(serStateName.ToLower()) || serStateName == "")          
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
        public ActionResult SearchCountry(string serCountry = "")
        {           
            serCountry = serCountry ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _ICountryService.GetAllCountries().Where(x =>
            (x.CountryName.ToLower().Contains(serCountry.ToLower()) || serCountry == "")           
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
        public ActionResult SearchFinancialYear(string serYearName = "")
        {
            serYearName = serYearName ?? "";
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _IFinancialYearService.GetAllFinanceYear().Where(x =>
           (x.YearName.ToLower().Contains(serYearName.ToLower()) || serYearName == "")).ToList();
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

    }
}
