using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SC.Web.Models
{
   public  class Supplier:AuditDetail
    {
        
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        [ForeignKey("ZipCode")]
        public Int64 ZipCodeId { get; set; }
        public virtual ZipCode ZipCode { get; set; }
        [ForeignKey("City")]
        public Int64 CityId { get; set; }
        public virtual City City { get; set; }
        public virtual State State { get; set; }
        [ForeignKey("State")]
        public Int64 StateId { get;set;}
        public virtual Country Country { get; set; }
        [ForeignKey("Country")]
        public Int64 CountryId { get; set; }
        public string SupportMail { get; set; }
        public string SupportNo { get; set; }
        public string License { get; set; }
        public DateTime StartedIn { get; set; }
        public string TaxNo { get; set; }
        public string Otherreg { get; set; }
        public string Details { get; set; }
        public byte[] ImageAttachment { get; set; }
        public String ContentType { get; set; }
        public String Extension { get; set; }
        public int Status { get; set; }
    }

   public  class SupplierContact : AuditDetail
    {
        [ForeignKey("Supplier")]
        public Int64 SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Mail { get; set; }
        public string Notes { get; set; }
        public int Status { get; set; }
    }
}
