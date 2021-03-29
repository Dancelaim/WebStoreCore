using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WowCarryCore.Models
{
    public partial class ProductOption
    {
        [Key]
        public Guid OptionId { get; set; }
        [StringLength(55)]
        public string OptionName { get; set; }
        [StringLength(10)]
        public string OptionType { get; set; }
        public Guid? OptionParentId { get; set; }
        public Guid? OptionProductId { get; set; }

        [ForeignKey(nameof(OptionProductId))]
        [InverseProperty(nameof(Product.ProductOptions))]
        public virtual Product OptionProduct { get; set; }
    }
}
