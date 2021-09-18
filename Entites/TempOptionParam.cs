using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WowCarryCore.Models
{
    public partial class TempOptionParam
    {
        public TempOptionParam()
        {
            InverseDeleteNavigation = new HashSet<TempOptionParam>();
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
        public Guid? Delete { get; set; }

        [ForeignKey(nameof(Delete))]
        [InverseProperty(nameof(TempOptionParam.InverseDeleteNavigation))]
        public virtual TempOptionParam DeleteNavigation { get; set; }
        [ForeignKey(nameof(ParentOptionId))]
        [InverseProperty(nameof(TemplateOption.TempOptionParams))]
        public virtual TemplateOption ParentOption { get; set; }
        [InverseProperty(nameof(TempOptionParam.DeleteNavigation))]
        public virtual ICollection<TempOptionParam> InverseDeleteNavigation { get; set; }
    }
}
