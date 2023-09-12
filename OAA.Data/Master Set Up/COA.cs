using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SC.Data
{
   public class COAType : AuditDetail 
    {
        [ForeignKey("Coabase")]
        public Int64 CoabaseId { get; set; }
        public virtual Coabase Coabase { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public int odr { get; set; }
    }

    public class Coabase : AuditDetail
    {
        public string code { get; set; }
        public string name { get; set; }
        public int fs { get; set; }
    }
    public class coa : AuditDetail
    {
        [ForeignKey("COAType")]
        public Int64 COATypeId { get; set; }
        public virtual COAType COAType { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public int odr { get; set; }
    }

    public class ledger : AuditDetail
    {
        [ForeignKey("coa")]
        public Int64 coaId { get; set; }
        public virtual coa coa { get; set; }
        [ForeignKey("partner")]
        public Int64 partnerId { get; set; }
        public virtual partner partner { get; set; }
        public string name { get; set; }
        public string details { get; set; }
        [NotMapped]
        public double dr { get; set; }
        [NotMapped]
        public double cr { get; set; }
    }

    public class ledgertxn : AuditDetail
    {
        [ForeignKey("ledger")]
        public Int64 ledgerId { get; set; }
        public virtual ledger ledger { get; set; }
        public string txnno { get; set; }
        public DateTime txndate { get; set; }
        public double dr { get; set; }
        public double cr { get; set; }
        public string details { get; set; }
    }
    public class defaultaccount : AuditDetail
    {
        public string name { get; set; }
        [ForeignKey("ledger")]
        public Int64 ledgerId { get; set; }
        public virtual ledger ledger { get; set; }
    }

}
