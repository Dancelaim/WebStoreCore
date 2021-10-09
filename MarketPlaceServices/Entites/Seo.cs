using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WowCarryCore.Models
{
    [Table("SEO")]
    public partial class Seo
    {
        public Seo()
        {
            Articles = new HashSet<Article>();
            ProductCategories = new HashSet<ProductCategory>();
            ProductGames = new HashSet<ProductGame>();
            ProductSubCategories = new HashSet<ProductSubCategory>();
            Products = new HashSet<Product>();
        }

        [Key]
        [Column("SEOId")]
        public Guid Seoid { get; set; }
        [StringLength(255)]
        public string MetaTagTitle { get; set; }
        public string MetaTagDescription { get; set; }
        public string MetaTagKeyWords { get; set; }
        [Column("SEOTags")]
        [StringLength(255)]
        public string Seotags { get; set; }
        [StringLength(255)]
        public string CustomTitle1 { get; set; }
        [StringLength(255)]
        public string CustomTitle2 { get; set; }
        [StringLength(255)]
        public string CustomImageTitle { get; set; }
        [StringLength(255)]
        public string CustomImageAlt { get; set; }
        [StringLength(255)]
        public string MetaRobots { get; set; }
        [StringLength(255)]
        public string UrlKeyWord { get; set; }
        [Column("SEOImage")]
        [StringLength(55)]
        public string Seoimage { get; set; }

        [InverseProperty(nameof(Article.Seo))]
        public virtual ICollection<Article> Articles { get; set; }
        [InverseProperty(nameof(ProductCategory.CategorySeo))]
        public virtual ICollection<ProductCategory> ProductCategories { get; set; }
        [InverseProperty(nameof(ProductGame.GameSeo))]
        public virtual ICollection<ProductGame> ProductGames { get; set; }
        [InverseProperty(nameof(ProductSubCategory.SubCategorySeo))]
        public virtual ICollection<ProductSubCategory> ProductSubCategories { get; set; }
        [InverseProperty(nameof(Product.ProductSeo))]
        public virtual ICollection<Product> Products { get; set; }
    }
}
