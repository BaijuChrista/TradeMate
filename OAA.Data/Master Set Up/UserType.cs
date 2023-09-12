using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SC.Data
{
   public  class UserType
    {   [Key]
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }       
    }
}
