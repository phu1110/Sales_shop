using Project.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Project.Models.Domain
{
    [Table("Products")]
    public class Products : AuditTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Alias { get; set; }

        public int CategoryID { get; set; } 
        
        public string Imagews { get; set; }
        
        public XElement MoreImages { get; set; }

        public decimal Price { get; set; }

        public decimal PromotionPrice { get; set;}

        public int? Warranty { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public bool? HomeFlag { get; set; }
        public bool? HotFlag { get; set; }
        
        public int? ViewCount { get; set; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategories ProductCategories { get; set; }
        [ForeignKey("ID")]
        public virtual OrderDetails OrderDetails { get; set; }

    }
}