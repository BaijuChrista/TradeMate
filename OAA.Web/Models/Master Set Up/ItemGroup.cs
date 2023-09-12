using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SC.Web.Models
{
  public class ItemGroup : AuditDetail
    {
       [ForeignKey("SubCategory")]
        public Int64 SubCategoryId { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public virtual SubCategory SubCategory { get; set; }
    }
}
