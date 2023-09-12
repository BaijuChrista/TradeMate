using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SC.Data
{
   public class Designation : AuditDetail 
    {
        public string code { get; set; }
        public string name { get; set; }
        [ForeignKey("DesignationGroup")]
        public Int64 DesignationGroupsId { get; set; }
        public virtual DesignationGroup DesignationGroup { get; set; }
    }
    public class DesignationGroup : AuditDetail
    {       
        public string code { get; set; }
        public string name { get; set; }
    }
}
