using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SC.Data
{
   public class Employee : AuditDetail 
    {

        public string code { get; set; }
        public string salutation { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string mail { get; set; }
        public string phone { get; set; }
        [ForeignKey("EmployeeCategory")]
        public Int64 EmployeeCategoryId { get; set; }
        public virtual EmployeeCategory EmployeeCategory { get; set; }
        [ForeignKey("EmployeeGroup")]
        public Int64 EmployeeGroupId { get; set; }
        public virtual EmployeeGroup EmployeeGroup { get; set; }
        [ForeignKey("Department")]
        public Int64 DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        [ForeignKey("Designation")]
        public Int64 DesignationId { get; set; }
        public virtual Designation Designation { get; set; }
        public DateTime?dob { get; set; }
        public DateTime? doj { get; set; }
        [ForeignKey("partner")]
        public Int64 partnerId { get; set; }
        public virtual partner partner { get; set; }        
        public double dr { get; set; }        
        public double cr { get; set; }
    }
    public class EmployeeCategory : AuditDetail
    {
        [ForeignKey("coa")]
        public Int64 coaId { get; set; }
        public virtual coa coa { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }
    public class EmployeeGroup : AuditDetail
    {       
        public string code { get; set; }
        public string name { get; set; }
    }
}
