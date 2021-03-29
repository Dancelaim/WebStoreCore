using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WowCarryCore.Models
{
    public partial class User
    {
        [Key]
        public Guid UserId { get; set; }
        [StringLength(55)]
        public string UserName { get; set; }
        [StringLength(55)]
        public string UserPassword { get; set; }
        public Guid? RoleId { get; set; }
        [StringLength(55)]
        public string Email { get; set; }
        [StringLength(55)]
        public string DefaultPage { get; set; }

        [ForeignKey(nameof(RoleId))]
        [InverseProperty("Users")]
        public virtual Role Role { get; set; }
    }
}
