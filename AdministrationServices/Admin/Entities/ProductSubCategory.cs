using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    [Table("ProductSubCategory")]
    public partial class ProductSubCategory
    {
        public ProductSubCategory()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        public Guid ProductSubCategoryId { get; set; }
        [StringLength(50)]
        public string ProductCategoryName { get; set; }
        public Guid? ProductCategoryId { get; set; }
        [StringLength(255)]
        public string CategoryDescription { get; set; }
        public Guid? SubCategorySeoId { get; set; }

        [ForeignKey(nameof(ProductCategoryId))]
        [InverseProperty("ProductSubCategories")]
        public virtual ProductCategory ProductCategory { get; set; }
        [ForeignKey(nameof(SubCategorySeoId))]
        [InverseProperty(nameof(Seo.ProductSubCategories))]
        public virtual Seo SubCategorySeo { get; set; }
        [InverseProperty(nameof(Product.ProductSubCategory))]
        public virtual ICollection<Product> Products { get; set; }
    }
}
