using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    [Table("Seo")]
    public partial class DbSeo : Base.BaseEntity
    {
        public DbSeo(Guid id) : base(id)
        {
            Articles = new HashSet<DbArticle>();
            ProductCategories = new HashSet<DbProductCategory>();
            ProductGames = new HashSet<DbProductGame>();
            ProductSubCategories = new HashSet<DbProductSubCategory>();
            Products = new HashSet<DbProduct>();
        }
        public DbSeo() { }
        //[Key]
        //[Column("Id")]
        //public Guid Id { get; set; }
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

        [InverseProperty(nameof(DbArticle.Seo))]
        public virtual ICollection<DbArticle> Articles { get; set; }
        [InverseProperty(nameof(DbProductCategory.CategorySeo))]
        public virtual ICollection<DbProductCategory> ProductCategories { get; set; }
        [InverseProperty(nameof(DbProductGame.GameSeo))]
        public virtual ICollection<DbProductGame> ProductGames { get; set; }
        [InverseProperty(nameof(DbProductSubCategory.SubCategorySeo))]
        public virtual ICollection<DbProductSubCategory> ProductSubCategories { get; set; }
        [InverseProperty(nameof(DbProduct.ProductSeo))]
        public virtual ICollection<DbProduct> Products { get; set; }
    }
}
