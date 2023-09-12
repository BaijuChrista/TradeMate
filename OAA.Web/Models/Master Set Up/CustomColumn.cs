using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Web.Models
{
  public   class CustomColumn : AuditDetail
    {
        
        public string Colname { get; set; }
        public int Status { get; set; } 
    }
}
