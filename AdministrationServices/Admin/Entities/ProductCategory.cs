using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    [Table("ProductCategory")]
    public partial class ProductCategory
    {
        public ProductCategory()
        {
            ProductSubCategories = new HashSet<ProductSubCategory>();
            Products = new HashSet<Product>();
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
        [InverseProperty(nameof(Seo.ProductCategories))]
        public virtual Seo CategorySeo { get; set; }
        [ForeignKey(nameof(ProductGameId))]
        [InverseProperty("ProductCategories")]
        public virtual ProductGame ProductGame { get; set; }
        [InverseProperty(nameof(ProductSubCategory.ProductCategory))]
        public virtual ICollection<ProductSubCategory> ProductSubCategories { get; set; }
        [InverseProperty(nameof(Product.ProductCategory))]
        public virtual ICollection<Product> Products { get; set; }
    }
}
