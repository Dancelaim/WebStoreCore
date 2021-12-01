using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    public partial class DbTempOptionParam
    {
        public DbTempOptionParam()
        {
            InverseDeleteNavigation = new HashSet<DbTempOptionParam>();
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
        [InverseProperty(nameof(DbTempOptionParam.InverseDeleteNavigation))]
        public virtual DbTempOptionParam DeleteNavigation { get; set; }
        [ForeignKey(nameof(ParentOptionId))]
        [InverseProperty(nameof(DbTemplateOption.TempOptionParams))]
        public virtual DbTemplateOption ParentOption { get; set; }
        [InverseProperty(nameof(DbTempOptionParam.DeleteNavigation))]
        public virtual ICollection<DbTempOptionParam> InverseDeleteNavigation { get; set; }
    }
}
