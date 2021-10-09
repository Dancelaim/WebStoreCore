using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    public partial class ProductOption
    {
        public ProductOption()
        {
            InverseOptionParent = new HashSet<ProductOption>();
            ProductOptionParams = new HashSet<ProductOptionParam>();
        }

        [Key]
        public Guid OptionId { get; set; }
        [StringLength(55)]
        public string OptionName { get; set; }
        public int? OptionType { get; set; }
        public Guid? OptionParentId { get; set; }
        public Guid? OptionProductId { get; set; }

        [ForeignKey(nameof(OptionParentId))]
        [InverseProperty(nameof(ProductOption.InverseOptionParent))]
        public virtual ProductOption OptionParent { get; set; }
        [ForeignKey(nameof(OptionProductId))]
        [InverseProperty(nameof(Product.ProductOptions))]
        public virtual Product OptionProduct { get; set; }
        [InverseProperty(nameof(ProductOption.OptionParent))]
        public virtual ICollection<ProductOption> InverseOptionParent { get; set; }
        [InverseProperty(nameof(ProductOptionParam.ParentOption))]
        public virtual ICollection<ProductOptionParam> ProductOptionParams { get; set; }
    }
}
