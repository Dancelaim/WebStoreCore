using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    public partial class DbProductOptionParam : Base.BaseEntity
    {
        public DbProductOptionParam(Guid id) : base(id)
        {
            InverseParameterParent = new HashSet<DbProductOptionParam>();
        }
        [StringLength(50)]
        public string Name { get; set; }
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
        [InverseProperty(nameof(DbProductOptionParam.InverseParameterParent))]
        public virtual DbProductOptionParam ParameterParent { get; set; }
        [ForeignKey(nameof(ParentOptionId))]
        [InverseProperty(nameof(DbProductOption.ProductOptionParams))]
        public virtual DbProductOption ParentOption { get; set; }
        [InverseProperty(nameof(DbProductOptionParam.ParameterParent))]
        public virtual ICollection<DbProductOptionParam> InverseParameterParent { get; set; }
    }
}
