using System;
using System.Collections.Generic;
using System.Text;

namespace SC.Data
{
  public  class Currency : AuditDetail
    {
        public string name { get; set; }   
        public string smallunit { get; set; }
        public double roe { get; set; }
    }

    public class Task : AuditDetail
    {
        public string name { get; set; }
        public string details { get; set; }
    }
}
