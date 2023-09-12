using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SC.Data
{
    public class Purchase : AuditDetail
    {
        public string refno { get; set; }
        public string invoiceno { get; set; }
        public int Type { get; set; }
        public DateTime orderdate { get; set; }
        [ForeignKey("Supplier")]
        public Int64 SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public string details { get; set; }
        public double Total { get; set; }
        public double Discount { get; set; }        
        public double balance { get; set; }
        public bool Isvat { get; set; }

    }
    public class PurchaseDetail : AuditDetail
    {
        [ForeignKey("Purchase")]
        public Int64 PurchaseOrderId { get; set; }
        public virtual Purchase Purchase { get; set; }
        [ForeignKey("ItemMaster")]
        public Int64 ItemMasterId { get; set; }
        public virtual ItemMaster ItemMaster { get; set; }
        public double qty { get; set; }
        public double amount { get; set; }
        public string comments { get; set; }
    }

    public class purchasepaiddetail : AuditDetail
    {
        [ForeignKey("Purchase")]
        public Int64 PurchaseOrderId { get; set; }
        public virtual Purchase Purchase { get; set; }
        public double amount { get; set; }
        public string details { get; set; }
        public string voucherno { get; set; }
        public DateTime paiddate { get; set; }
        
    }
    public class purchasereturn : AuditDetail
    {
        public string invoiceno { get; set; }
        public DateTime retdate { get; set; }
        [ForeignKey("Purchase")]
        public Int64 PurchaseId { get; set; }
        public virtual Purchase Purchase { get; set; }
        public string details { get; set; }
        public double Total { get; set; }
    }
    public class purchasereturnDetail : AuditDetail
    {
        [ForeignKey("purchasereturn")]
        public Int64 purchasereturnId { get; set; }
        public virtual purchasereturn purchasereturn { get; set; }
        [ForeignKey("ItemMaster")]
        public Int64 ItemMasterId { get; set; }
        public virtual ItemMaster ItemMaster { get; set; }
        public double qty { get; set; }
        public double amount { get; set; }
    }
}
