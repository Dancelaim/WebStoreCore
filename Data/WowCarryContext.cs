using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WowCarry.Data
{
    public partial class WowCarryContext : DbContext
    {
        public WowCarryContext(DbContextOptions<WowCarryContext> options)
            : base(options)
        {
        }

        #region Generated Properties
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Generated Configuration
            #endregion
        }
    }
}
