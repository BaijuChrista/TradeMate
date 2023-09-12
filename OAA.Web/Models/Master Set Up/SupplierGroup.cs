using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Web.Models
{
   public  class SupplierGroup : AuditDetail
    {       
        public string GroupName { get; set; }
        public string Details { get; set; }
        public int Status { get; set; }
    }
}
