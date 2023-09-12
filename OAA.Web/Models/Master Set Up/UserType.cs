using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Web.Models
{
   public  class UserType
    {
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
