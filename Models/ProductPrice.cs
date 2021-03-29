using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WowCarryCore.Models
{
    [Table("ProductPrice")]
    public partial class ProductPrice
    {
        [Key]
        public Guid ProductPriceId { get; set; }
        [StringLength(10)]
        public string Region { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Price { get; set; }
        public Guid ProductId { get; set; }
        [Column(TypeName = "decimal(18, 1)")]
        public decimal? ProductSale { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("ProductPrices")]
        public virtual Product Product { get; set; }
    }
}
