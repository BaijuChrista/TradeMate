using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SC.Data
{
   public class Branch  :AuditDetail 
    {
        public string code { get; set; }
        public string name { get; set; }
        [ForeignKey("BranchGroup")]
        public Int64 BranchGroupId { get; set; }
        public virtual BranchGroup BranchGroup { get; set; }
    }
    public class BranchGroup : AuditDetail
    {
        public string code { get; set; }
        public string name { get; set; }
    }
}
