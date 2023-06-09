﻿using Project.Models.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Project.Models.Domain
{
    [Table("ProductCategories")]
    public class ProductCategories : AuditTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Alias { get; set; }

        public string Description { get; set; }

        public int ParentID { get; set; }
        public int DisplayOrder { get; set; } 
        public string Image { get; set; }   

        public bool HomeFlag { get; set; }

        public virtual IEnumerable<Products> Products { get; set; }
    

    }
}