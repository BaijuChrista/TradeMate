using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SC.Web.Models
{
    public class SubCategory : AuditDetail
    {
        [ForeignKey("Category")]
        public Int64 CategoryId { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public virtual Category Category { get; set; }
    }
}
