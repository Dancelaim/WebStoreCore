using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    public partial class DbRealm : Base.BaseEntity
    {
        public DbRealm(Guid id) : base(id) { }
        public Guid ProductGameId { get; set; }
        [Required]
        [StringLength(55)]
        public string Name { get; set; }

        [ForeignKey(nameof(ProductGameId))]
        [InverseProperty("Realms")]
        public virtual DbProductGame ProductGame { get; set; }
    }
}
