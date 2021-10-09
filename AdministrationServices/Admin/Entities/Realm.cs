using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    public partial class Realm
    {
        [Key]
        public Guid RealmId { get; set; }
        public Guid ProductGameId { get; set; }
        [Required]
        [StringLength(55)]
        public string RealmName { get; set; }

        [ForeignKey(nameof(ProductGameId))]
        [InverseProperty("Realms")]
        public virtual ProductGame ProductGame { get; set; }
    }
}
