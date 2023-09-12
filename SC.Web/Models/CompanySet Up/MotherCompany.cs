using Microsoft.AspNetCore.Http;
using SC.Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SC.Web
{
  public  class MotherCompany : AuditDetail
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
        public string image { get; set; }
        [NotMapped]
        public IFormFile MyImage { set; get; }
    }
}
