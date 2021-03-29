using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WowCarryCore.Models
{
    [Table("ProductDescription")]
    public partial class ProductDescription
    {
        public ProductDescription()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public Guid ProductDescriptionId { get; set; }
        public string Description { get; set; }
        public string SubDescriptionTitle1 { get; set; }
        public string SubDescriptionTitle2 { get; set; }
        public string SubDescriptionTitle3 { get; set; }
        public string SubDescriptionTitle4 { get; set; }
        public string SubDescriptionTitle5 { get; set; }
        public string SubDescription1 { get; set; }
        public string SubDescription2 { get; set; }
        public string SubDescription3 { get; set; }
        public string SubDescription4 { get; set; }
        public string SubDescription5 { get; set; }

        [InverseProperty(nameof(Product.ProductDescription))]
        public virtual ICollection<Product> Products { get; set; }
    }
}
