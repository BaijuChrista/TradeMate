using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SC.Data
{
    public class service : AuditDetail
    {
        public string code { get; set; }
        public string name { get; set; }
        [ForeignKey("servicetype")]
        public Int64 servicetypeId { get; set; }
        public virtual servicetype servicetype { get; set; }
    }

    public class servicetype : AuditDetail
    {
        [ForeignKey("coa")]
        public Int64 coaId { get; set; }
        public virtual coa coa { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }
}
