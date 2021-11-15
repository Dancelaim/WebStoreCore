using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    [Table("ProductCategory")]
    public partial class DbProductCategory
    {
        public DbProductCategory()
        {
            ProductSubCategories = new HashSet<DbProductSubCategory>();
            Products = new HashSet<DbProduct>();
        }

        [Key]
        public Guid ProductCategoryId { get; set; }
        [Required]
        [StringLength(50)]
        public string ProductCategoryName { get; set; }
        public Guid? ProductGameId { get; set; }
        [StringLength(255)]
        public string CategoryDescription { get; set; }
        public Guid? CategorySeoId { get; set; }

        [ForeignKey(nameof(CategorySeoId))]
        [InverseProperty(nameof(DbSeo.ProductCategories))]
        public virtual DbSeo CategorySeo { get; set; }
        [ForeignKey(nameof(ProductGameId))]
        [InverseProperty("ProductCategories")]
        public virtual DbProductGame ProductGame { get; set; }
        [InverseProperty(nameof(DbProductSubCategory.ProductCategory))]
        public virtual ICollection<DbProductSubCategory> ProductSubCategories { get; set; }
        [InverseProperty(nameof(DbProduct.ProductCategory))]
        public virtual ICollection<DbProduct> Products { get; set; }
    }
}
