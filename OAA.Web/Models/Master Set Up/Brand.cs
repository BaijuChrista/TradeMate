using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SC.Web.Models
{
   public  class Brand : AuditDetail
    {
        [ForeignKey("ItemGroup")]
        public Int64 ItemGroupId { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public virtual ItemGroup ItemGroup { get; set; }
    }
}
