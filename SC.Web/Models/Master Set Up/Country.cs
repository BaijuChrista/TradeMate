using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SC.Web.Models
{
    public class Country:AuditDetail
    {
        [Required(ErrorMessage = "Please Enter The Name")]
        public string CountryName { get; set; }
           
    }
}
