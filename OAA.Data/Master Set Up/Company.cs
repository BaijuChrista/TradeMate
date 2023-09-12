using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SC.Data
{
   public  class Company:AuditDetail
    {
        
        public string CompanyName { get; set; }
        public string shortname { get; set; }
        public string CompanyAddress { get; set; }
        public string Zipcode { get; set; }
        [ForeignKey("City")]
        public Int64 CityId { get; set; }
        public virtual City City { get; set; }       
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
    }

   public  class CompanyContact : AuditDetail
    {
        [ForeignKey("Company")]
        public Int64 CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Mail { get; set; }
        public string Notes { get; set; }        
    }

    public class partner : AuditDetail
    {
        public string code { get; set; }
        public string name { get; set; }
        public string details { get; set; }
    }
}
