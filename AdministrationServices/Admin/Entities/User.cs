﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    public partial class User
    {
        [Key]
        public Guid UserId { get; set; }
        [StringLength(55)]
        public string Name { get; set; }
        [StringLength(55)]
        public string Password { get; set; }
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
