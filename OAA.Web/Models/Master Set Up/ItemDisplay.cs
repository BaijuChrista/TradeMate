using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SC.Web.Models
{
   public class ItemDisplay : AuditDetail
    {
        
        public string ItemName { get; set; }
        [ForeignKey("ItemGroup")]
        public Int64 ItemGroupId { get; set; }
        public virtual ItemGroup ItemGroup { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        [ForeignKey("Brand")]
        public Int64 BrandId { get; set; }
        public virtual Brand Brand { get; set; }
        [ForeignKey("Model")]
        public Int64 ModelId { get; set; }
        public virtual Model Model { get; set; }
        public string DisplayText { get; set; }
        public string ItemDetails { get; set; }
        public string techspec { get; set; }
        public string rating { get; set; }
        public int Status { get; set; }
        public double qty { get; set; }
    }

    public class StockMaster : AuditDetail
    {
        [ForeignKey("ItemDisplay")]
        public Int64 ItemDisplayId { get; set; }
        public virtual ItemDisplay ItemDisplay { get; set; }
        public double stock { get; set; }
        public int Status { get; set; }
    }
   
}
