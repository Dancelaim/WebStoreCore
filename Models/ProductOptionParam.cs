using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WowCarryCore.Models
{
    public partial class ProductOptionParam
    {
        public ProductOptionParam()
        {
            InverseParameterParent = new HashSet<ProductOptionParam>();
        }

        [Key]
        public Guid ParameterId { get; set; }
        [StringLength(50)]
        public string ParameterName { get; set; }
        [Required]
        [StringLength(255)]
        public string ParameterTooltip { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ParameterPrice { get; set; }
        public Guid? ParentOptionId { get; set; }
        [Required]
        [StringLength(50)]
        public string ParameterSale { get; set; }
        public Guid? ParameterParentId { get; set; }

        [ForeignKey(nameof(ParameterParentId))]
        [InverseProperty(nameof(ProductOptionParam.InverseParameterParent))]
        public virtual ProductOptionParam ParameterParent { get; set; }
        [ForeignKey(nameof(ParentOptionId))]
        [InverseProperty(nameof(ProductOption.ProductOptionParams))]
        public virtual ProductOption ParentOption { get; set; }
        [InverseProperty(nameof(ProductOptionParam.ParameterParent))]
        public virtual ICollection<ProductOptionParam> InverseParameterParent { get; set; }
    }
}
