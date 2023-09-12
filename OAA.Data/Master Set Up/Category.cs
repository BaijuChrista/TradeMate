using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SC.Data
{
   public class ItemCategory :AuditDetail
    {
        public string code { get; set; }
        public string CategoryName { get; set; } 
        public string notes { get; set; }
        public string image { get; set; }
        [NotMapped]
        public IFormFile iformFile { get; set; }
    }
}
