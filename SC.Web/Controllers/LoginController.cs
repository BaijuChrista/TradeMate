using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SC.Service.Interface;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using SC.Data;
using Microsoft.Extensions.Options;
using SC.Service.Concrete;

namespace SC.Web.Controllers
{
    public class LoginController : Controller
    {
        private IUserService _userService;
        private IUserTypeService _userTypeService;
        private IItemCategory _categoryService;
        private readonly AppSettings _appSettings;
        private IMapper _mapper;
        public LoginController(
            IUserService userService,
            IUserTypeService userTypeService,
            IItemCategory item,
             IMapper mapper,
            IOptions<AppSettings> appSettings)
        {
            _userService = userService;
            _userTypeService = userTypeService;
            _categoryService = item;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        public IActionResult Index()
        {
            return View("../Admin/login");
        }
        public IActionResult UserMapping()
        {
            return View("../Admin/UserMapping");
        }
        public IActionResult Register()
        {
            return View("../Admin/Register");
        }
        public IActionResult ChangePassword()
        {
            return View("../Admin/ChangePassword");
        }

        [AllowAnonymous]
        [HttpPost]
        public JsonResult Authenticate(string Username, string Password, long type)
        {
            var user = _userService.Authenticate(Username, Password);
            
            if (user == null)
                return Json(new { message = "Username or password is incorrect" });
            if (user.UserTypeId != type&&(user.UserTypeId==3||user.UserTypeId==4))
                return Json(new { message = "UnAutherized access" });
            if (user.Status == 2)
                return Json(new { message = "Please verify your emailId" });
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
            HttpContext.Session.SetString("UserId", user.Id.ToString());
            HttpContext.Session.SetString("UserName", user.Username.ToString());
            HttpContext.Session.SetString("UserType", user.UserType.Name.ToString());
            // return basic user info (without password) and token to store client side
            
            return Json(new
            {
                user.Id,
                user.Username,
                Token = tokenString,
                message = "Success"
            });
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Register(string Username, string Password, string Name,long UserType)
        {
            // map dto to entity
            var user = new ApplicationUser();
            user.Username = Username;
            user.CreatedOn = DateTime.Now;
            user.UserTypeId = UserType;
            user.FirstName = Name;
            user.CompanyId = 1;
            user.Guid = Guid.NewGuid();
            user.Status = 1;
            try
            {
                var result = _userService.Create(user, Password);
                return Json(new { message = "Success" });
            }
            catch (AppException ex)
            {
                System.IO.File.AppendAllText(@"C:\inetpub\wwwroot\TradeMateSite\Error.txt", ex.Message);
                // return error message if there was an exception
                return BadRequest(new { message = ex.Message });
            }
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult ChangePassword(string NewPassword, string OldPassword)
        {
            long UserId = 0;
            if (HttpContext.Session.GetString("UserId") != null)
            {
                UserId = int.Parse(HttpContext.Session.GetString("UserId"));
            }
            var Username = _userService.GetById(UserId).Username;
            var user = _userService.Authenticate(Username, OldPassword);
            if (user == null)
                return Json(new { message = "Password is incorrect" });
            _userService.Update(user, NewPassword);
            return Json(new { message = "Success" });
        }
        [AllowAnonymous]
        [HttpPost]
        public JsonResult UpdatePassword(long UserId,string NewPassword, string OldPassword)
        {
           
            var Username = _userService.GetById(UserId).Username;
            var user = _userService.Authenticate(Username, OldPassword);
            if (user == null)
                return Json(new { message = "Password is incorrect" });
            _userService.Update(user, NewPassword);
            return Json(new { message = "Success" });
        }



        [HttpGet]
        public ActionResult GetApplicationUser(int type=0)
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _userService.GetAll().Where(X=>X.UserTypeId==type||type==0).ToList();
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
        public ActionResult GetUserType()
        {
            int pageIndex = Convert.ToInt32(1) - 1;
            var Results = _userTypeService.GetAllUserType().ToList();
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
        public ActionResult GetSessions()
        {
            long UserId = 0;
            if (HttpContext.Session.GetString("UserId") != null)
            {
                UserId = int.Parse(HttpContext.Session.GetString("UserId"));
            }
            var result = new
            {
                UserId=UserId,
                UserName=HttpContext.Session.GetString("UserName"),
                UserType=HttpContext.Session.GetString("UserType")
            };
            return Json(result);
        }
        [HttpGet]
        public ActionResult GetUserMapped()
        {
            long UserId = 0;
            if (HttpContext.Session.GetString("UserId") != null)
            {
                UserId = int.Parse(HttpContext.Session.GetString("UserId"));
            }
            var Results = _categoryService.GetAllUserPagesAssigned().Where(x=>x.UserId== UserId && x.IsActive).Select(x=>x.pagename).ToList();            
            return Json(Results);
        }


        
    }
}