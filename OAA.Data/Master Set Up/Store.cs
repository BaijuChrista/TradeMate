using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SC.Data
{
    public class Store : AuditDetail 
    {
        public string code { get; set; }
        public string StoreName { get; set; }
        public string shortname { get; set; }
        public string StoreAddress { get; set; }
        public string Zipcode { get; set; }
        [ForeignKey("City")]
        public Int64 CityId { get; set; }
        public virtual City City { get; set; }        
        public string Details { get; set; }
        [ForeignKey("Company")]
        public Int64 CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public string Lattitude { get; set; }
        public string Longitude { get; set; }
    }
}
