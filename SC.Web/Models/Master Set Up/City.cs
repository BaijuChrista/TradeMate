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
        [Required(ErrorMessage = "Please Enter The City")]
        public Int64 StateId { get; set; }
        [Required(ErrorMessage = "Please Enter The Name")]
        public string Name { get; set; }       
        public virtual State State { get; set; }


    }
}
