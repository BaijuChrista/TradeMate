using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Web.Models
{
  public  class MotherCompany : AuditDetail
    {
        
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public Int64 ZipCodeId { get; set; }
        public virtual ZipCode ZipCode { get; set; }
        public Int64 CityId { get; set; }
        public virtual City City { get; set; }
        public Int64 StateId { get; set; }
        public virtual State State { get; set; }
        public Int64 CountryId { get; set; }
        public virtual Country Country { get; set; }
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
        
    }
}
