using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    public partial class DbOrderCustomField : Base.BaseEntity
    {
        public DbOrderCustomField()
        {
            Orders = new HashSet<DbOrder>();
        }
        [StringLength(55)]
        public string ShlCharacterName { get; set; }
        [StringLength(55)]
        public string ShlRealmName { get; set; }
        [StringLength(55)]
        public string ShlFaction { get; set; }
        [StringLength(55)]
        public string ShlRegion { get; set; }
        [StringLength(55)]
        public string ShlBattleTag { get; set; }
        [StringLength(55)]
        public string PoeCharacterName { get; set; }
        [StringLength(55)]
        public string PoeAccountName { get; set; }
        [StringLength(55)]
        public string ClassicCharacterName { get; set; }
        [StringLength(55)]
        public string ClassicRealmName { get; set; }
        [StringLength(55)]
        public string ClassicFaction { get; set; }
        [StringLength(55)]
        public string ClassicRegion { get; set; }
        [StringLength(55)]
        public string ClassicBattleTag { get; set; }

        [InverseProperty(nameof(DbOrder.OrderCustomFields))]
        public virtual ICollection<DbOrder> Orders { get; set; }
    }
}
