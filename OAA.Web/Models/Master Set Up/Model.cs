using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SC.Web.Models
{
    public class Model : AuditDetail
    {
        [ForeignKey("Brand")]
        public Int64 BrandId {get;set;}
        public string Name { get; set; }
        public int Status { get; set; }
        public virtual Brand Brand { get; set; }
    }
}
