using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Data
{
   public class TaxMaster : AuditDetail
    {
        public string TaxName { get; set; }
        public double percentage { get; set; }  
        public string notes { get; set; }
    }
}
