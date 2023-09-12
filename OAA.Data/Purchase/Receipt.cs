using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SC.Data
{
    public class Receipt : AuditDetail
    {
        public string transno { get; set; }
        public string refno { get; set; }
        public DateTime trandate { get; set; }
        [ForeignKey("ledger")]
        public Int64 ledgerId { get; set; }
        public virtual ledger ledger { get; set; }
        public double amount { get; set; }
        public double balance { get; set; }
        public string narration { get; set; }
        public int trantype { get; set; }
    }
    public class Payment : AuditDetail
    {
        public string transno { get; set; }
        public string refno { get; set; }
        public DateTime trandate { get; set; }
        [ForeignKey("ledger")]
        public Int64 ledgerId { get; set; }
        public virtual ledger ledger { get; set; }
        public double amount { get; set; }
        public double balance { get; set; }
        public string narration { get; set; }
        public int trantype { get; set; }
    }

    public class PaymentTransactions : AuditDetail
    {
        [ForeignKey("Payment")]
        public Int64 PaymentId { get; set; }
        public virtual Payment Payment { get; set; }
        public double amount { get; set; }
    }
    public class ReceiptTransactions : AuditDetail
    {
        [ForeignKey("Receipt")]
        public Int64 ReceiptId { get; set; }
        public virtual Receipt Receipt { get; set; }
        public double amount { get; set; }
    }
    public class ScrollText : AuditDetail
    {        
        public string text { get; set; }
        public long type { get; set; }
    }
}
