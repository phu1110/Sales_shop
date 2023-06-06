using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.Models.Abstract
{
    public class AuditTable : IAudiTable
    {

        public DateTime CreatedDate { get; set; }
        [MaxLength(256)]
        public string CreateBy { get; set; }

        public DateTime UpdateDate { get; set; }
        [MaxLength]
        public string UpdateBy { get; set; }

        [MaxLength(256)]
        public string MetaKeyWord { get; set; }
        [MaxLength]
        public string MetaDescription { get; set; }
        public bool Status { get; set; }
    }
}