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
        public Guid ProductId { get; set; }
        [Column(TypeName = "decimal(18, 1)")]
        public decimal? UsPrice { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? UsSale { get; set; }
        [Column(TypeName = "decimal(18, 1)")]
        public decimal? EuPrice { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? EuSale { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("ProductPrices")]
        public virtual Product Product { get; set; }
    }
}
