using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SC.Data
{
    public class ApplicationUser
    {
       
        public Int64 Id { get; set; }
        public string Username { get; set; }
        public DateTime CreatedOn { get; set; }
        public int Status { get; set; }
        public byte[] ImageAttachment { get; set; }
        public String ContentType { get; set; }
        public String Extension { get; set; }
        [ForeignKey("UserType")]
        public Int64 UserTypeId { get; set; }
        public virtual UserType UserType { get; set; }
        [ForeignKey("Company")]
        public Int64? CompanyId { get; set; }
        public virtual Company Company { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public Guid Guid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string sex { get; set; }
        public string PhoneNumber { get; set; }
    }
    public class UserPagesAssigned : AuditDetail
    {
        public string pagename { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("User")]
        public Int64 UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
