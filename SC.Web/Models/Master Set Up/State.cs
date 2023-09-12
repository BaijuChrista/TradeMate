using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SC.Web.Models
{
    public class State:AuditDetail
    {
        [Required(ErrorMessage = "Please Select The Country")]
        [ForeignKey("Country")]
        public Int64 CountryId { get; set; }
        [Required(ErrorMessage = "Please Enter The Name")]
        public string Name { get; set; }        
        public virtual Country Country { get; set; }            
    }
}
