using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    public partial class DbProductOption : Base.BaseEntity
    {
        public DbProductOption()
        {
            InverseOptionParent = new HashSet<DbProductOption>();
            ProductOptionParams = new HashSet<DbProductOptionParam>();
        }
        [StringLength(55)]
        public string OptionName { get; set; }
        public int? OptionType { get; set; }
        public Guid? OptionParentId { get; set; }
        public Guid? OptionProductId { get; set; }

        [ForeignKey(nameof(OptionParentId))]
        [InverseProperty(nameof(DbProductOption.InverseOptionParent))]
        public virtual DbProductOption OptionParent { get; set; }
        [ForeignKey(nameof(OptionProductId))]
        [InverseProperty(nameof(DbProduct.ProductOptions))]
        public virtual DbProduct OptionProduct { get; set; }
        [InverseProperty(nameof(DbProductOption.OptionParent))]
        public virtual ICollection<DbProductOption> InverseOptionParent { get; set; }
        [InverseProperty(nameof(DbProductOptionParam.ParentOption))]
        public virtual ICollection<DbProductOptionParam> ProductOptionParams { get; set; }
    }
}
