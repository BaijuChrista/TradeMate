using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SC.Data
{
    public class Department : AuditDetail
    {
        public string code { get; set; }
        public string name { get; set; }
        [ForeignKey("DepartmentGroup")]
        public Int64 DepartmentGroupId { get; set; }
        public virtual DepartmentGroup DepartmentGroup { get; set; }
    }
    public class DepartmentGroup : AuditDetail
    {
        
        public string code { get; set; }
        public string name { get; set; }
    }
}
