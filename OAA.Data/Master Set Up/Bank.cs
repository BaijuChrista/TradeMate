using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SC.Data
{
    public class Bank : AuditDetail
    {        
        public string code { get; set; }
        public string accno {get;set;}
        public string bankname { get; set; }
        public string swiftcode { get; set; }
        [ForeignKey("Currency")]
        public Int64 CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }
        [ForeignKey("Bankcategory")]
        public Int64 BankcategoryId { get; set; }
        public virtual Bankcategory Bankcategory { get; set; }
        public double dr { get; set; }
        public double cr { get; set; }
        [ForeignKey("partner")]
        public Int64 partnerId { get; set; }
        public virtual partner partner { get; set; }
    }
    public class Bankcategory : AuditDetail
    {
        [ForeignKey("coa")]
        public Int64 coaId { get; set; }
        public virtual coa coa { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }
    public class BankTxn : AuditDetail
    {

        public string transno { get; set; }
        public string refno { get; set; }
        public DateTime trandate { get; set; }
        [ForeignKey("Bank")]
        public Int64 BankId { get; set; }
        public virtual Bank Bank { get; set; }
        public double amount { get; set; }
        public string narration { get; set; }
        public int trantype { get; set; }

    }

}
