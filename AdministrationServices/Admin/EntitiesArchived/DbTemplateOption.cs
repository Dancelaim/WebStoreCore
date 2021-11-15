using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    public partial class DbTemplateOption
    {
        public DbTemplateOption()
        {
            TempOptionParams = new HashSet<DbTempOptionParam>();
        }

        [Key]
        public Guid OptionId { get; set; }
        [StringLength(55)]
        public string OptionName { get; set; }
        [StringLength(10)]
        public string OptionType { get; set; }
        public Guid? OptionParentId { get; set; }

        [InverseProperty(nameof(DbTempOptionParam.ParentOption))]
        public virtual ICollection<DbTempOptionParam> TempOptionParams { get; set; }
    }
}
