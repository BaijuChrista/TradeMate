using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SC.Web.Models
{
  public  class ZipCode:AuditDetail
    {
        [ForeignKey("City")]
        public Int64 CityId { get; set; }
        public string Code { get; set; }
        public string ZipName { get; set; }
        public int Status { get; set; }
        public virtual City City { get; set; }
        
    }
}
