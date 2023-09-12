using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Web.Models
{
   public class Category :AuditDetail
    {       
        public string CategoryName { get; set; }
        public int Status { get; set; }
    }
}
