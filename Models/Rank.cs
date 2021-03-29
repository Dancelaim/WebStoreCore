using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WowCarryCore.Models
{
    public partial class Rank
    {
        public Rank()
        {
            Customers = new HashSet<Customer>();
        }

        [Key]
        public Guid RankId { get; set; }
        [StringLength(55)]
        public string Name { get; set; }
        [StringLength(55)]
        public string Sale { get; set; }

        [InverseProperty(nameof(Customer.Rank))]
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
