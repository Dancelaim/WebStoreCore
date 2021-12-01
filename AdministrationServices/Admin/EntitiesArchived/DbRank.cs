﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    public partial class DbRank
    {
        public DbRank()
        {
            Customers = new HashSet<DbCustomer>();
        }

        [Key]
        public Guid RankId { get; set; }
        [StringLength(55)]
        public string Name { get; set; }
        [StringLength(55)]
        public string Sale { get; set; }

        [InverseProperty(nameof(DbCustomer.Rank))]
        public virtual ICollection<DbCustomer> Customers { get; set; }
    }
}
