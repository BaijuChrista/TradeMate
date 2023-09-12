using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SC.Web.Models
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
       
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public Guid Guid { get; set; }
    }

    public class BasicUserInfo : AuditDetail
    {
        [ForeignKey("ApplicationUsers")]
        public Int64 UserId { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string sex { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Dob { get; set; }
        public virtual ApplicationUser ApplicationUsers { get; set; }
    }

    public class UserContact : AuditDetail
    {
        [ForeignKey("ApplicationUsers")]
        public Int64 UserId { get; set; }
        public string Name { get; set; }
        public string Building { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Notes { get; set; }
        public string MobNo { get; set; }
        public string Email { get; set; }
        public int def { get; set; }

        public virtual ApplicationUser ApplicationUsers { get; set; }
    }

    public class ShippingAddress : AuditDetail
    {
        [ForeignKey("ApplicationUsers")]
        public Int64 UserId { get; set; }
        public string Name { get; set; }
        public string Building { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Notes { get; set; }
        public string MobNo { get; set; }
        public int def { get; set; }
        public virtual ApplicationUser ApplicationUsers { get; set; }
    }
}
