using System;
using System.Collections.Generic;

namespace SC.Web.Models
{
    public class Country:AuditDetail
    {        
        public string CountryName { get; set; }
        public int Status { get; set; }       
    }
}
