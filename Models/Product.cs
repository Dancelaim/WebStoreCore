using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WowCarryCore.Models
{
    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
            ProductOptions = new HashSet<ProductOption>();
            ProductPrices = new HashSet<ProductPrice>();
        }

        [Key]
        public Guid ProductId { get; set; }
        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }
        public Guid ProductCategoryId { get; set; }
        [Required]
        public bool? InStock { get; set; }
        public bool PreOrder { get; set; }
        public int? ProductQuantity { get; set; }
        [StringLength(255)]
        public string ProductImage { get; set; }
        public DateTime ProductCreateDate { get; set; }
        public DateTime ProductUpdateDate { get; set; }
        public Guid? ProductDescriptionId { get; set; }
        [Column("ProductSEOId")]
        public Guid? ProductSeoid { get; set; }
        public Guid? ProductGameId { get; set; }
        public Guid? ProductSubCategoryId { get; set; }
        public int? ProductPriority { get; set; }
        public bool ProductEnabled { get; set; }
        [StringLength(255)]
        public string ProductImageThumb { get; set; }

        [ForeignKey(nameof(ProductCategoryId))]
        [InverseProperty("Products")]
        public virtual ProductCategory ProductCategory { get; set; }
        [ForeignKey(nameof(ProductDescriptionId))]
        [InverseProperty("Products")]
        public virtual ProductDescription ProductDescription { get; set; }
        [ForeignKey(nameof(ProductGameId))]
        [InverseProperty("Products")]
        public virtual ProductGame ProductGame { get; set; }
        [ForeignKey(nameof(ProductSeoid))]
        [InverseProperty(nameof(Seo.Products))]
        public virtual Seo ProductSeo { get; set; }
        [ForeignKey(nameof(ProductSubCategoryId))]
        [InverseProperty("Products")]
        public virtual ProductSubCategory ProductSubCategory { get; set; }
        [InverseProperty(nameof(OrderProduct.Product))]
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        [InverseProperty(nameof(ProductOption.OptionProduct))]
        public virtual ICollection<ProductOption> ProductOptions { get; set; }
        [InverseProperty(nameof(ProductPrice.Product))]
        public virtual ICollection<ProductPrice> ProductPrices { get; set; }
    }
}
