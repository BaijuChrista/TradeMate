using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SC.Data
{
   public class Supplier : AuditDetail 
    {
        public string code { get; set; }
        public string SupplierName { get; set; }
        public string shortname { get; set; }
        public string SupplierAddress { get; set; }
        public string Zipcode { get; set; }
        [ForeignKey("City")]
        public Int64 CityId { get; set; }
        public virtual City City { get; set; }
        [ForeignKey("suppliercategory")]
        public Int64 categoryId { get; set; }
        public virtual suppliercategory suppliercategory { get; set; }
        [ForeignKey("suppliergroup")]
        public Int64 suppliergroupId { get; set; }
        public virtual suppliergroup suppliergroup { get; set; }
        [ForeignKey("Currency")]
        public Int64 CurrencyId { get; set; }
        public virtual Currency Currency { get; set; }
        public string SupportMail { get; set; }
        public string SupportNo { get; set; }
        public string License { get; set; }
        public DateTime? StartedIn { get; set; }
        public string TaxNo { get; set; }
        public string Otherreg { get; set; }
        public double creditlimit { get; set; }
        public string Details { get; set; }
        public String image { get; set; }
        public string Lattitude { get; set; }
        public string Longitude { get; set; }
        public int creditdays { get; set; }
        [ForeignKey("partner")]
        public Int64 partnerId { get; set; }
        public virtual partner partner { get; set; }      
        public double dr { get; set; }        
        public double cr { get; set; }
    }
    public class suppliercategory : AuditDetail
    {
        [ForeignKey("coa")]
        public Int64 coaId { get; set; }
        public virtual coa coa { get; set; }
        public string code { get; set; }
        public string name { get; set; }

    }
    public class suppliergroup : AuditDetail
    {
        public string code { get; set; }
        public string name { get; set; }
    }
    public class SupplierContact : AuditDetail
    {
        [ForeignKey("Supplier")]
        public Int64 SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Mail { get; set; }
        public string Notes { get; set; }
    }
}
