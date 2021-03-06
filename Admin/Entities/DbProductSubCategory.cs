using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Admin.Entities
{
    [Table("ProductSubCategory")]
    public partial class DbProductSubCategory : Base.BaseEntity
    {
        public DbProductSubCategory(Guid id) : base(id)
        {
            Products = new HashSet<DbProduct>();
        }
        [StringLength(50)]
        public string Name { get; set; }
        public Guid? ProductCategoryId { get; set; }
        [StringLength(255)]
        public string CategoryDescription { get; set; }
        public Guid? SubCategorySeoId { get; set; }

        [ForeignKey(nameof(ProductCategoryId))]
        [InverseProperty("ProductSubCategories")]
        public virtual DbProductCategory ProductCategory { get; set; }
        [ForeignKey(nameof(SubCategorySeoId))]
        [InverseProperty(nameof(DbSeo.ProductSubCategories))]
        public virtual DbSeo SubCategorySeo { get; set; }
        [InverseProperty(nameof(DbProduct.ProductSubCategory))]
        public virtual ICollection<DbProduct> Products { get; set; }
    }
}
