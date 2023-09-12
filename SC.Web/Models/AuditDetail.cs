﻿using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SC.Web.Models 
{

    public class AuditDetail
    {
        [Key]
        public Int64 Id { get; set; }
        [ForeignKey("ApplicationUser")]
        public Int64 CreatedUserId { get; set; }
        public Int64 ModifiedUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string IpAddress { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public int Status { get; set; }
        public AuditDetail()
        {
           
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;            
            Status = 1;            
        }
    }

}
