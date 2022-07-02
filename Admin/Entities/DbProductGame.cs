using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    [Table("ProductGame")]
    public partial class DbProductGame : Base.BaseEntity
    {
        public DbProductGame(Guid id) : base(id)
        {
            Articles = new HashSet<DbArticle>();
            ProductCategories = new HashSet<DbProductCategory>();
            Products = new HashSet<DbProduct>();
            Realms = new HashSet<DbRealm>();
        }
        public DbProductGame(){ }

        [StringLength(50)]
        public string Name { get; set; }
        public string GameDescription { get; set; }
        [StringLength(50)]
        public string GameShortUrl { get; set; }
        public Guid? GameSeoId { get; set; }

        [ForeignKey(nameof(GameSeoId))]
        [InverseProperty(nameof(DbSeo.ProductGames))]
        public virtual DbSeo GameSeo { get; set; }
        [InverseProperty(nameof(DbArticle.ProductGame))]
        public virtual ICollection<DbArticle> Articles { get; set; }
        [InverseProperty(nameof(DbProductCategory.ProductGame))]
        public virtual ICollection<DbProductCategory> ProductCategories { get; set; }
        [InverseProperty(nameof(DbProduct.ProductGame))]
        public virtual ICollection<DbProduct> Products { get; set; }
        [InverseProperty(nameof(DbRealm.ProductGame))]
        public virtual ICollection<DbRealm> Realms { get; set; }
    }
}
