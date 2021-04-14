using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WowCarryCore.Models
{
    public partial class WowCarryContext : DbContext
    {
        public WowCarryContext()
        {
        }

        public WowCarryContext(DbContextOptions<WowCarryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<HtmlBlock> HtmlBlocks { get; set; }
        public virtual DbSet<HtmlBlocksChild> HtmlBlocksChildren { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderCustomField> OrderCustomFields { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductDescription> ProductDescriptions { get; set; }
        public virtual DbSet<ProductGame> ProductGames { get; set; }
        public virtual DbSet<ProductOption> ProductOptions { get; set; }
        public virtual DbSet<ProductOptionParam> ProductOptionParams { get; set; }
        public virtual DbSet<ProductPrice> ProductPrices { get; set; }
        public virtual DbSet<ProductSubCategory> ProductSubCategories { get; set; }
        public virtual DbSet<Rank> Ranks { get; set; }
        public virtual DbSet<Realm> Realms { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<ScriptHistory> ScriptHistories { get; set; }
        public virtual DbSet<Seo> Seos { get; set; }
        public virtual DbSet<TempOptionParam> TempOptionParams { get; set; }
        public virtual DbSet<TemplateOption> TemplateOptions { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-E8H9F0E\\MSSQLSERVER01;initial catalog=WowCarry;Integrated Security=True;ConnectRetryCount=0");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Article>(entity =>
            {
                entity.Property(e => e.ArticleId).ValueGeneratedNever();

                entity.Property(e => e.ArticleCreateTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ArticlePostTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ArticleUpdateTime).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ProductGame)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.ProductGameId)
                    .HasConstraintName("FK_ProductGame");

                entity.HasOne(d => d.Seo)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.Seoid)
                    .HasConstraintName("FK_SEO");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.CustomerId).ValueGeneratedNever();

                entity.HasOne(d => d.Rank)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.RankId)
                    .HasConstraintName("FK__Customers__RankI__44952D46");
            });

            modelBuilder.Entity<HtmlBlock>(entity =>
            {
                entity.Property(e => e.SiteBlockId).ValueGeneratedNever();
            });

            modelBuilder.Entity<HtmlBlocksChild>(entity =>
            {
                entity.Property(e => e.SiteBlockChildsId).ValueGeneratedNever();

                entity.HasOne(d => d.SiteBlock)
                    .WithMany(p => p.HtmlBlocksChildren)
                    .HasForeignKey(d => d.SiteBlockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HtmlBlocksChildren_HtmlBlocks");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.Property(e => e.OrderNumber).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Orders__Customer__4A4E069C");

                entity.HasOne(d => d.OrderCustomFields)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderCustomFieldsId)
                    .HasConstraintName("FK__Orders__OrderCus__4959E263");
            });

            modelBuilder.Entity<OrderCustomField>(entity =>
            {
                entity.HasKey(e => e.OrderCustomFieldsId)
                    .HasName("PK__OrderCus__4174ADEDDCAB73CD");

                entity.Property(e => e.OrderCustomFieldsId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.InStock).HasDefaultValueSql("((1))");

                entity.Property(e => e.ProductCreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProductQuantity).HasDefaultValueSql("((999))");

                entity.Property(e => e.ProductUpdateDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .HasConstraintName("FK_Products_ProductCategory");

                entity.HasOne(d => d.ProductDescription)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductDescriptionId)
                    .HasConstraintName("FK__Product__ProductDescription");

                entity.HasOne(d => d.ProductGame)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductGameId)
                    .HasConstraintName("FK__Product__ProductGame");

                entity.HasOne(d => d.ProductSeo)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductSeoid)
                    .HasConstraintName("FK__Product__Product__662B2B3B");

                entity.HasOne(d => d.ProductSubCategory)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductSubCategoryId)
                    .HasConstraintName("FK__Product__ProductSubCategory");
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.Property(e => e.ProductCategoryId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.CategorySeo)
                    .WithMany(p => p.ProductCategories)
                    .HasForeignKey(d => d.CategorySeoId)
                    .HasConstraintName("FK__ProductCa__Categ__6AEFE058");

                entity.HasOne(d => d.ProductGame)
                    .WithMany(p => p.ProductCategories)
                    .HasForeignKey(d => d.ProductGameId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ProductCategory_ProductGame");
            });

            modelBuilder.Entity<ProductDescription>(entity =>
            {
                entity.Property(e => e.ProductDescriptionId).ValueGeneratedNever();
            });

            modelBuilder.Entity<ProductGame>(entity =>
            {
                entity.Property(e => e.ProductGameId).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.GameSeo)
                    .WithMany(p => p.ProductGames)
                    .HasForeignKey(d => d.GameSeoId)
                    .HasConstraintName("FK__ProductGa__GameS__69FBBC1F");
            });

            modelBuilder.Entity<ProductOption>(entity =>
            {
                entity.HasKey(e => e.OptionId)
                    .HasName("PK_ProductOption");

                entity.Property(e => e.OptionId).ValueGeneratedNever();

                entity.HasOne(d => d.OptionParent)
                    .WithMany(p => p.InverseOptionParent)
                    .HasForeignKey(d => d.OptionParentId)
                    .HasConstraintName("FK_ProductOptions_ProductOptions");

                entity.HasOne(d => d.OptionProduct)
                    .WithMany(p => p.ProductOptions)
                    .HasForeignKey(d => d.OptionProductId)
                    .HasConstraintName("FK_ProductOptions_Product");
            });

            modelBuilder.Entity<ProductOptionParam>(entity =>
            {
                entity.HasKey(e => e.ParameterId)
                    .HasName("PK_OptionParams");

                entity.Property(e => e.ParameterId).ValueGeneratedNever();

                entity.HasOne(d => d.ParameterParent)
                    .WithMany(p => p.InverseParameterParent)
                    .HasForeignKey(d => d.ParameterParentId)
                    .HasConstraintName("FK_ProductOptionParams_ProductOptionParams");

                entity.HasOne(d => d.ParentOption)
                    .WithMany(p => p.ProductOptionParams)
                    .HasForeignKey(d => d.ParentOptionId)
                    .HasConstraintName("FK_ProductOptionParams_ProductOptions");
            });

            modelBuilder.Entity<ProductPrice>(entity =>
            {
                entity.Property(e => e.ProductPriceId).ValueGeneratedNever();

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductPrices)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductPrice_Product");
            });

            modelBuilder.Entity<ProductSubCategory>(entity =>
            {
                entity.Property(e => e.ProductSubCategoryId).ValueGeneratedNever();

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.ProductSubCategories)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .HasConstraintName("FK__ProductSu__Produ__65F62111");

                entity.HasOne(d => d.SubCategorySeo)
                    .WithMany(p => p.ProductSubCategories)
                    .HasForeignKey(d => d.SubCategorySeoId)
                    .HasConstraintName("FK__ProductSu__SubCa__6BE40491");
            });

            modelBuilder.Entity<Rank>(entity =>
            {
                entity.Property(e => e.RankId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Realm>(entity =>
            {
                entity.Property(e => e.RealmId).ValueGeneratedNever();

                entity.HasOne(d => d.ProductGame)
                    .WithMany(p => p.Realms)
                    .HasForeignKey(d => d.ProductGameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Realms__ProductG__4F47C5E3");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Seo>(entity =>
            {
                entity.Property(e => e.Seoid).ValueGeneratedNever();
            });

            modelBuilder.Entity<TempOptionParam>(entity =>
            {
                entity.HasKey(e => e.ParameterId)
                    .HasName("PK_Params");

                entity.Property(e => e.ParameterId).ValueGeneratedNever();

                entity.HasOne(d => d.DeleteNavigation)
                    .WithMany(p => p.InverseDeleteNavigation)
                    .HasForeignKey(d => d.Delete)
                    .HasConstraintName("FK_TempOptionParams_TempOptionParams");

                entity.HasOne(d => d.ParentOption)
                    .WithMany(p => p.TempOptionParams)
                    .HasForeignKey(d => d.ParentOptionId)
                    .HasConstraintName("FK_TempOptionParams_TemplateOptions");
            });

            modelBuilder.Entity<TemplateOption>(entity =>
            {
                entity.HasKey(e => e.OptionId)
                    .HasName("PK_TempOption");

                entity.Property(e => e.OptionId).ValueGeneratedNever();

                entity.Property(e => e.OptionType).IsFixedLength(true);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Users__RoleId__3A179ED3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
