using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WowCarryCore.Models
{
    [Table("ProductGame")]
    public partial class ProductGame
    {
        public ProductGame()
        {
            Articles = new HashSet<Article>();
            ProductCategories = new HashSet<ProductCategory>();
            Products = new HashSet<Product>();
            Realms = new HashSet<Realm>();
        }

        [Key]
        public Guid ProductGameId { get; set; }
        [StringLength(50)]
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        [StringLength(50)]
        public string GameShortUrl { get; set; }
        public Guid? GameSeoId { get; set; }

        [ForeignKey(nameof(GameSeoId))]
        [InverseProperty(nameof(Seo.ProductGames))]
        public virtual Seo GameSeo { get; set; }
        [InverseProperty(nameof(Article.ProductGame))]
        public virtual ICollection<Article> Articles { get; set; }
        [InverseProperty(nameof(ProductCategory.ProductGame))]
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
        [InverseProperty(nameof(Product.ProductGame))]
        public virtual ICollection<Product> Products { get; set; }
        [InverseProperty(nameof(Realm.ProductGame))]
        public virtual ICollection<Realm> Realms { get; set; }
    }
}
