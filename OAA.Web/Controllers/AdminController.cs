using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SC.Service;
using SC.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using SC.Data;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SC.Web.Controllers
{
   
    public class AdminController : Controller
    { 
    public ActionResult NewCountry()
        {
            //return View(@"~Views\Admin\Country\NewCountry.cshtml");
            return View("../Home/About");
        }        
    }
    
}
