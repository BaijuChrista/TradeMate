using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SC.Data
{
    public class Expense : AuditDetail 
    {
        public string code { get; set; }
        public string name { get; set; }
        [ForeignKey("ExpenseCategory")]
        public Int64 CategoryId { get; set; }
        public virtual ExpenseCategory ExpenseCategory { get; set; }
    }
    public class ExpenseCategory : AuditDetail
    {
        public string code { get; set; }
        public string name { get; set; }
        [ForeignKey("coa")]
        public Int64 coaId { get; set; }
        public virtual coa coa { get; set; }
    }
    public class ExpensePayment : AuditDetail
    {
        public string transno { get; set; }
        public string refno { get; set; }
        public DateTime trandate { get; set; }
        [ForeignKey("ledger")]
        public Int64 ledgerId { get; set; }
        public virtual ledger ledger { get; set; }
        public double amount { get; set; }
        public string narration { get; set; }
        public int trantype { get; set; }
    }

}
