using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SC.Data
{
   public class SalesOrder : AuditDetail 
    {
        public string refno { get; set; }
        public int Type { get; set; }
        public DateTime orderdate { get; set; }
        [ForeignKey("Customer")]
        public Int64 CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }
        public string details { get; set; }
        public string statusChange { get; set; }
        public string ContactName { get; set; }
        public string Delivery { get; set; }
        public string ContactNumber { get; set; }
        public string lpono { get; set; }
        
    }
    public class SalesOrderDetail : AuditDetail
    {
        [ForeignKey("SalesOrder")]
        public Int64 SalesOrderId { get; set; }
        public virtual SalesOrder SalesOrder { get; set; }
        [ForeignKey("ItemMaster")]
        public Int64 ItemMasterId { get; set; }
        public virtual ItemMaster ItemMaster { get; set; }
        public double qty { get; set; }
        public double amount { get; set; }
        public string comments { get; set; }      
    }
    public class Sales : AuditDetail
    {     
        public string invoiceno { get; set; }
        public string lpono { get; set; }        
        public int Type { get; set; }
        public DateTime salesdate { get; set; }
        [ForeignKey("Customer")]
        public Int64 CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        [ForeignKey("SalesOrder")]
        public Int64? SalesOrderId { get; set; }
        public virtual SalesOrder SalesOrder { get; set; }
        public string details { get; set; }
        public string statusChange { get; set; }
        public double Total { get; set; }
        public double Discount { get; set; }
        public bool Isvat { get; set; }
        public double balance { get; set; }
    }
    public class SalesDetail : AuditDetail
    {
        [ForeignKey("Sales")]
        public Int64 SalesId { get; set; }
        public virtual Sales Sales { get; set; }
        [ForeignKey("ItemMaster")]
        public Int64 ItemMasterId { get; set; }
        public virtual ItemMaster ItemMaster { get; set; }
        public double qty { get; set; }
        public double amount { get; set; }
        public double cost { get; set; }
        public string comments { get; set; }
    }
    public class Salespaiddetail : AuditDetail
    {
        [ForeignKey("Sales")]
        public Int64 SalesId { get; set; }
        public virtual Sales Sales { get; set; }
        public double amount { get; set; }
        public string details { get; set; }
        public string voucherno { get; set; }
        public DateTime paiddate { get; set; }
    }

    public class salereturn : AuditDetail
    {
        public string invoiceno { get; set; }
        public DateTime retdate { get; set; }
        [ForeignKey("Sales")]
        public Int64 SalesId { get; set; }
        public virtual Sales Sales { get; set; }
        public string details { get; set; }
        public double Total { get; set; }
    }
    public class salereturnDetail : AuditDetail
    {
        [ForeignKey("salereturn")]
        public Int64 salereturnId { get; set; }
        public virtual salereturn salereturn { get; set; }
        [ForeignKey("ItemMaster")]
        public Int64 ItemMasterId { get; set; }
        public virtual ItemMaster ItemMaster { get; set; }
        public double qty { get; set; }
        public double amount { get; set; }        
    }

    public class DeliveryPayment : AuditDetail
    {
        [ForeignKey("salereturn")]
        public Int64 deliveryItemId { get; set; }
        public virtual DeliveryItem DeliveryItem { get; set; }
        public double amount { get; set; }
        public int type { get;set; }
    }


    public class DeliveryItem : AuditDetail
    {
        public string OrderNo { get; set; }
        public string details { get; set; }
       
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public double Amount { get; set; }
        [ForeignKey("UserAssigned")]
        public Int64? userAssignedId { get; set; }
        public virtual ApplicationUser UserAssigned { get; set; }
        public string PickUp_contact { get; set; }
        public string PickUp_email { get; set; }
        public string DropOf_contact { get; set; }
        public string DropOf_email { get; set; }
        [ForeignKey("Deliverycategory")]
        public Int64? subcategoryId { get; set; }
        public virtual Deliverycategory Deliverycategory { get; set; }
    }

    public class Deliverycategory:AuditDetail
    {
        public string Name { get; set; }
        public Int64? DeliveryId { get; set; }

        [ForeignKey("DeliveryId")]
        public Deliverycategory Maincategory { get; set; }
    }

}
