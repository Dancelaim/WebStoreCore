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
        public DbSet<DbProduct> Product { get; set; }
        public DbSet<DbArticle> Article { get; set; }
        public DbSet<DbCustomer> Customers { get; set; }
        public DbSet<DbHtmlBlock> HtmlBlocks { get; set; }
        public DbSet<DbHtmlBlocksChild> HtmlBlocksChildren { get; set; }
        public DbSet<DbOrder> Orders { get; set; }
        public DbSet<DbOrderCustomField> OrderCustomFields { get; set; }
        public DbSet<DbOrderProduct> OrderProduct { get; set; }
        public DbSet<DbProductCategory> ProductCategory { get; set; }
        public DbSet<DbProductOption> ProductOptions { get; set; }
        public DbSet<DbProductGame> ProductGame { get; set; }
        public DbSet<DbProductOptionParam> ProductOptionParams { get; set; }
        public DbSet<DbProductPrice> ProductPrice { get; set; }
        public DbSet<DbProductSubCategory> ProductSubCategory { get; set; }
        public DbSet<DbRank> Ranks { get; set; }
        public DbSet<DbRealm> Realms { get; set; }
        public DbSet<DbRole> Roles { get; set; }
        public DbSet<DbSeo> Seo { get; set; }
        public DbSet<DbTemplateOption> TemplateOptions { get; set; }
        public DbSet<DbTempOptionParam> TempOptionParams { get; set; }
        public DbSet<DbUser> Users { get; set; }
        public DbSet<DbProductDescription> ProductDescription { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {
            Database.EnsureCreated();
        }
    }
}
