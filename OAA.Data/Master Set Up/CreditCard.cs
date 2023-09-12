using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SC.Data
{
    public class CreditCard : AuditDetail 
    {       
        public string code { get; set; }
        public string number { get; set; }
        public string details { get; set; }
        [ForeignKey("Bank")]
        public Int64 BankId { get; set; }
        public virtual Bank Bank { get; set; }
        [ForeignKey("CreditCardcategory")]
        public Int64 categoryId { get; set; }
        public virtual CreditCardcategory CreditCardcategory { get; set; }
        public double dr { get; set; }
        public double cr { get; set; }
        [ForeignKey("partner")]
        public Int64 partnerId { get; set; }
        public virtual partner partner { get; set; }
    }
    public class CreditCardcategory : AuditDetail
    {
        [ForeignKey("coa")]
        public Int64 coaId { get; set; }
        public virtual coa coa { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }
}
