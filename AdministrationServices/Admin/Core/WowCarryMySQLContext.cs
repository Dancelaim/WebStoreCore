using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Admin.MySQLModel
{
    public partial class WowCarryMySQLContext : DbContext
    {
        public WowCarryMySQLContext()
        {
        }

        public WowCarryMySQLContext(DbContextOptions<WowCarryMySQLContext> options)
            : base(options)
        {
        }

        public virtual DbSet<OchvAddress> OchvAddresses { get; set; }
        public virtual DbSet<OchvAdvertiseGoogleTarget> OchvAdvertiseGoogleTargets { get; set; }
        public virtual DbSet<OchvAfAttributeValue> OchvAfAttributeValues { get; set; }
        public virtual DbSet<OchvAfAttributeValuesBackup> OchvAfAttributeValuesBackups { get; set; }
        public virtual DbSet<OchvAfEan> OchvAfEans { get; set; }
        public virtual DbSet<OchvAfFilter> OchvAfFilters { get; set; }
        public virtual DbSet<OchvAfFilterBackup> OchvAfFilterBackups { get; set; }
        public virtual DbSet<OchvAfProductAttribute> OchvAfProductAttributes { get; set; }
        public virtual DbSet<OchvAfProductEan> OchvAfProductEans { get; set; }
        public virtual DbSet<OchvAfProductTag> OchvAfProductTags { get; set; }
        public virtual DbSet<OchvAfQuery> OchvAfQueries { get; set; }
        public virtual DbSet<OchvAfQueryDescription> OchvAfQueryDescriptions { get; set; }
        public virtual DbSet<OchvAfTag> OchvAfTags { get; set; }
        public virtual DbSet<OchvAfTranslit> OchvAfTranslits { get; set; }
        public virtual DbSet<OchvAfValue> OchvAfValues { get; set; }
        public virtual DbSet<OchvAmazonLoginPayOrder> OchvAmazonLoginPayOrders { get; set; }
        public virtual DbSet<OchvAmazonLoginPayOrderTransaction> OchvAmazonLoginPayOrderTransactions { get; set; }
        public virtual DbSet<OchvApi> OchvApis { get; set; }
        public virtual DbSet<OchvApiIp> OchvApiIps { get; set; }
        public virtual DbSet<OchvApiSession> OchvApiSessions { get; set; }
        public virtual DbSet<OchvAttribute> OchvAttributes { get; set; }
        public virtual DbSet<OchvAttributeDescription> OchvAttributeDescriptions { get; set; }
        public virtual DbSet<OchvAttributeGroup> OchvAttributeGroups { get; set; }
        public virtual DbSet<OchvAttributeGroupDescription> OchvAttributeGroupDescriptions { get; set; }
        public virtual DbSet<OchvBanner> OchvBanners { get; set; }
        public virtual DbSet<OchvBannerImage> OchvBannerImages { get; set; }
        public virtual DbSet<OchvBmAuthor> OchvBmAuthors { get; set; }
        public virtual DbSet<OchvBmAuthorDescription> OchvBmAuthorDescriptions { get; set; }
        public virtual DbSet<OchvBmAuthorGroup> OchvBmAuthorGroups { get; set; }
        public virtual DbSet<OchvBmCategory> OchvBmCategories { get; set; }
        public virtual DbSet<OchvBmCategoryDescription> OchvBmCategoryDescriptions { get; set; }
        public virtual DbSet<OchvBmCategoryPath> OchvBmCategoryPaths { get; set; }
        public virtual DbSet<OchvBmCategoryToLayout> OchvBmCategoryToLayouts { get; set; }
        public virtual DbSet<OchvBmCategoryToStore> OchvBmCategoryToStores { get; set; }
        public virtual DbSet<OchvBmPost> OchvBmPosts { get; set; }
        public virtual DbSet<OchvBmPostDescription> OchvBmPostDescriptions { get; set; }
        public virtual DbSet<OchvBmPostRelated> OchvBmPostRelateds { get; set; }
        public virtual DbSet<OchvBmPostToCategory> OchvBmPostToCategories { get; set; }
        public virtual DbSet<OchvBmPostToLayout> OchvBmPostToLayouts { get; set; }
        public virtual DbSet<OchvBmPostToProduct> OchvBmPostToProducts { get; set; }
        public virtual DbSet<OchvBmPostToStore> OchvBmPostToStores { get; set; }
        public virtual DbSet<OchvBmPostVideo> OchvBmPostVideos { get; set; }
        public virtual DbSet<OchvBmReview> OchvBmReviews { get; set; }
        public virtual DbSet<OchvBmReviewToImage> OchvBmReviewToImages { get; set; }
        public virtual DbSet<OchvCart> OchvCarts { get; set; }
        public virtual DbSet<OchvCategory> OchvCategories { get; set; }
        public virtual DbSet<OchvCategoryDescription> OchvCategoryDescriptions { get; set; }
        public virtual DbSet<OchvCategoryFilter> OchvCategoryFilters { get; set; }
        public virtual DbSet<OchvCategoryPath> OchvCategoryPaths { get; set; }
        public virtual DbSet<OchvCategoryToGoogleProductCategory> OchvCategoryToGoogleProductCategories { get; set; }
        public virtual DbSet<OchvCategoryToLayout> OchvCategoryToLayouts { get; set; }
        public virtual DbSet<OchvCategoryToStore> OchvCategoryToStores { get; set; }
        public virtual DbSet<OchvCoinbaseCommerceOrder> OchvCoinbaseCommerceOrders { get; set; }
        public virtual DbSet<OchvCountry> OchvCountries { get; set; }
        public virtual DbSet<OchvCoupon> OchvCoupons { get; set; }
        public virtual DbSet<OchvCouponCategory> OchvCouponCategories { get; set; }
        public virtual DbSet<OchvCouponHistory> OchvCouponHistories { get; set; }
        public virtual DbSet<OchvCouponProduct> OchvCouponProducts { get; set; }
        public virtual DbSet<OchvCron> OchvCrons { get; set; }
        public virtual DbSet<OchvCurrency> OchvCurrencies { get; set; }
        public virtual DbSet<OchvCustomField> OchvCustomFields { get; set; }
        public virtual DbSet<OchvCustomFieldCustomerGroup> OchvCustomFieldCustomerGroups { get; set; }
        public virtual DbSet<OchvCustomFieldDescription> OchvCustomFieldDescriptions { get; set; }
        public virtual DbSet<OchvCustomFieldValue> OchvCustomFieldValues { get; set; }
        public virtual DbSet<OchvCustomFieldValueDescription> OchvCustomFieldValueDescriptions { get; set; }
        public virtual DbSet<OchvCustomer> OchvCustomers { get; set; }
        public virtual DbSet<OchvCustomerActivity> OchvCustomerActivities { get; set; }
        public virtual DbSet<OchvCustomerAffiliate> OchvCustomerAffiliates { get; set; }
        public virtual DbSet<OchvCustomerApproval> OchvCustomerApprovals { get; set; }
        public virtual DbSet<OchvCustomerAuthentication> OchvCustomerAuthentications { get; set; }
        public virtual DbSet<OchvCustomerGroup> OchvCustomerGroups { get; set; }
        public virtual DbSet<OchvCustomerGroupDescription> OchvCustomerGroupDescriptions { get; set; }
        public virtual DbSet<OchvCustomerHistory> OchvCustomerHistories { get; set; }
        public virtual DbSet<OchvCustomerIp> OchvCustomerIps { get; set; }
        public virtual DbSet<OchvCustomerLogin> OchvCustomerLogins { get; set; }
        public virtual DbSet<OchvCustomerOnline> OchvCustomerOnlines { get; set; }
        public virtual DbSet<OchvCustomerReward> OchvCustomerRewards { get; set; }
        public virtual DbSet<OchvCustomerSearch> OchvCustomerSearches { get; set; }
        public virtual DbSet<OchvCustomerTransaction> OchvCustomerTransactions { get; set; }
        public virtual DbSet<OchvCustomerWishlist> OchvCustomerWishlists { get; set; }
        public virtual DbSet<OchvDGdprCookie> OchvDGdprCookies { get; set; }
        public virtual DbSet<OchvDGdprPolicy> OchvDGdprPolicies { get; set; }
        public virtual DbSet<OchvDGdprRequest> OchvDGdprRequests { get; set; }
        public virtual DbSet<OchvDGdprRestrict> OchvDGdprRestricts { get; set; }
        public virtual DbSet<OchvDMetaDatum> OchvDMetaData { get; set; }
        public virtual DbSet<OchvDNewsletterAffiliate> OchvDNewsletterAffiliates { get; set; }
        public virtual DbSet<OchvDNewsletterCustomer> OchvDNewsletterCustomers { get; set; }
        public virtual DbSet<OchvDNewsletterHistoryEmailCustomer> OchvDNewsletterHistoryEmailCustomers { get; set; }
        public virtual DbSet<OchvDNewsletterHistoryTemplate> OchvDNewsletterHistoryTemplates { get; set; }
        public virtual DbSet<OchvDNewsletterHistoryTemplateCategory> OchvDNewsletterHistoryTemplateCategories { get; set; }
        public virtual DbSet<OchvDNewsletterHistoryTemplateDescription> OchvDNewsletterHistoryTemplateDescriptions { get; set; }
        public virtual DbSet<OchvDNewsletterHistoryTemplateEmail> OchvDNewsletterHistoryTemplateEmails { get; set; }
        public virtual DbSet<OchvDNewsletterHistoryTemplateProduct> OchvDNewsletterHistoryTemplateProducts { get; set; }
        public virtual DbSet<OchvDNewsletterSubscriber> OchvDNewsletterSubscribers { get; set; }
        public virtual DbSet<OchvDNewsletterSubscriberGroup> OchvDNewsletterSubscriberGroups { get; set; }
        public virtual DbSet<OchvDNewsletterSubscriberGroupDescription> OchvDNewsletterSubscriberGroupDescriptions { get; set; }
        public virtual DbSet<OchvDNewsletterSubscriberToSubscriberGroup> OchvDNewsletterSubscriberToSubscriberGroups { get; set; }
        public virtual DbSet<OchvDNewsletterTask> OchvDNewsletterTasks { get; set; }
        public virtual DbSet<OchvDNewsletterTaskDescription> OchvDNewsletterTaskDescriptions { get; set; }
        public virtual DbSet<OchvDNewsletterTemplate> OchvDNewsletterTemplates { get; set; }
        public virtual DbSet<OchvDNewsletterTemplateCategory> OchvDNewsletterTemplateCategories { get; set; }
        public virtual DbSet<OchvDNewsletterTemplateDescription> OchvDNewsletterTemplateDescriptions { get; set; }
        public virtual DbSet<OchvDNewsletterTemplateProduct> OchvDNewsletterTemplateProducts { get; set; }
        public virtual DbSet<OchvDPostCategory> OchvDPostCategories { get; set; }
        public virtual DbSet<OchvDProductCategory> OchvDProductCategories { get; set; }
        public virtual DbSet<OchvDRank> OchvDRanks { get; set; }
        public virtual DbSet<OchvDRefreshPage> OchvDRefreshPages { get; set; }
        public virtual DbSet<OchvDTargetKeyword> OchvDTargetKeywords { get; set; }
        public virtual DbSet<OchvDUrlRedirect> OchvDUrlRedirects { get; set; }
        public virtual DbSet<OchvDValidator> OchvDValidators { get; set; }
        public virtual DbSet<OchvDownload> OchvDownloads { get; set; }
        public virtual DbSet<OchvDownloadDescription> OchvDownloadDescriptions { get; set; }
        public virtual DbSet<OchvDqcSetting> OchvDqcSettings { get; set; }
        public virtual DbSet<OchvDqcSettingDatum> OchvDqcSettingData { get; set; }
        public virtual DbSet<OchvDqcStatistic> OchvDqcStatistics { get; set; }
        public virtual DbSet<OchvEbDashboardEnqury> OchvEbDashboardEnquries { get; set; }
        public virtual DbSet<OchvFilter> OchvFilters { get; set; }
        public virtual DbSet<OchvFilterDescription> OchvFilterDescriptions { get; set; }
        public virtual DbSet<OchvFilterGroup> OchvFilterGroups { get; set; }
        public virtual DbSet<OchvFilterGroupDescription> OchvFilterGroupDescriptions { get; set; }
        public virtual DbSet<OchvGiftCouponsEmailList> OchvGiftCouponsEmailLists { get; set; }
        public virtual DbSet<OchvIeEmailSended> OchvIeEmailSendeds { get; set; }
        public virtual DbSet<OchvInformation> OchvInformations { get; set; }
        public virtual DbSet<OchvInformationDescription> OchvInformationDescriptions { get; set; }
        public virtual DbSet<OchvInformationToLayout> OchvInformationToLayouts { get; set; }
        public virtual DbSet<OchvLanguage> OchvLanguages { get; set; }
        public virtual DbSet<OchvLayout> OchvLayouts { get; set; }
        public virtual DbSet<OchvLayoutModule> OchvLayoutModules { get; set; }
        public virtual DbSet<OchvLayoutRoute> OchvLayoutRoutes { get; set; }
        public virtual DbSet<OchvOption> OchvOptions { get; set; }
        public virtual DbSet<OchvOptionDescription> OchvOptionDescriptions { get; set; }
        public virtual DbSet<OchvOptionValue> OchvOptionValues { get; set; }
        public virtual DbSet<OchvOptionValueDescription> OchvOptionValueDescriptions { get; set; }
        public virtual DbSet<OchvOrder> OchvOrders { get; set; }
        public virtual DbSet<OchvOrderHistory> OchvOrderHistories { get; set; }
        public virtual DbSet<OchvOrderOption> OchvOrderOptions { get; set; }
        public virtual DbSet<OchvOrderProduct> OchvOrderProducts { get; set; }
        public virtual DbSet<OchvOrderRecurring> OchvOrderRecurrings { get; set; }
        public virtual DbSet<OchvOrderRecurringTransaction> OchvOrderRecurringTransactions { get; set; }
        public virtual DbSet<OchvOrderShipment> OchvOrderShipments { get; set; }
        public virtual DbSet<OchvOrderStatus> OchvOrderStatuses { get; set; }
        public virtual DbSet<OchvOrderTotal> OchvOrderTotals { get; set; }
        public virtual DbSet<OchvOrderVoucher> OchvOrderVouchers { get; set; }
        public virtual DbSet<OchvProduct> OchvProducts { get; set; }
        public virtual DbSet<OchvProductAttribute> OchvProductAttributes { get; set; }
        public virtual DbSet<OchvProductDescription> OchvProductDescriptions { get; set; }
        public virtual DbSet<OchvProductDiscount> OchvProductDiscounts { get; set; }
        public virtual DbSet<OchvProductFilter> OchvProductFilters { get; set; }
        public virtual DbSet<OchvProductImage> OchvProductImages { get; set; }
        public virtual DbSet<OchvProductOption> OchvProductOptions { get; set; }
        public virtual DbSet<OchvProductOptionValue> OchvProductOptionValues { get; set; }
        public virtual DbSet<OchvProductRecurring> OchvProductRecurrings { get; set; }
        public virtual DbSet<OchvProductRelated> OchvProductRelateds { get; set; }
        public virtual DbSet<OchvProductReward> OchvProductRewards { get; set; }
        public virtual DbSet<OchvProductSpecial> OchvProductSpecials { get; set; }
        public virtual DbSet<OchvProductToCategory> OchvProductToCategories { get; set; }
        public virtual DbSet<OchvProductToLayout> OchvProductToLayouts { get; set; }
        public virtual DbSet<OchvProductToStore> OchvProductToStores { get; set; }
        public virtual DbSet<OchvRaidTime> OchvRaidTimes { get; set; }
        public virtual DbSet<OchvRecurring> OchvRecurrings { get; set; }
        public virtual DbSet<OchvRecurringDescription> OchvRecurringDescriptions { get; set; }
        public virtual DbSet<OchvReview> OchvReviews { get; set; }
        public virtual DbSet<OchvSeoUrl> OchvSeoUrls { get; set; }
        public virtual DbSet<OchvSession> OchvSessions { get; set; }
        public virtual DbSet<OchvSetting> OchvSettings { get; set; }
        public virtual DbSet<OchvStatistic> OchvStatistics { get; set; }
        public virtual DbSet<OchvStockStatus> OchvStockStatuses { get; set; }
        public virtual DbSet<OchvUser> OchvUsers { get; set; }
        public virtual DbSet<OchvUserGroup> OchvUserGroups { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=127.0.0.1;uid=root;pwd=745698523MySQL;database=wowcarry");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OchvAddress>(entity =>
            {
                entity.HasKey(e => e.AddressId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_address");

                entity.HasIndex(e => e.CustomerId, "customer_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("address_1");

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("address_2");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("city");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("company");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.CustomField)
                    .IsRequired()
                    .HasColumnName("custom_field");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("firstname");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("lastname");

                entity.Property(e => e.Postcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("postcode");

                entity.Property(e => e.ZoneId).HasColumnName("zone_id");
            });

            modelBuilder.Entity<OchvAdvertiseGoogleTarget>(entity =>
            {
                entity.HasKey(e => e.AdvertiseGoogleTargetId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_advertise_google_target");

                entity.HasIndex(e => e.StoreId, "store_id");

                entity.Property(e => e.AdvertiseGoogleTargetId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("advertise_google_target_id");

                entity.Property(e => e.Budget)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("budget");

                entity.Property(e => e.CampaignName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("campaign_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("country")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Feeds)
                    .IsRequired()
                    .HasColumnName("feeds");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnType("enum('paused','active')")
                    .HasColumnName("status")
                    .HasDefaultValueSql("'paused'");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OchvAfAttributeValue>(entity =>
            {
                entity.HasKey(e => e.AttributeValueId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_af_attribute_values");

                entity.HasIndex(e => new { e.AttributeId, e.LanguageId, e.Text }, "attribute_id_language_id_text")
                    .IsUnique();

                entity.Property(e => e.AttributeValueId).HasColumnName("attribute_value_id");

                entity.Property(e => e.AttributeId).HasColumnName("attribute_id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("text");
            });

            modelBuilder.Entity<OchvAfAttributeValuesBackup>(entity =>
            {
                entity.HasKey(e => e.AttributeValueId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_af_attribute_values_backup");

                entity.HasIndex(e => new { e.AttributeId, e.LanguageId, e.Text }, "attribute_id")
                    .IsUnique();

                entity.Property(e => e.AttributeValueId).HasColumnName("attribute_value_id");

                entity.Property(e => e.AttributeId).HasColumnName("attribute_id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("text");
            });

            modelBuilder.Entity<OchvAfEan>(entity =>
            {
                entity.HasKey(e => e.EanId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_af_ean");

                entity.HasIndex(e => e.Value, "value")
                    .IsUnique();

                entity.Property(e => e.EanId).HasColumnName("ean_id");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OchvAfFilter>(entity =>
            {
                entity.HasKey(e => new { e.FilterId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_af_filter");

                entity.Property(e => e.FilterId).HasColumnName("filter_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image");
            });

            modelBuilder.Entity<OchvAfFilterBackup>(entity =>
            {
                entity.HasKey(e => new { e.FilterId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_af_filter_backup");

                entity.Property(e => e.FilterId).HasColumnName("filter_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image");
            });

            modelBuilder.Entity<OchvAfProductAttribute>(entity =>
            {
                entity.HasKey(e => e.ProductAttributeId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_af_product_attribute");

                entity.HasIndex(e => e.AttributeId, "attribute_id");

                entity.HasIndex(e => e.AttributeValueId, "attribute_value_id");

                entity.HasIndex(e => e.ProductId, "product_id");

                entity.Property(e => e.ProductAttributeId).HasColumnName("product_attribute_id");

                entity.Property(e => e.AttributeId).HasColumnName("attribute_id");

                entity.Property(e => e.AttributeValueId).HasColumnName("attribute_value_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<OchvAfProductEan>(entity =>
            {
                entity.HasKey(e => e.ProductEanId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_af_product_ean");

                entity.HasIndex(e => e.EanId, "ean_id");

                entity.HasIndex(e => e.ProductId, "product_id");

                entity.Property(e => e.ProductEanId).HasColumnName("product_ean_id");

                entity.Property(e => e.EanId).HasColumnName("ean_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<OchvAfProductTag>(entity =>
            {
                entity.HasKey(e => e.ProductTagId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_af_product_tag");

                entity.HasIndex(e => e.ProductId, "product_id");

                entity.HasIndex(e => e.TagId, "tag_id");

                entity.Property(e => e.ProductTagId).HasColumnName("product_tag_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.TagId).HasColumnName("tag_id");
            });

            modelBuilder.Entity<OchvAfQuery>(entity =>
            {
                entity.HasKey(e => e.QueryId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_af_query");

                entity.Property(e => e.QueryId).HasColumnName("query_id");

                entity.Property(e => e.Params)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("params");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("path");

                entity.Property(e => e.Popularity).HasColumnName("popularity");
            });

            modelBuilder.Entity<OchvAfQueryDescription>(entity =>
            {
                entity.HasKey(e => new { e.QueryId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_af_query_description");

                entity.Property(e => e.QueryId).HasColumnName("query_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.H1)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("h1");

                entity.Property(e => e.MetaDescription)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("meta_description");

                entity.Property(e => e.MetaKeyword)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("meta_keyword");

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("meta_title");
            });

            modelBuilder.Entity<OchvAfTag>(entity =>
            {
                entity.HasKey(e => e.TagId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_af_tag");

                entity.HasIndex(e => new { e.LanguageId, e.Value }, "language_id")
                    .IsUnique();

                entity.Property(e => e.TagId).HasColumnName("tag_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OchvAfTranslit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ochv_af_translit");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("text");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("type");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<OchvAfValue>(entity =>
            {
                entity.HasKey(e => e.AfValueId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_af_values");

                entity.HasIndex(e => new { e.Type, e.GroupId, e.Value }, "type")
                    .IsUnique();

                entity.Property(e => e.AfValueId).HasColumnName("af_value_id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("type");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<OchvAmazonLoginPayOrder>(entity =>
            {
                entity.HasKey(e => e.AmazonLoginPayOrderId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_amazon_login_pay_order");

                entity.HasIndex(e => e.AmazonOrderReferenceId, "amazon_order_reference_id");

                entity.Property(e => e.AmazonLoginPayOrderId).HasColumnName("amazon_login_pay_order_id");

                entity.Property(e => e.AmazonAuthorizationId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("amazon_authorization_id");

                entity.Property(e => e.AmazonOrderReferenceId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("amazon_order_reference_id");

                entity.Property(e => e.CancelStatus).HasColumnName("cancel_status");

                entity.Property(e => e.CaptureStatus).HasColumnName("capture_status");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("currency_code")
                    .IsFixedLength(true);

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.FreeShipping)
                    .HasColumnType("tinyint")
                    .HasColumnName("free_shipping");

                entity.Property(e => e.Modified).HasColumnName("modified");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.RefundStatus).HasColumnName("refund_status");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(10,2)")
                    .HasColumnName("total");
            });

            modelBuilder.Entity<OchvAmazonLoginPayOrderTransaction>(entity =>
            {
                entity.HasKey(e => e.AmazonLoginPayOrderTransactionId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_amazon_login_pay_order_transaction");

                entity.Property(e => e.AmazonLoginPayOrderTransactionId).HasColumnName("amazon_login_pay_order_transaction_id");

                entity.Property(e => e.AmazonAuthorizationId)
                    .HasMaxLength(255)
                    .HasColumnName("amazon_authorization_id");

                entity.Property(e => e.AmazonCaptureId)
                    .HasMaxLength(255)
                    .HasColumnName("amazon_capture_id");

                entity.Property(e => e.AmazonLoginPayOrderId).HasColumnName("amazon_login_pay_order_id");

                entity.Property(e => e.AmazonRefundId)
                    .HasMaxLength(255)
                    .HasColumnName("amazon_refund_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(10,2)")
                    .HasColumnName("amount");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Status)
                    .HasColumnType("enum('Open','Pending','Completed','Suspended','Declined','Closed','Canceled')")
                    .HasColumnName("status");

                entity.Property(e => e.Type)
                    .HasColumnType("enum('authorization','capture','refund','cancel')")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<OchvApi>(entity =>
            {
                entity.HasKey(e => e.ApiId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_api");

                entity.Property(e => e.ApiId).HasColumnName("api_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasColumnName("key");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<OchvApiIp>(entity =>
            {
                entity.HasKey(e => e.ApiIpId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_api_ip");

                entity.Property(e => e.ApiIpId).HasColumnName("api_ip_id");

                entity.Property(e => e.ApiId).HasColumnName("api_id");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");
            });

            modelBuilder.Entity<OchvApiSession>(entity =>
            {
                entity.HasKey(e => e.ApiSessionId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_api_session");

                entity.Property(e => e.ApiSessionId).HasColumnName("api_session_id");

                entity.Property(e => e.ApiId).HasColumnName("api_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("session_id");
            });

            modelBuilder.Entity<OchvAttribute>(entity =>
            {
                entity.HasKey(e => e.AttributeId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_attribute");

                entity.Property(e => e.AttributeId).HasColumnName("attribute_id");

                entity.Property(e => e.AttributeGroupId).HasColumnName("attribute_group_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OchvAttributeDescription>(entity =>
            {
                entity.HasKey(e => new { e.AttributeId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_attribute_description");

                entity.Property(e => e.AttributeId).HasColumnName("attribute_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OchvAttributeGroup>(entity =>
            {
                entity.HasKey(e => e.AttributeGroupId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_attribute_group");

                entity.Property(e => e.AttributeGroupId).HasColumnName("attribute_group_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OchvAttributeGroupDescription>(entity =>
            {
                entity.HasKey(e => new { e.AttributeGroupId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_attribute_group_description");

                entity.Property(e => e.AttributeGroupId).HasColumnName("attribute_group_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OchvBanner>(entity =>
            {
                entity.HasKey(e => e.BannerId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_banner");

                entity.Property(e => e.BannerId).HasColumnName("banner_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<OchvBannerImage>(entity =>
            {
                entity.HasKey(e => e.BannerImageId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_banner_image");

                entity.Property(e => e.BannerImageId).HasColumnName("banner_image_id");

                entity.Property(e => e.BannerId).HasColumnName("banner_id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Link)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("link");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<OchvBmAuthor>(entity =>
            {
                entity.HasKey(e => e.AuthorId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_bm_author");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.AuthorGroupId).HasColumnName("author_group_id");

                entity.Property(e => e.Custom)
                    .HasColumnName("custom")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Setting)
                    .IsRequired()
                    .HasColumnName("setting");

                entity.Property(e => e.UserId).HasColumnName("user_id");
            });

            modelBuilder.Entity<OchvBmAuthorDescription>(entity =>
            {
                entity.HasKey(e => e.AuthorDescriptionId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_bm_author_description");

                entity.Property(e => e.AuthorDescriptionId).HasColumnName("author_description_id");

                entity.Property(e => e.AuthorId).HasColumnName("author_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.MetaDescription)
                    .IsRequired()
                    .HasColumnName("meta_description");

                entity.Property(e => e.MetaKeyword)
                    .IsRequired()
                    .HasColumnName("meta_keyword");

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_title");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.ShortDescription)
                    .IsRequired()
                    .HasColumnName("short_description");
            });

            modelBuilder.Entity<OchvBmAuthorGroup>(entity =>
            {
                entity.HasKey(e => e.AuthorGroupId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_bm_author_group");

                entity.Property(e => e.AuthorGroupId).HasColumnName("author_group_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasColumnName("permission");
            });

            modelBuilder.Entity<OchvBmCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_bm_category");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Custom)
                    .HasColumnName("custom")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.LimitAccessUser).HasColumnName("limit_access_user");

                entity.Property(e => e.LimitAccessUserGroup).HasColumnName("limit_access_user_group");

                entity.Property(e => e.LimitUserGroups).HasColumnName("limit_user_groups");

                entity.Property(e => e.LimitUsers).HasColumnName("limit_users");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.Setting)
                    .IsRequired()
                    .HasColumnName("setting");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<OchvBmCategoryDescription>(entity =>
            {
                entity.HasKey(e => e.CategoryDescriptionId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_bm_category_description");

                entity.Property(e => e.CategoryDescriptionId).HasColumnName("category_description_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.MetaDescription)
                    .IsRequired()
                    .HasColumnName("meta_description");

                entity.Property(e => e.MetaKeyword)
                    .IsRequired()
                    .HasColumnName("meta_keyword");

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_title");

                entity.Property(e => e.ShortDescription)
                    .IsRequired()
                    .HasColumnName("short_description");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<OchvBmCategoryPath>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.PathId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_bm_category_path");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.PathId).HasColumnName("path_id");

                entity.Property(e => e.Level).HasColumnName("level");
            });

            modelBuilder.Entity<OchvBmCategoryToLayout>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ochv_bm_category_to_layout");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OchvBmCategoryToStore>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_bm_category_to_store");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OchvBmPost>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_bm_post");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Custom)
                    .HasColumnName("custom")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.DatePublished).HasColumnName("date_published");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.ImageAlt)
                    .HasMaxLength(255)
                    .HasColumnName("image_alt");

                entity.Property(e => e.ImageTitle)
                    .HasMaxLength(255)
                    .HasColumnName("image_title");

                entity.Property(e => e.ImagesReview)
                    .HasColumnName("images_review")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LimitAccessUser).HasColumnName("limit_access_user");

                entity.Property(e => e.LimitAccessUserGroup).HasColumnName("limit_access_user_group");

                entity.Property(e => e.LimitUserGroups).HasColumnName("limit_user_groups");

                entity.Property(e => e.LimitUsers).HasColumnName("limit_users");

                entity.Property(e => e.ReviewDisplay)
                    .HasColumnName("review_display")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Setting)
                    .IsRequired()
                    .HasColumnName("setting");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Viewed)
                    .HasColumnName("viewed")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<OchvBmPostDescription>(entity =>
            {
                entity.HasKey(e => e.PostDescriptionId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_bm_post_description");

                entity.Property(e => e.PostDescriptionId).HasColumnName("post_description_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.MetaDescription)
                    .IsRequired()
                    .HasColumnName("meta_description");

                entity.Property(e => e.MetaKeyword)
                    .IsRequired()
                    .HasColumnName("meta_keyword");

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_title");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.ReadTime)
                    .IsRequired()
                    .HasColumnName("read_time");

                entity.Property(e => e.ShortDescription)
                    .IsRequired()
                    .HasColumnName("short_description");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasColumnName("tag");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<OchvBmPostRelated>(entity =>
            {
                entity.HasKey(e => new { e.PostId, e.PostRelatedId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_bm_post_related");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.PostRelatedId).HasColumnName("post_related_id");
            });

            modelBuilder.Entity<OchvBmPostToCategory>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.PostId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_bm_post_to_category");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.MainCategory).HasColumnName("main_category");
            });

            modelBuilder.Entity<OchvBmPostToLayout>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ochv_bm_post_to_layout");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OchvBmPostToProduct>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.PostId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_bm_post_to_product");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");
            });

            modelBuilder.Entity<OchvBmPostToStore>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ochv_bm_post_to_store");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OchvBmPostVideo>(entity =>
            {
                entity.HasKey(e => new { e.PostId, e.Video })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_bm_post_video");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Video)
                    .HasMaxLength(255)
                    .HasColumnName("video");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("text");

                entity.Property(e => e.Width).HasColumnName("width");
            });

            modelBuilder.Entity<OchvBmReview>(entity =>
            {
                entity.HasKey(e => e.ReviewId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_bm_review");

                entity.Property(e => e.ReviewId).HasColumnName("review_id");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("author");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.GuestEmail)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("guest_email");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.ReplyToReviewId).HasColumnName("reply_to_review_id");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<OchvBmReviewToImage>(entity =>
            {
                entity.HasKey(e => new { e.ReviewId, e.Image })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_bm_review_to_image");

                entity.Property(e => e.ReviewId).HasColumnName("review_id");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");
            });

            modelBuilder.Entity<OchvCart>(entity =>
            {
                entity.HasKey(e => e.CartId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_cart");

                entity.HasIndex(e => new { e.ApiId, e.CustomerId, e.SessionId, e.ProductId, e.RecurringId }, "cart_id");

                entity.Property(e => e.CartId)
                    .HasColumnType("int unsigned")
                    .HasColumnName("cart_id");

                entity.Property(e => e.ApiId).HasColumnName("api_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Option)
                    .IsRequired()
                    .HasColumnName("option");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.RaidDateTime)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("raid_date_time");

                entity.Property(e => e.RaidDateTimeUser)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("raid_date_time_user");

                entity.Property(e => e.RaidTypeFaction)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("raid_type_faction");

                entity.Property(e => e.RecurringId).HasColumnName("recurring_id");

                entity.Property(e => e.Sale).HasColumnName("sale");

                entity.Property(e => e.SelectLevel).HasColumnName("select_level");

                entity.Property(e => e.SessionId)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("session_id");
            });

            modelBuilder.Entity<OchvCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_category");

                entity.HasIndex(e => e.ParentId, "parent_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.Column).HasColumnName("column");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.ParentId).HasColumnName("parent_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Top).HasColumnName("top");
            });

            modelBuilder.Entity<OchvCategoryDescription>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_category_description");

                entity.HasIndex(e => e.Name, "name");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Description1).HasColumnName("description1");

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasColumnName("description2");

                entity.Property(e => e.Description3)
                    .IsRequired()
                    .HasColumnName("description3");

                entity.Property(e => e.Description4)
                    .IsRequired()
                    .HasColumnName("description4");

                entity.Property(e => e.Description5)
                    .IsRequired()
                    .HasColumnName("description5");

                entity.Property(e => e.MetaDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_description");

                entity.Property(e => e.MetaKeyword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_keyword");

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_title");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Title1)
                    .HasMaxLength(55)
                    .HasColumnName("title1");

                entity.Property(e => e.Title2)
                    .HasMaxLength(55)
                    .HasColumnName("title2");

                entity.Property(e => e.Title3)
                    .HasMaxLength(55)
                    .HasColumnName("title3");

                entity.Property(e => e.Title4)
                    .HasMaxLength(55)
                    .HasColumnName("title4");

                entity.Property(e => e.Title5)
                    .HasMaxLength(55)
                    .HasColumnName("title5");
            });

            modelBuilder.Entity<OchvCategoryFilter>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.FilterId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_category_filter");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.FilterId).HasColumnName("filter_id");
            });

            modelBuilder.Entity<OchvCategoryPath>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.PathId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_category_path");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.PathId).HasColumnName("path_id");

                entity.Property(e => e.Level).HasColumnName("level");
            });

            modelBuilder.Entity<OchvCategoryToGoogleProductCategory>(entity =>
            {
                entity.HasKey(e => new { e.GoogleProductCategory, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_category_to_google_product_category");

                entity.HasIndex(e => new { e.CategoryId, e.StoreId }, "category_id_store_id");

                entity.Property(e => e.GoogleProductCategory)
                    .HasMaxLength(10)
                    .HasColumnName("google_product_category");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");
            });

            modelBuilder.Entity<OchvCategoryToLayout>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_category_to_layout");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");
            });

            modelBuilder.Entity<OchvCategoryToStore>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_category_to_store");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OchvCoinbaseCommerceOrder>(entity =>
            {
                entity.ToTable("ochv_coinbase_commerce_order");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CoinbaseCommerceChargeCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("coinbase_commerce_charge_code");

                entity.Property(e => e.CoinbaseCommerceCoinsExpected).HasColumnName("coinbase_commerce_coins_expected");

                entity.Property(e => e.CoinbaseCommerceCoinsReceived).HasColumnName("coinbase_commerce_coins_received");

                entity.Property(e => e.CoinbaseCommerceReceivedCurrency)
                    .IsRequired()
                    .HasColumnName("coinbase_commerce_received_currency");

                entity.Property(e => e.CoinbaseCommerceStatus).HasColumnName("coinbase_commerce_status");

                entity.Property(e => e.CoinbaseCommerceTransactionId)
                    .HasMaxLength(100)
                    .HasColumnName("coinbase_commerce_transaction_id");

                entity.Property(e => e.StoreOrderId).HasColumnName("store_order_id");

                entity.Property(e => e.StoreTotalAmount).HasColumnName("store_total_amount");
            });

            modelBuilder.Entity<OchvCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_country");

                entity.Property(e => e.CountryId).HasColumnName("country_id");

                entity.Property(e => e.AddressFormat)
                    .IsRequired()
                    .HasColumnName("address_format");

                entity.Property(e => e.IsoCode2)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("iso_code_2");

                entity.Property(e => e.IsoCode3)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("iso_code_3");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.PostcodeRequired).HasColumnName("postcode_required");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<OchvCoupon>(entity =>
            {
                entity.HasKey(e => e.CouponId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_coupon");

                entity.Property(e => e.CouponId).HasColumnName("coupon_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("code");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("date")
                    .HasColumnName("date_end")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DateStart)
                    .HasColumnType("date")
                    .HasColumnName("date_start")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("discount");

                entity.Property(e => e.Logged).HasColumnName("logged");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.Shipping).HasColumnName("shipping");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("total");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("type")
                    .IsFixedLength(true);

                entity.Property(e => e.UsesCustomer)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("uses_customer");

                entity.Property(e => e.UsesTotal).HasColumnName("uses_total");
            });

            modelBuilder.Entity<OchvCouponCategory>(entity =>
            {
                entity.HasKey(e => new { e.CouponId, e.CategoryId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_coupon_category");

                entity.Property(e => e.CouponId).HasColumnName("coupon_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");
            });

            modelBuilder.Entity<OchvCouponHistory>(entity =>
            {
                entity.HasKey(e => e.CouponHistoryId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_coupon_history");

                entity.Property(e => e.CouponHistoryId).HasColumnName("coupon_history_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("amount");

                entity.Property(e => e.CouponId).HasColumnName("coupon_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.OrderId).HasColumnName("order_id");
            });

            modelBuilder.Entity<OchvCouponProduct>(entity =>
            {
                entity.HasKey(e => e.CouponProductId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_coupon_product");

                entity.Property(e => e.CouponProductId).HasColumnName("coupon_product_id");

                entity.Property(e => e.CouponId).HasColumnName("coupon_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<OchvCron>(entity =>
            {
                entity.HasKey(e => e.CronId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_cron");

                entity.Property(e => e.CronId).HasColumnName("cron_id");

                entity.Property(e => e.Action)
                    .IsRequired()
                    .HasColumnName("action");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("code");

                entity.Property(e => e.Cycle)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("cycle");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<OchvCurrency>(entity =>
            {
                entity.HasKey(e => e.CurrencyId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_currency");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("code");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.DecimalPlace)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("decimal_place")
                    .IsFixedLength(true);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SymbolLeft)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("symbol_left");

                entity.Property(e => e.SymbolRight)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("symbol_right");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("title");

                entity.Property(e => e.Value)
                    .HasColumnType("double(15,8)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OchvCustomField>(entity =>
            {
                entity.HasKey(e => e.CustomFieldId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_custom_field");

                entity.Property(e => e.CustomFieldId).HasColumnName("custom_field_id");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("location");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("type");

                entity.Property(e => e.Validation)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("validation");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OchvCustomFieldCustomerGroup>(entity =>
            {
                entity.HasKey(e => new { e.CustomFieldId, e.CustomerGroupId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_custom_field_customer_group");

                entity.Property(e => e.CustomFieldId).HasColumnName("custom_field_id");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.Required).HasColumnName("required");
            });

            modelBuilder.Entity<OchvCustomFieldDescription>(entity =>
            {
                entity.HasKey(e => new { e.CustomFieldId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_custom_field_description");

                entity.Property(e => e.CustomFieldId).HasColumnName("custom_field_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OchvCustomFieldValue>(entity =>
            {
                entity.HasKey(e => e.CustomFieldValueId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_custom_field_value");

                entity.Property(e => e.CustomFieldValueId).HasColumnName("custom_field_value_id");

                entity.Property(e => e.CustomFieldId).HasColumnName("custom_field_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OchvCustomFieldValueDescription>(entity =>
            {
                entity.HasKey(e => new { e.CustomFieldValueId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_custom_field_value_description");

                entity.Property(e => e.CustomFieldValueId).HasColumnName("custom_field_value_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.CustomFieldId).HasColumnName("custom_field_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OchvCustomer>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_customer");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.AddressId).HasColumnName("address_id");

                entity.Property(e => e.Cart).HasColumnName("cart");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("code");

                entity.Property(e => e.CustomField)
                    .IsRequired()
                    .HasColumnName("custom_field");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("email");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("fax");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("firstname");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("lastname");

                entity.Property(e => e.Newsletter).HasColumnName("newsletter");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("password");

                entity.Property(e => e.ProfileImage)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("profile_image");

                entity.Property(e => e.Safe).HasColumnName("safe");

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("salt");

                entity.Property(e => e.Socnetauth2Data)
                    .IsRequired()
                    .HasColumnName("socnetauth2_data");

                entity.Property(e => e.Socnetauth2Identity)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("socnetauth2_identity");

                entity.Property(e => e.Socnetauth2Link)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("socnetauth2_link");

                entity.Property(e => e.Socnetauth2Provider)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("socnetauth2_provider");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("telephone");

                entity.Property(e => e.Token)
                    .IsRequired()
                    .HasColumnName("token");

                entity.Property(e => e.Wishlist).HasColumnName("wishlist");
            });

            modelBuilder.Entity<OchvCustomerActivity>(entity =>
            {
                entity.HasKey(e => e.CustomerActivityId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_customer_activity");

                entity.Property(e => e.CustomerActivityId).HasColumnName("customer_activity_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("key");
            });

            modelBuilder.Entity<OchvCustomerAffiliate>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_customer_affiliate");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.BankAccountName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("bank_account_name");

                entity.Property(e => e.BankAccountNumber)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("bank_account_number");

                entity.Property(e => e.BankBranchNumber)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("bank_branch_number");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("bank_name");

                entity.Property(e => e.BankSwiftCode)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("bank_swift_code");

                entity.Property(e => e.Cheque)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("cheque");

                entity.Property(e => e.Commission)
                    .HasColumnType("decimal(4,2)")
                    .HasColumnName("commission");

                entity.Property(e => e.Company)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("company");

                entity.Property(e => e.CustomField)
                    .IsRequired()
                    .HasColumnName("custom_field");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Payment)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasColumnName("payment");

                entity.Property(e => e.Paypal)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("paypal");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Tax)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("tax");

                entity.Property(e => e.Tracking)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("tracking");

                entity.Property(e => e.Website)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("website");
            });

            modelBuilder.Entity<OchvCustomerApproval>(entity =>
            {
                entity.HasKey(e => e.CustomerApprovalId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_customer_approval");

                entity.Property(e => e.CustomerApprovalId).HasColumnName("customer_approval_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<OchvCustomerAuthentication>(entity =>
            {
                entity.HasKey(e => e.CustomerAuthenticationId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_customer_authentication");

                entity.HasIndex(e => new { e.Identifier, e.Provider }, "identifier")
                    .IsUnique();

                entity.Property(e => e.CustomerAuthenticationId).HasColumnName("customer_authentication_id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("address");

                entity.Property(e => e.Age)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("age");

                entity.Property(e => e.BirthDay)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("birth_day");

                entity.Property(e => e.BirthMonth)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("birth_month");

                entity.Property(e => e.BirthYear)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("birth_year");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("city");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("country");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("display_name");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.EmailVerified)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("email_verified");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("first_name");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("gender");

                entity.Property(e => e.Identifier)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("identifier");

                entity.Property(e => e.Language)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("language");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("last_name");

                entity.Property(e => e.PhotoUrl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("photo_url");

                entity.Property(e => e.ProfileUrl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("profile_url");

                entity.Property(e => e.Provider)
                    .IsRequired()
                    .HasMaxLength(55)
                    .HasColumnName("provider");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("region");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("telephone");

                entity.Property(e => e.WebSiteUrl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("web_site_url");

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("zip");
            });

            modelBuilder.Entity<OchvCustomerGroup>(entity =>
            {
                entity.HasKey(e => e.CustomerGroupId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_customer_group");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.Approval).HasColumnName("approval");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OchvCustomerGroupDescription>(entity =>
            {
                entity.HasKey(e => new { e.CustomerGroupId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_customer_group_description");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OchvCustomerHistory>(entity =>
            {
                entity.HasKey(e => e.CustomerHistoryId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_customer_history");

                entity.Property(e => e.CustomerHistoryId).HasColumnName("customer_history_id");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");
            });

            modelBuilder.Entity<OchvCustomerIp>(entity =>
            {
                entity.HasKey(e => e.CustomerIpId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_customer_ip");

                entity.HasIndex(e => e.Ip, "ip");

                entity.Property(e => e.CustomerIpId).HasColumnName("customer_ip_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");
            });

            modelBuilder.Entity<OchvCustomerLogin>(entity =>
            {
                entity.HasKey(e => e.CustomerLoginId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_customer_login");

                entity.HasIndex(e => e.Email, "email");

                entity.HasIndex(e => e.Ip, "ip");

                entity.Property(e => e.CustomerLoginId).HasColumnName("customer_login_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("email");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.Total).HasColumnName("total");
            });

            modelBuilder.Entity<OchvCustomerOnline>(entity =>
            {
                entity.HasKey(e => e.Ip)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_customer_online");

                entity.Property(e => e.Ip)
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Referer)
                    .IsRequired()
                    .HasColumnName("referer");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url");
            });

            modelBuilder.Entity<OchvCustomerReward>(entity =>
            {
                entity.HasKey(e => e.CustomerRewardId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_customer_reward");

                entity.Property(e => e.CustomerRewardId).HasColumnName("customer_reward_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Points)
                    .HasColumnType("decimal(15,2)")
                    .HasColumnName("points");
            });

            modelBuilder.Entity<OchvCustomerSearch>(entity =>
            {
                entity.HasKey(e => e.CustomerSearchId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_customer_search");

                entity.Property(e => e.CustomerSearchId).HasColumnName("customer_search_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("keyword");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Products).HasColumnName("products");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.SubCategory).HasColumnName("sub_category");
            });

            modelBuilder.Entity<OchvCustomerTransaction>(entity =>
            {
                entity.HasKey(e => e.CustomerTransactionId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_customer_transaction");

                entity.Property(e => e.CustomerTransactionId).HasColumnName("customer_transaction_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("amount");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.OrderId).HasColumnName("order_id");
            });

            modelBuilder.Entity<OchvCustomerWishlist>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.ProductId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_customer_wishlist");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");
            });

            modelBuilder.Entity<OchvDGdprCookie>(entity =>
            {
                entity.ToTable("ochv_d_gdpr_cookie");

                entity.HasIndex(e => e.CustomerId, "no_duplicate")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AcceptDate).HasColumnName("accept_date");

                entity.Property(e => e.AcceptLanguageId)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("accept_language_id")
                    .IsFixedLength(true);

                entity.Property(e => e.Accepted)
                    .HasColumnType("tinyint")
                    .HasColumnName("accepted");

                entity.Property(e => e.CookieExtra)
                    .IsRequired()
                    .HasColumnName("cookie_extra");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DeclineDate).HasColumnName("decline_date");

                entity.Property(e => e.UserAgent)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("user_agent");
            });

            modelBuilder.Entity<OchvDGdprPolicy>(entity =>
            {
                entity.ToTable("ochv_d_gdpr_policy");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("content");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Date).HasColumnName("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("email");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("name");

                entity.Property(e => e.PolicyId).HasColumnName("policy_id");
            });

            modelBuilder.Entity<OchvDGdprRequest>(entity =>
            {
                entity.ToTable("ochv_d_gdpr_request");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Confirmed)
                    .HasColumnType("tinyint")
                    .HasColumnName("confirmed");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("email");

                entity.Property(e => e.RequestDate).HasColumnName("request_date");

                entity.Property(e => e.RequestKey)
                    .IsRequired()
                    .HasColumnName("request_key");

                entity.Property(e => e.RequestType)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("request_type")
                    .IsFixedLength(true);

                entity.Property(e => e.UserAgent)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("user_agent");
            });

            modelBuilder.Entity<OchvDGdprRestrict>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_gdpr_restrict");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint")
                    .HasColumnName("status");
            });

            modelBuilder.Entity<OchvDMetaDatum>(entity =>
            {
                entity.HasKey(e => new { e.Route, e.StoreId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_meta_data");

                entity.Property(e => e.Route)
                    .HasMaxLength(255)
                    .HasColumnName("route");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.CustomImageAlt)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("custom_image_alt");

                entity.Property(e => e.CustomImageTitle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("custom_image_title");

                entity.Property(e => e.CustomTitle1)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("custom_title_1");

                entity.Property(e => e.CustomTitle2)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("custom_title_2");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.MetaDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_description");

                entity.Property(e => e.MetaKeyword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_keyword");

                entity.Property(e => e.MetaRobots)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("meta_robots")
                    .HasDefaultValueSql("'index,follow'");

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_title");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.ShortDescription)
                    .IsRequired()
                    .HasColumnName("short_description");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasColumnName("tag");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<OchvDNewsletterAffiliate>(entity =>
            {
                entity.HasKey(e => new { e.AffiliateId, e.LanguageId, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_newsletter_affiliate");

                entity.Property(e => e.AffiliateId).HasColumnName("affiliate_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OchvDNewsletterCustomer>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_newsletter_customer");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OchvDNewsletterHistoryEmailCustomer>(entity =>
            {
                entity.HasKey(e => e.Email)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_newsletter_history_email_customer");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");
            });

            modelBuilder.Entity<OchvDNewsletterHistoryTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_newsletter_history_template");

                entity.Property(e => e.TemplateId).HasColumnName("template_id");

                entity.Property(e => e.CampaignName)
                    .HasMaxLength(255)
                    .HasColumnName("campaign_name");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(32)
                    .HasColumnName("currency_code");

                entity.Property(e => e.DateSend).HasColumnName("date_send");

                entity.Property(e => e.LimitBestseller).HasColumnName("limit_bestseller");

                entity.Property(e => e.LimitCategory).HasColumnName("limit_category");

                entity.Property(e => e.LimitLatest).HasColumnName("limit_latest");

                entity.Property(e => e.LimitMissing).HasColumnName("limit_missing");

                entity.Property(e => e.LimitRelated).HasColumnName("limit_related");

                entity.Property(e => e.LimitSpecial).HasColumnName("limit_special");

                entity.Property(e => e.SenderEmail)
                    .HasMaxLength(255)
                    .HasColumnName("sender_email");

                entity.Property(e => e.SenderName)
                    .HasMaxLength(255)
                    .HasColumnName("sender_name");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<OchvDNewsletterHistoryTemplateCategory>(entity =>
            {
                entity.HasKey(e => new { e.TemplateId, e.CategoryId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_newsletter_history_template_category");

                entity.Property(e => e.TemplateId).HasColumnName("template_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");
            });

            modelBuilder.Entity<OchvDNewsletterHistoryTemplateDescription>(entity =>
            {
                entity.HasKey(e => new { e.TemplateId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_newsletter_history_template_description");

                entity.Property(e => e.TemplateId).HasColumnName("template_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.Subject)
                    .HasMaxLength(255)
                    .HasColumnName("subject");
            });

            modelBuilder.Entity<OchvDNewsletterHistoryTemplateEmail>(entity =>
            {
                entity.HasKey(e => new { e.TemplateId, e.Email })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_newsletter_history_template_email");

                entity.Property(e => e.TemplateId).HasColumnName("template_id");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(255)
                    .HasColumnName("firstname");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(255)
                    .HasColumnName("lastname");

                entity.Property(e => e.Send).HasColumnName("send");

                entity.Property(e => e.SiteVisited)
                    .HasMaxLength(255)
                    .HasColumnName("site_visited");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.View)
                    .HasMaxLength(255)
                    .HasColumnName("view");
            });

            modelBuilder.Entity<OchvDNewsletterHistoryTemplateProduct>(entity =>
            {
                entity.HasKey(e => new { e.TemplateId, e.ProductId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_newsletter_history_template_product");

                entity.Property(e => e.TemplateId).HasColumnName("template_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<OchvDNewsletterSubscriber>(entity =>
            {
                entity.HasKey(e => e.SubscriberId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_newsletter_subscriber");

                entity.Property(e => e.SubscriberId).HasColumnName("subscriber_id");

                entity.Property(e => e.Birthday)
                    .HasColumnType("date")
                    .HasColumnName("birthday");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(32)
                    .HasColumnName("firstname");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(32)
                    .HasColumnName("lastname");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.Subscribed).HasColumnName("subscribed");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(255)
                    .HasColumnName("telephone");
            });

            modelBuilder.Entity<OchvDNewsletterSubscriberGroup>(entity =>
            {
                entity.HasKey(e => e.SubscriberGroupId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_newsletter_subscriber_group");

                entity.Property(e => e.SubscriberGroupId).HasColumnName("subscriber_group_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OchvDNewsletterSubscriberGroupDescription>(entity =>
            {
                entity.HasKey(e => new { e.SubscriberGroupId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_newsletter_subscriber_group_description");

                entity.Property(e => e.SubscriberGroupId).HasColumnName("subscriber_group_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OchvDNewsletterSubscriberToSubscriberGroup>(entity =>
            {
                entity.HasKey(e => new { e.SubscriberId, e.SubscriberGroupId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_newsletter_subscriber_to_subscriber_group");

                entity.Property(e => e.SubscriberId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("subscriber_id");

                entity.Property(e => e.SubscriberGroupId).HasColumnName("subscriber_group_id");
            });

            modelBuilder.Entity<OchvDNewsletterTask>(entity =>
            {
                entity.HasKey(e => e.TaskId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_newsletter_task");

                entity.Property(e => e.TaskId).HasColumnName("task_id");

                entity.Property(e => e.Addressees)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("addressees");

                entity.Property(e => e.CountDay).HasColumnName("count_day");

                entity.Property(e => e.DateMode).HasColumnName("date_mode");

                entity.Property(e => e.DateSend).HasColumnName("date_send");

                entity.Property(e => e.Filter)
                    .IsRequired()
                    .HasColumnName("filter");

                entity.Property(e => e.LatestSend)
                    .HasColumnType("date")
                    .HasColumnName("latest_send");

                entity.Property(e => e.SendMode).HasColumnName("send_mode");

                entity.Property(e => e.TemplateId).HasColumnName("template_id");
            });

            modelBuilder.Entity<OchvDNewsletterTaskDescription>(entity =>
            {
                entity.HasKey(e => new { e.TaskId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_newsletter_task_description");

                entity.Property(e => e.TaskId).HasColumnName("task_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OchvDNewsletterTemplate>(entity =>
            {
                entity.HasKey(e => e.TemplateId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_newsletter_template");

                entity.Property(e => e.TemplateId).HasColumnName("template_id");

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(32)
                    .HasColumnName("currency_code");

                entity.Property(e => e.LimitBestseller).HasColumnName("limit_bestseller");

                entity.Property(e => e.LimitCategory).HasColumnName("limit_category");

                entity.Property(e => e.LimitLatest).HasColumnName("limit_latest");

                entity.Property(e => e.LimitMissing).HasColumnName("limit_missing");

                entity.Property(e => e.LimitRelated).HasColumnName("limit_related");

                entity.Property(e => e.LimitSpecial).HasColumnName("limit_special");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OchvDNewsletterTemplateCategory>(entity =>
            {
                entity.HasKey(e => new { e.TemplateId, e.CategoryId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_newsletter_template_category");

                entity.Property(e => e.TemplateId).HasColumnName("template_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");
            });

            modelBuilder.Entity<OchvDNewsletterTemplateDescription>(entity =>
            {
                entity.HasKey(e => new { e.TemplateId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_newsletter_template_description");

                entity.Property(e => e.TemplateId).HasColumnName("template_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.Subject)
                    .HasMaxLength(255)
                    .HasColumnName("subject");
            });

            modelBuilder.Entity<OchvDNewsletterTemplateProduct>(entity =>
            {
                entity.HasKey(e => new { e.TemplateId, e.ProductId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_newsletter_template_product");

                entity.Property(e => e.TemplateId).HasColumnName("template_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<OchvDPostCategory>(entity =>
            {
                entity.HasKey(e => e.PostId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_post_category");

                entity.Property(e => e.PostId).HasColumnName("post_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");
            });

            modelBuilder.Entity<OchvDProductCategory>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_product_category");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");
            });

            modelBuilder.Entity<OchvDRank>(entity =>
            {
                entity.HasKey(e => e.CustomerGroupId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_ranks");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.RankName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("rank_name");

                entity.Property(e => e.RankStatus).HasColumnName("rank_status");

                entity.Property(e => e.SumToUp).HasColumnName("sum_to_up");
            });

            modelBuilder.Entity<OchvDRefreshPage>(entity =>
            {
                entity.HasKey(e => e.PageId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_refresh_page");

                entity.Property(e => e.PageId).HasColumnName("page_id");

                entity.Property(e => e.PageKey)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("page_key");
            });

            modelBuilder.Entity<OchvDTargetKeyword>(entity =>
            {
                entity.HasKey(e => new { e.Route, e.StoreId, e.LanguageId, e.SortOrder })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_target_keyword");

                entity.HasIndex(e => e.Keyword, "keyword");

                entity.Property(e => e.Route)
                    .HasMaxLength(255)
                    .HasColumnName("route");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("keyword");
            });

            modelBuilder.Entity<OchvDUrlRedirect>(entity =>
            {
                entity.HasKey(e => e.UrlRedirectId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_url_redirect");

                entity.HasIndex(e => e.UrlFrom, "url_from");

                entity.Property(e => e.UrlRedirectId).HasColumnName("url_redirect_id");

                entity.Property(e => e.UrlFrom)
                    .IsRequired()
                    .HasMaxLength(512)
                    .HasColumnName("url_from");

                entity.Property(e => e.UrlTo2)
                    .IsRequired()
                    .HasMaxLength(512)
                    .HasColumnName("url_to_2");
            });

            modelBuilder.Entity<OchvDValidator>(entity =>
            {
                entity.HasKey(e => e.ValidatorId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_d_validator");

                entity.Property(e => e.ValidatorId).HasColumnName("validator_id");

                entity.Property(e => e.Codename)
                    .IsRequired()
                    .HasMaxLength(191)
                    .HasColumnName("codename");

                entity.Property(e => e.DateCreated).HasColumnName("date_created");

                entity.Property(e => e.DateShow).HasColumnName("date_show");
            });

            modelBuilder.Entity<OchvDownload>(entity =>
            {
                entity.HasKey(e => e.DownloadId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_download");

                entity.Property(e => e.DownloadId).HasColumnName("download_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Filename)
                    .IsRequired()
                    .HasMaxLength(160)
                    .HasColumnName("filename");

                entity.Property(e => e.Mask)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("mask");
            });

            modelBuilder.Entity<OchvDownloadDescription>(entity =>
            {
                entity.HasKey(e => new { e.DownloadId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_download_description");

                entity.Property(e => e.DownloadId).HasColumnName("download_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OchvDqcSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_dqc_setting");

                entity.Property(e => e.SettingId).HasColumnName("setting_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OchvDqcSettingDatum>(entity =>
            {
                entity.HasKey(e => new { e.SettingId, e.Key })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_dqc_setting_data");

                entity.Property(e => e.SettingId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("setting_id");

                entity.Property(e => e.Key)
                    .HasMaxLength(32)
                    .HasColumnName("key");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OchvDqcStatistic>(entity =>
            {
                entity.HasKey(e => e.StatisticId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_dqc_statistic");

                entity.Property(e => e.StatisticId).HasColumnName("statistic_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.SettingId).HasColumnName("setting_id");
            });

            modelBuilder.Entity<OchvEbDashboardEnqury>(entity =>
            {
                entity.HasKey(e => e.EbDashboardEnquriesId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_eb_dashboard_enquries");

                entity.Property(e => e.EbDashboardEnquriesId).HasColumnName("eb_dashboard_enquries_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email");

                entity.Property(e => e.Enquiry).HasColumnName("enquiry");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OchvFilter>(entity =>
            {
                entity.HasKey(e => e.FilterId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_filter");

                entity.Property(e => e.FilterId).HasColumnName("filter_id");

                entity.Property(e => e.FilterGroupId).HasColumnName("filter_group_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OchvFilterDescription>(entity =>
            {
                entity.HasKey(e => new { e.FilterId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_filter_description");

                entity.Property(e => e.FilterId).HasColumnName("filter_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.FilterGroupId).HasColumnName("filter_group_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OchvFilterGroup>(entity =>
            {
                entity.HasKey(e => e.FilterGroupId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_filter_group");

                entity.Property(e => e.FilterGroupId).HasColumnName("filter_group_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OchvFilterGroupDescription>(entity =>
            {
                entity.HasKey(e => new { e.FilterGroupId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_filter_group_description");

                entity.Property(e => e.FilterGroupId).HasColumnName("filter_group_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OchvGiftCouponsEmailList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ochv_gift_coupons_email_list");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(55)
                    .HasColumnName("email");

                entity.Property(e => e.IsSend).HasColumnName("isSend");
            });

            modelBuilder.Entity<OchvIeEmailSended>(entity =>
            {
                entity.ToTable("ochv_ie_email_sended");

                entity.HasIndex(e => e.OrderId, "orderid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("orderId");
            });

            modelBuilder.Entity<OchvInformation>(entity =>
            {
                entity.HasKey(e => e.InformationId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_information");

                entity.Property(e => e.InformationId).HasColumnName("information_id");

                entity.Property(e => e.Bottom).HasColumnName("bottom");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<OchvInformationDescription>(entity =>
            {
                entity.HasKey(e => new { e.InformationId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_information_description");

                entity.Property(e => e.InformationId).HasColumnName("information_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("mediumtext")
                    .HasColumnName("description");

                entity.Property(e => e.MetaDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_description");

                entity.Property(e => e.MetaKeyword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_keyword");

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_title");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<OchvInformationToLayout>(entity =>
            {
                entity.HasKey(e => new { e.InformationId, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_information_to_layout");

                entity.Property(e => e.InformationId).HasColumnName("information_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");
            });

            modelBuilder.Entity<OchvLanguage>(entity =>
            {
                entity.HasKey(e => e.LanguageId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_language");

                entity.HasIndex(e => e.Name, "name");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("code");

                entity.Property(e => e.Directory)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("directory");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("image");

                entity.Property(e => e.Locale)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("locale");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<OchvLayout>(entity =>
            {
                entity.HasKey(e => e.LayoutId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_layout");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OchvLayoutModule>(entity =>
            {
                entity.HasKey(e => e.LayoutModuleId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_layout_module");

                entity.Property(e => e.LayoutModuleId).HasColumnName("layout_module_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("code");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(14)
                    .HasColumnName("position");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OchvLayoutRoute>(entity =>
            {
                entity.HasKey(e => e.LayoutRouteId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_layout_route");

                entity.Property(e => e.LayoutRouteId).HasColumnName("layout_route_id");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");

                entity.Property(e => e.Route)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("route");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OchvOption>(entity =>
            {
                entity.HasKey(e => e.OptionId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_option");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.LimitCheckbox).HasColumnName("limit_checkbox");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<OchvOptionDescription>(entity =>
            {
                entity.HasKey(e => new { e.OptionId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_option_description");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.MainOptionTooltip)
                    .IsRequired()
                    .HasMaxLength(550)
                    .HasColumnName("main_option_tooltip");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(5000)")
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OchvOptionValue>(entity =>
            {
                entity.HasKey(e => e.OptionValueId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_option_value");

                entity.Property(e => e.OptionValueId).HasColumnName("option_value_id");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OchvOptionValueDescription>(entity =>
            {
                entity.HasKey(e => new { e.OptionValueId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_option_value_description");

                entity.Property(e => e.OptionValueId).HasColumnName("option_value_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(5000)")
                    .HasColumnName("name");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.OptionTooltip)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("option_tooltip");
            });

            modelBuilder.Entity<OchvOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_order");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.AcceptLanguage)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("accept_language");

                entity.Property(e => e.AffiliateId).HasColumnName("affiliate_id");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.Commission)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("commission");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("currency_code");

                entity.Property(e => e.CurrencyId).HasColumnName("currency_id");

                entity.Property(e => e.CurrencyValue)
                    .HasColumnType("decimal(15,8)")
                    .HasColumnName("currency_value")
                    .HasDefaultValueSql("'1.00000000'");

                entity.Property(e => e.CustomField)
                    .IsRequired()
                    .HasColumnName("custom_field");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.DateSendEmail)
                    .HasColumnName("date_send_email")
                    .HasDefaultValueSql("'1970-01-01 00:00:00'");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("email");

                entity.Property(e => e.Fax)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("fax");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("firstname");

                entity.Property(e => e.ForwardedIp)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("forwarded_ip");

                entity.Property(e => e.InvoiceNo).HasColumnName("invoice_no");

                entity.Property(e => e.InvoicePrefix)
                    .IsRequired()
                    .HasMaxLength(26)
                    .HasColumnName("invoice_prefix");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("lastname");

                entity.Property(e => e.MarketingId).HasColumnName("marketing_id");

                entity.Property(e => e.OrderStatusId).HasColumnName("order_status_id");

                entity.Property(e => e.PaymentAddress1)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("payment_address_1");

                entity.Property(e => e.PaymentAddress2)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("payment_address_2");

                entity.Property(e => e.PaymentAddressFormat)
                    .IsRequired()
                    .HasColumnName("payment_address_format");

                entity.Property(e => e.PaymentCity)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("payment_city");

                entity.Property(e => e.PaymentCode)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("payment_code");

                entity.Property(e => e.PaymentCompany)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("payment_company");

                entity.Property(e => e.PaymentCountry)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("payment_country");

                entity.Property(e => e.PaymentCountryId).HasColumnName("payment_country_id");

                entity.Property(e => e.PaymentCustomField)
                    .IsRequired()
                    .HasColumnName("payment_custom_field");

                entity.Property(e => e.PaymentFirstname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("payment_firstname");

                entity.Property(e => e.PaymentLastname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("payment_lastname");

                entity.Property(e => e.PaymentMethod)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("payment_method");

                entity.Property(e => e.PaymentPostcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("payment_postcode");

                entity.Property(e => e.PaymentZone)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("payment_zone");

                entity.Property(e => e.PaymentZoneId).HasColumnName("payment_zone_id");

                entity.Property(e => e.SendEmail).HasColumnName("send_email");

                entity.Property(e => e.ShippingAddress1)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("shipping_address_1");

                entity.Property(e => e.ShippingAddress2)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("shipping_address_2");

                entity.Property(e => e.ShippingAddressFormat)
                    .IsRequired()
                    .HasColumnName("shipping_address_format");

                entity.Property(e => e.ShippingCity)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("shipping_city");

                entity.Property(e => e.ShippingCode)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("shipping_code");

                entity.Property(e => e.ShippingCompany)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("shipping_company");

                entity.Property(e => e.ShippingCountry)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("shipping_country");

                entity.Property(e => e.ShippingCountryId).HasColumnName("shipping_country_id");

                entity.Property(e => e.ShippingCustomField)
                    .IsRequired()
                    .HasColumnName("shipping_custom_field");

                entity.Property(e => e.ShippingFirstname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("shipping_firstname");

                entity.Property(e => e.ShippingLastname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("shipping_lastname");

                entity.Property(e => e.ShippingMethod)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("shipping_method");

                entity.Property(e => e.ShippingPostcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("shipping_postcode");

                entity.Property(e => e.ShippingZone)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("shipping_zone");

                entity.Property(e => e.ShippingZoneId).HasColumnName("shipping_zone_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.StoreName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("store_name");

                entity.Property(e => e.StoreUrl)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("store_url");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("telephone");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("total");

                entity.Property(e => e.Tracking)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("tracking");

                entity.Property(e => e.UserAgent)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("user_agent");
            });

            modelBuilder.Entity<OchvOrderHistory>(entity =>
            {
                entity.HasKey(e => e.OrderHistoryId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_order_history");

                entity.Property(e => e.OrderHistoryId).HasColumnName("order_history_id");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Notify).HasColumnName("notify");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.OrderStatusId).HasColumnName("order_status_id");
            });

            modelBuilder.Entity<OchvOrderOption>(entity =>
            {
                entity.HasKey(e => e.OrderOptionId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_order_option");

                entity.Property(e => e.OrderOptionId).HasColumnName("order_option_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.OrderProductId).HasColumnName("order_product_id");

                entity.Property(e => e.ProductOptionId).HasColumnName("product_option_id");

                entity.Property(e => e.ProductOptionValueId).HasColumnName("product_option_value_id");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("type");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OchvOrderProduct>(entity =>
            {
                entity.HasKey(e => e.OrderProductId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_order_product");

                entity.HasIndex(e => e.OrderId, "order_id");

                entity.Property(e => e.OrderProductId).HasColumnName("order_product_id");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("model");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("price");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.RaidDateTime)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("raid_date_time");

                entity.Property(e => e.RaidDateTimeUser)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("raid_date_time_user");

                entity.Property(e => e.RaidTypeFaction)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("raid_type_faction");

                entity.Property(e => e.Reward)
                    .HasColumnType("decimal(15,2)")
                    .HasColumnName("reward");

                entity.Property(e => e.SelectLevel).HasColumnName("select_level");

                entity.Property(e => e.Tax)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("tax");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("total");
            });

            modelBuilder.Entity<OchvOrderRecurring>(entity =>
            {
                entity.HasKey(e => e.OrderRecurringId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_order_recurring");

                entity.Property(e => e.OrderRecurringId).HasColumnName("order_recurring_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("product_name");

                entity.Property(e => e.ProductQuantity).HasColumnName("product_quantity");

                entity.Property(e => e.RecurringCycle).HasColumnName("recurring_cycle");

                entity.Property(e => e.RecurringDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("recurring_description");

                entity.Property(e => e.RecurringDuration).HasColumnName("recurring_duration");

                entity.Property(e => e.RecurringFrequency)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("recurring_frequency");

                entity.Property(e => e.RecurringId).HasColumnName("recurring_id");

                entity.Property(e => e.RecurringName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("recurring_name");

                entity.Property(e => e.RecurringPrice)
                    .HasColumnType("decimal(10,4)")
                    .HasColumnName("recurring_price");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("reference");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint")
                    .HasColumnName("status");

                entity.Property(e => e.Trial).HasColumnName("trial");

                entity.Property(e => e.TrialCycle).HasColumnName("trial_cycle");

                entity.Property(e => e.TrialDuration).HasColumnName("trial_duration");

                entity.Property(e => e.TrialFrequency)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("trial_frequency");

                entity.Property(e => e.TrialPrice)
                    .HasColumnType("decimal(10,4)")
                    .HasColumnName("trial_price");
            });

            modelBuilder.Entity<OchvOrderRecurringTransaction>(entity =>
            {
                entity.HasKey(e => e.OrderRecurringTransactionId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_order_recurring_transaction");

                entity.Property(e => e.OrderRecurringTransactionId).HasColumnName("order_recurring_transaction_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(10,4)")
                    .HasColumnName("amount");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.OrderRecurringId).HasColumnName("order_recurring_id");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("reference");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<OchvOrderShipment>(entity =>
            {
                entity.HasKey(e => e.OrderShipmentId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_order_shipment");

                entity.Property(e => e.OrderShipmentId).HasColumnName("order_shipment_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ShippingCourierId)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("shipping_courier_id")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TrackingNumber)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("tracking_number")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<OchvOrderStatus>(entity =>
            {
                entity.HasKey(e => new { e.OrderStatusId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_order_status");

                entity.Property(e => e.OrderStatusId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("order_status_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OchvOrderTotal>(entity =>
            {
                entity.HasKey(e => e.OrderTotalId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_order_total");

                entity.HasIndex(e => e.OrderId, "order_id");

                entity.Property(e => e.OrderTotalId).HasColumnName("order_total_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("code");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.Value)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OchvOrderVoucher>(entity =>
            {
                entity.HasKey(e => e.OrderVoucherId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_order_voucher");

                entity.Property(e => e.OrderVoucherId).HasColumnName("order_voucher_id");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("amount");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("code");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.FromEmail)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("from_email");

                entity.Property(e => e.FromName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("from_name");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.ToEmail)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("to_email");

                entity.Property(e => e.ToName)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("to_name");

                entity.Property(e => e.VoucherId).HasColumnName("voucher_id");

                entity.Property(e => e.VoucherThemeId).HasColumnName("voucher_theme_id");
            });

            modelBuilder.Entity<OchvProduct>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_product");

                entity.HasIndex(e => e.AfTags, "af_tags");

                entity.HasIndex(e => e.AfValues, "af_values");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.AccessSupportAgents)
                    .HasColumnType("tinyint")
                    .HasColumnName("access_support_agents");

                entity.Property(e => e.AfTags)
                    .HasColumnType("text")
                    .HasColumnName("af_tags");

                entity.Property(e => e.AfValues)
                    .HasColumnType("text")
                    .HasColumnName("af_values");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateAvailable)
                    .HasColumnType("date")
                    .HasColumnName("date_available")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.Ean)
                    .IsRequired()
                    .HasMaxLength(14)
                    .HasColumnName("ean");

                entity.Property(e => e.Height)
                    .HasColumnType("decimal(15,8)")
                    .HasColumnName("height");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.Isbn)
                    .IsRequired()
                    .HasMaxLength(17)
                    .HasColumnName("isbn");

                entity.Property(e => e.Jan)
                    .IsRequired()
                    .HasMaxLength(13)
                    .HasColumnName("jan");

                entity.Property(e => e.Length)
                    .HasColumnType("decimal(15,8)")
                    .HasColumnName("length");

                entity.Property(e => e.LengthClassId).HasColumnName("length_class_id");

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("location");

                entity.Property(e => e.ManufacturerId).HasColumnName("manufacturer_id");

                entity.Property(e => e.Minimum)
                    .HasColumnName("minimum")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("model");

                entity.Property(e => e.Mpn)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("mpn");

                entity.Property(e => e.Points).HasColumnName("points");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Shipping)
                    .IsRequired()
                    .HasColumnName("shipping")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Sku)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("sku");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.StockStatusId).HasColumnName("stock_status_id");

                entity.Property(e => e.Subtract)
                    .IsRequired()
                    .HasColumnName("subtract")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TaxClassId).HasColumnName("tax_class_id");

                entity.Property(e => e.Upc)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasColumnName("upc");

                entity.Property(e => e.Viewed).HasColumnName("viewed");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(15,8)")
                    .HasColumnName("weight");

                entity.Property(e => e.WeightClassId).HasColumnName("weight_class_id");

                entity.Property(e => e.Width)
                    .HasColumnType("decimal(15,8)")
                    .HasColumnName("width");
            });

            modelBuilder.Entity<OchvProductAttribute>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.AttributeId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_product_attribute");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.AttributeId).HasColumnName("attribute_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");
            });

            modelBuilder.Entity<OchvProductDescription>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_product_description");

                entity.HasIndex(e => e.Name, "name");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DisclaimerDescription).HasColumnName("disclaimer_description");

                entity.Property(e => e.MetaDescription)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_description");

                entity.Property(e => e.MetaKeyword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_keyword");

                entity.Property(e => e.MetaTitle)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("meta_title");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.ProductSheduler)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("product_sheduler");

                entity.Property(e => e.ShortDescription).HasColumnName("short_description");

                entity.Property(e => e.Tag)
                    .IsRequired()
                    .HasColumnName("tag");
            });

            modelBuilder.Entity<OchvProductDiscount>(entity =>
            {
                entity.HasKey(e => e.ProductDiscountId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_product_discount");

                entity.HasIndex(e => e.ProductId, "product_id");

                entity.Property(e => e.ProductDiscountId).HasColumnName("product_discount_id");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("date")
                    .HasColumnName("date_end")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DateStart)
                    .HasColumnType("date")
                    .HasColumnName("date_start")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("price");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");
            });

            modelBuilder.Entity<OchvProductFilter>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.FilterId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_product_filter");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.FilterId).HasColumnName("filter_id");
            });

            modelBuilder.Entity<OchvProductImage>(entity =>
            {
                entity.HasKey(e => e.ProductImageId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_product_image");

                entity.HasIndex(e => e.ProductId, "product_id");

                entity.Property(e => e.ProductImageId).HasColumnName("product_image_id");

                entity.Property(e => e.Image)
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<OchvProductOption>(entity =>
            {
                entity.HasKey(e => e.ProductOptionId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_product_option");

                entity.Property(e => e.ProductOptionId).HasColumnName("product_option_id");

                entity.Property(e => e.MasterOption).HasColumnName("master_option");

                entity.Property(e => e.MasterOptionValue).HasColumnName("master_option_value");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Required).HasColumnName("required");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OchvProductOptionValue>(entity =>
            {
                entity.HasKey(e => e.ProductOptionValueId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_product_option_value");

                entity.Property(e => e.ProductOptionValueId).HasColumnName("product_option_value_id");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.EstimatedTime)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("estimated_time")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IsDefault).HasColumnName("is_default");

                entity.Property(e => e.MasterOptionValue).HasColumnName("master_option_value");

                entity.Property(e => e.NotIncrease).HasColumnName("not_increase");

                entity.Property(e => e.OptionId).HasColumnName("option_id");

                entity.Property(e => e.OptionValueId).HasColumnName("option_value_id");

                entity.Property(e => e.Points).HasColumnName("points");

                entity.Property(e => e.PointsPrefix)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("points_prefix");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("price");

                entity.Property(e => e.PricePrefix)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("price_prefix");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.ProductOptionId).HasColumnName("product_option_id");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Subtract).HasColumnName("subtract");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(15,8)")
                    .HasColumnName("weight");

                entity.Property(e => e.WeightPrefix)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("weight_prefix");
            });

            modelBuilder.Entity<OchvProductRecurring>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.RecurringId, e.CustomerGroupId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_product_recurring");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.RecurringId).HasColumnName("recurring_id");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");
            });

            modelBuilder.Entity<OchvProductRelated>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.RelatedId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_product_related");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.RelatedId).HasColumnName("related_id");
            });

            modelBuilder.Entity<OchvProductReward>(entity =>
            {
                entity.HasKey(e => e.ProductRewardId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_product_reward");

                entity.Property(e => e.ProductRewardId).HasColumnName("product_reward_id");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.Points).HasColumnName("points");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<OchvProductSpecial>(entity =>
            {
                entity.HasKey(e => e.ProductSpecialId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_product_special");

                entity.HasIndex(e => e.ProductId, "product_id");

                entity.Property(e => e.ProductSpecialId).HasColumnName("product_special_id");

                entity.Property(e => e.CustomerGroupId).HasColumnName("customer_group_id");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("date")
                    .HasColumnName("date_end")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.DateStart)
                    .HasColumnType("date")
                    .HasColumnName("date_start")
                    .HasDefaultValueSql("'0000-00-00'");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("price");

                entity.Property(e => e.Priority)
                    .HasColumnName("priority")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ProductId).HasColumnName("product_id");
            });

            modelBuilder.Entity<OchvProductToCategory>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.CategoryId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_product_to_category");

                entity.HasIndex(e => e.CategoryId, "category_id");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.MainCategory).HasColumnName("main_category");
            });

            modelBuilder.Entity<OchvProductToLayout>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_product_to_layout");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.LayoutId).HasColumnName("layout_id");
            });

            modelBuilder.Entity<OchvProductToStore>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.StoreId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_product_to_store");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OchvRaidTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ochv_raid_time");

                entity.HasIndex(e => e.ProductId, "product_id")
                    .IsUnique();

                entity.Property(e => e.Faction)
                    .IsRequired()
                    .HasColumnType("json")
                    .HasColumnName("faction");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Scheduler)
                    .IsRequired()
                    .HasColumnType("longtext")
                    .HasColumnName("scheduler");

                entity.Property(e => e.Timezone)
                    .IsRequired()
                    .HasColumnType("json")
                    .HasColumnName("timezone");
            });

            modelBuilder.Entity<OchvRecurring>(entity =>
            {
                entity.HasKey(e => e.RecurringId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_recurring");

                entity.Property(e => e.RecurringId).HasColumnName("recurring_id");

                entity.Property(e => e.Cycle)
                    .HasColumnType("int unsigned")
                    .HasColumnName("cycle");

                entity.Property(e => e.Duration)
                    .HasColumnType("int unsigned")
                    .HasColumnName("duration");

                entity.Property(e => e.Frequency)
                    .IsRequired()
                    .HasColumnType("enum('day','week','semi_month','month','year')")
                    .HasColumnName("frequency");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(10,4)")
                    .HasColumnName("price");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint")
                    .HasColumnName("status");

                entity.Property(e => e.TrialCycle)
                    .HasColumnType("int unsigned")
                    .HasColumnName("trial_cycle");

                entity.Property(e => e.TrialDuration)
                    .HasColumnType("int unsigned")
                    .HasColumnName("trial_duration");

                entity.Property(e => e.TrialFrequency)
                    .IsRequired()
                    .HasColumnType("enum('day','week','semi_month','month','year')")
                    .HasColumnName("trial_frequency");

                entity.Property(e => e.TrialPrice)
                    .HasColumnType("decimal(10,4)")
                    .HasColumnName("trial_price");

                entity.Property(e => e.TrialStatus)
                    .HasColumnType("tinyint")
                    .HasColumnName("trial_status");
            });

            modelBuilder.Entity<OchvRecurringDescription>(entity =>
            {
                entity.HasKey(e => new { e.RecurringId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_recurring_description");

                entity.Property(e => e.RecurringId).HasColumnName("recurring_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OchvReview>(entity =>
            {
                entity.HasKey(e => e.ReviewId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_review");

                entity.HasIndex(e => e.ProductId, "product_id");

                entity.Property(e => e.ReviewId).HasColumnName("review_id");

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("author");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.DateModified).HasColumnName("date_modified");

                entity.Property(e => e.HrefReview)
                    .IsRequired()
                    .HasMaxLength(550)
                    .HasColumnName("href_review");

                entity.Property(e => e.ProductId).HasColumnName("product_id");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Text)
                    .IsRequired()
                    .HasColumnName("text");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("title");
            });

            modelBuilder.Entity<OchvSeoUrl>(entity =>
            {
                entity.HasKey(e => e.SeoUrlId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_seo_url");

                entity.HasIndex(e => e.Keyword, "keyword");

                entity.HasIndex(e => e.Query, "query");

                entity.Property(e => e.SeoUrlId).HasColumnName("seo_url_id");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("keyword");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Query)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("query");

                entity.Property(e => e.StoreId).HasColumnName("store_id");
            });

            modelBuilder.Entity<OchvSession>(entity =>
            {
                entity.HasKey(e => e.SessionId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_session");

                entity.Property(e => e.SessionId)
                    .HasMaxLength(32)
                    .HasColumnName("session_id");

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("data");

                entity.Property(e => e.Expire).HasColumnName("expire");
            });

            modelBuilder.Entity<OchvSetting>(entity =>
            {
                entity.HasKey(e => e.SettingId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_setting");

                entity.Property(e => e.SettingId).HasColumnName("setting_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("code");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("key");

                entity.Property(e => e.Serialized).HasColumnName("serialized");

                entity.Property(e => e.StoreId).HasColumnName("store_id");

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OchvStatistic>(entity =>
            {
                entity.HasKey(e => e.StatisticsId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_statistics");

                entity.Property(e => e.StatisticsId).HasColumnName("statistics_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("code");

                entity.Property(e => e.Value)
                    .HasColumnType("decimal(15,4)")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<OchvStockStatus>(entity =>
            {
                entity.HasKey(e => new { e.StockStatusId, e.LanguageId })
                    .HasName("PRIMARY");

                entity.ToTable("ochv_stock_status");

                entity.Property(e => e.StockStatusId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("stock_status_id");

                entity.Property(e => e.LanguageId).HasColumnName("language_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<OchvUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_user");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("code");

                entity.Property(e => e.DateAdded).HasColumnName("date_added");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(96)
                    .HasColumnName("email");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("firstname");

                entity.Property(e => e.Image)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("image");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("ip");

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasMaxLength(32)
                    .HasColumnName("lastname");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasColumnName("password");

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("salt");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.UserGroupId).HasColumnName("user_group_id");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<OchvUserGroup>(entity =>
            {
                entity.HasKey(e => e.UserGroupId)
                    .HasName("PRIMARY");

                entity.ToTable("ochv_user_group");

                entity.Property(e => e.UserGroupId).HasColumnName("user_group_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("name");

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasColumnName("permission");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
