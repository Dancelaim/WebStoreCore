using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    [Table("OrderProduct")]
    public partial class DbOrderProduct : Base.BaseEntity
    {
       public DbOrderProduct(Guid id) : base(id) { }
        public Guid? OrderId { get; set; }
        public Guid? ProductId { get; set; }
        public string ProductOptions { get; set; }
        [Column(TypeName = "decimal(19, 1)")]
        public decimal? ProductCheckoutPrice { get; set; }
        [Column(TypeName = "decimal(19, 1)")]
        public decimal? TotalOptionsCheckoutPrice { get; set; }

        [ForeignKey(nameof(OrderId))]
        [InverseProperty("OrderProducts")]
        public virtual DbOrder Order { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty("OrderProducts")]
        public virtual DbProduct Product { get; set; }
    }
}
