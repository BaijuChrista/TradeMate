using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SC.Data
{
  public  class FinanceYear :AuditDetail
    {
        
        public string YearName { get; set; }        
        public DateTime FromDate { get; set; }        
        public DateTime ToDate { get; set; }
        public bool iscurrent { get; set; }
    }
}
