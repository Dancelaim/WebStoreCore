using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    public partial class DbTemplateOption : Base.BaseEntity
    {
        public DbTemplateOption(Guid id) : base(id)
        {
            TempOptionParams = new HashSet<DbTempOptionParam>();
        }

        [StringLength(55)]
        public string OptionName { get; set; }
        [StringLength(10)]
        public string OptionType { get; set; }
        public Guid? OptionParentId { get; set; }

        [InverseProperty(nameof(DbTempOptionParam.ParentOption))]
        public virtual ICollection<DbTempOptionParam> TempOptionParams { get; set; }
    }
}
