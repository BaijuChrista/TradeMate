using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SC.Web.Models
{
   public class City :AuditDetail
    {
        [ForeignKey("State")]
       
        public Int64 StateId { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public virtual State State { get; set; }


    }
}
