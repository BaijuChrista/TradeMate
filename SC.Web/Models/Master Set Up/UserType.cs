using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SC.Web.Models
{
   public  class UserType
    {
        public Int64 Id { get; set; }
        [Required(ErrorMessage = "Please Enter The Name")]
        public string Name { get; set; }
        public int Status { get; set; }       
    }
}
