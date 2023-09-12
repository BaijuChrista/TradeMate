using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SC.Data
{
   public class Asset : AuditDetail 
    {
        public string code { get; set; }
        public string name { get; set; }
        [ForeignKey("AssetCategory")]
        public Int64 AssetCategoryId { get; set; }
        public virtual AssetCategory AssetCategory { get; set; }
    }
    public class AssetCategory : AuditDetail
    {
        public string code { get; set; }
        public string name { get; set; }
        [ForeignKey("coa")]
        public Int64 coaId { get; set; }
        public virtual coa coa { get; set; }
    }
}
