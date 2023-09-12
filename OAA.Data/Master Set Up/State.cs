using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SC.Data
{
    public class State:AuditDetail
    {
        [ForeignKey("Country")]
        public Int64 CountryId { get; set; }
        public string Name { get; set; }        
        public virtual Country Country { get; set; }
          
    }
}
