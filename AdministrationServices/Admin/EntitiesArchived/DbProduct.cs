//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using Microsoft.EntityFrameworkCore;

//#nullable disable

//namespace Admin.Entities
//{
//    [Table("Product")]
//    public partial class DbProduct
//    {
//        public DbProduct()
//        {
//            OrderProducts = new HashSet<DbOrderProduct>();
//            ProductOptions = new HashSet<DbProductOption>();
//            ProductPrices = new HashSet<DbProductPrice>();
//        }

//        [Key]
//        public Guid ProductId { get; set; }
//        [Required]
//        [StringLength(50)]
//        public string ProductName { get; set; }
//        public Guid ProductCategoryId { get; set; }
//        [Required]
//        public bool? InStock { get; set; }
//        public bool PreOrder { get; set; }
//        public int? ProductQuantity { get; set; }
//        [StringLength(255)]
//        public string ProductImage { get; set; }
//        public DateTime ProductCreateDate { get; set; }
//        public DateTime ProductUpdateDate { get; set; }
//        public Guid? ProductDescriptionId { get; set; }
//        [Column("ProductSeoId")]
//        public Guid? ProductSeoId { get; set; }
//        public Guid? ProductGameId { get; set; }
//        public Guid? ProductSubCategoryId { get; set; }
//        public int? ProductPriority { get; set; }
//        public bool ProductEnabled { get; set; }
//        [StringLength(255)]
//        public string ProductImageThumb { get; set; }

//        [ForeignKey(nameof(ProductCategoryId))]
//        [InverseProperty("Products")]
//        public virtual DbProductCategory ProductCategory { get; set; }

//        [ForeignKey(nameof(ProductDescriptionId))]
//        [InverseProperty("Products")]
//        public virtual DbProductDescription ProductDescription { get; set; }

//        [ForeignKey(nameof(ProductGameId))]
//        [InverseProperty("Products")]
//        public virtual DbProductGame ProductGame { get; set; }

//        [ForeignKey(nameof(ProductSeoId))]
//        [InverseProperty(nameof(DbSeo.Products))]
//        public virtual DbSeo ProductSeo { get; set; }

//        [ForeignKey(nameof(ProductSubCategoryId))]
//        [InverseProperty("Products")]
//        public virtual DbProductSubCategory ProductSubCategory { get; set; }

//        [InverseProperty(nameof(DbOrderProduct.Product))]
//        public virtual ICollection<DbOrderProduct> OrderProducts { get; set; }

//        [InverseProperty(nameof(DbProductOption.OptionProduct))]
//        public virtual ICollection<DbProductOption> ProductOptions { get; set; }

//        [InverseProperty(nameof(DbProductPrice.Product))]
//        public virtual ICollection<DbProductPrice> ProductPrices { get; set; }
//    }
//}
