using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    public partial class DbRole : Base.BaseEntity
    {
        public DbRole(Guid id) : base(id)
        {
            Users = new HashSet<DbUser>();
        }
        [StringLength(55)]
        public string RoleName { get; set; }

        [InverseProperty(nameof(DbUser.Role))]
        public virtual ICollection<DbUser> Users { get; set; }
    }
}
