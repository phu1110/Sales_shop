using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models.Abstract
{
    public interface IAudiTable
    {
        DateTime CreatedDate { get; set; }
        string CreateBy { get; set; }

        DateTime UpdateDate { get; set; }

        string UpdateBy { get; set; }
        string MetaKeyWord { get; set; }
        string MetaDescription { get; set; }
        bool Status { get; set; }
    }
}
