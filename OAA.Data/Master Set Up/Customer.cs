using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SC.Data
{
    public class Customer : AuditDetail
    {
        public string code { get; set; }
        public string CustomerName { get; set; }
        public string shortname { get; set; }
        public string CustomerAddress { get; set; }
        public string Zipcode { get; set; }
        [ForeignKey("City")]
        public Int64 CityId { get; set; }
        public virtual City City { get; set; }
        [ForeignKey("Currency")]
        public Int64 CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }
        [ForeignKey("customercategory")]
        public Int64 customercategoryId { get; set; }
        public virtual customercategory customercategory { get; set; }
        [ForeignKey("customergroup")]
        public Int64 customergroupId { get; set; }
        public virtual customergroup customergroup { get; set; }
        public string SupportMail { get; set; }
        public string SupportNo { get; set; }
        public string License { get; set; }
        public DateTime StartedIn { get; set; }
        public string TaxNo { get; set; }
        public string Otherreg { get; set; }
        public string Details { get; set; }
        public String image { get; set; }
        public string Lattitude { get; set; }
        public string Longitude { get; set; }
        public double creditlimit { get; set; }
        public int creditdays { get; set; }
        [ForeignKey("partner")]
        public Int64 partnerId { get; set; }
        public virtual partner partner { get; set; }        
        public double dr { get; set; }        
        public double cr { get; set; }
    }

    public class CustomerContact : AuditDetail
    {
        [ForeignKey("Customer")]
        public Int64 CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Mail { get; set; }
        public string Notes { get; set; }
    }
    public class CustomerUserAssign : AuditDetail
    {
        [ForeignKey("Customer")]
        public Int64 CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        [ForeignKey("AssignedUser")]
        public Int64 AssignedUserId { get; set; }
        public virtual ApplicationUser AssignedUser { get; set; }
        public int assignedDay { get; set; }
    }
    public class customercategory: AuditDetail
    {
        [ForeignKey("coa")]
        public Int64 coaId { get; set; }
        public virtual coa coa { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }
    public class customergroup : AuditDetail
    {
        public string code { get; set; }
        public string name { get; set; }
    }
    public class GetCustomerInfo_Trademate
    {
        
        public Int64 Id { get; set; }
        public string code { get; set; }
        public string Name { get; set; }
        public string address { get; set; }
        public double creditlimit { get; set; }
        public int creditdays { get; set; }
        public string assignedDay { get; set; }
        public string assignedTo { get; set; }        
        public double Balance { get; set; }
        public string status { get; set; }
        public string number { get; set; }
    }
}
