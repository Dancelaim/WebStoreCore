using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Entities;
using Microsoft.EntityFrameworkCore;

namespace Admin.Core
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Article> Article { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<HtmlBlock> HtmlBlocks { get; set; }
        public DbSet<HtmlBlocksChild> HtmlBlocksChildren { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderCustomField> OrderCustomFields { get; set; }
        public DbSet<OrderProduct> OrderProduct { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
        public DbSet<ProductOption> ProductOptions { get; set; }
        public DbSet<ProductGame> ProductGame { get; set; }
        public DbSet<ProductOptionParam> ProductOptionParams { get; set; }
        public DbSet<ProductPrice> ProductPrice { get; set; }
        public DbSet<ProductSubCategory> ProductSubCategory { get; set; }
        public DbSet<Rank> Ranks { get; set; }
        public DbSet<Realm> Realms { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Seo> Seo { get; set; }
        public DbSet<TemplateOption> TemplateOptions { get; set; }
        public DbSet<TempOptionParam> TempOptionParams { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductDescription> ProductDescription { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {
            Database.EnsureCreated();
        }
    }
}
