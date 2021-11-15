using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    public partial class DbCustomer
    {
        public DbCustomer()
        {
            Orders = new HashSet<DbOrder>();
        }

        [Key]
        public Guid CustomerId { get; set; }
        [StringLength(55)]
        public string Name { get; set; }
        [StringLength(55)]
        public string Password { get; set; }
        public Guid? RankId { get; set; }
        [StringLength(55)]
        public string Email { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? CarryCoinsValue { get; set; }

        [ForeignKey(nameof(RankId))]
        [InverseProperty("Customers")]
        public virtual DbRank Rank { get; set; }
        [InverseProperty(nameof(DbOrder.Customer))]
        public virtual ICollection<DbOrder> Orders { get; set; }
    }
}
