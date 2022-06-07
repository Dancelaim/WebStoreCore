using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Admin.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HtmlBlocks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ParentCSSClass = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ParentTitle = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    ChildCSSClass = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    SitePage = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtmlBlocks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderCustomFields",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ShlCharacterName = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    ShlRealmName = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    ShlFaction = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    ShlRegion = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    ShlBattleTag = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    PoeCharacterName = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    PoeAccountName = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    ClassicCharacterName = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    ClassicRealmName = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    ClassicFaction = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    ClassicRegion = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    ClassicBattleTag = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderCustomFields", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductDescription",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    SubDescriptionTitle1 = table.Column<string>(type: "text", nullable: true),
                    SubDescriptionTitle2 = table.Column<string>(type: "text", nullable: true),
                    SubDescriptionTitle3 = table.Column<string>(type: "text", nullable: true),
                    SubDescriptionTitle4 = table.Column<string>(type: "text", nullable: true),
                    SubDescriptionTitle5 = table.Column<string>(type: "text", nullable: true),
                    SubDescription1 = table.Column<string>(type: "text", nullable: true),
                    SubDescription2 = table.Column<string>(type: "text", nullable: true),
                    SubDescription3 = table.Column<string>(type: "text", nullable: true),
                    SubDescription4 = table.Column<string>(type: "text", nullable: true),
                    SubDescription5 = table.Column<string>(type: "text", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDescription", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ranks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Sale = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    RoleName = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Seo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    MetaTagTitle = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    MetaTagDescription = table.Column<string>(type: "text", nullable: true),
                    MetaTagKeyWords = table.Column<string>(type: "text", nullable: true),
                    SEOTags = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CustomTitle1 = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CustomTitle2 = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CustomImageTitle = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CustomImageAlt = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    MetaRobots = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    UrlKeyWord = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    SEOImage = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TemplateOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OptionName = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    OptionType = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: true),
                    OptionParentId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HtmlBlocksChildren",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SiteBlockId = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Image = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CSSClass = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ChildOrder = table.Column<int>(type: "integer", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HtmlBlocksChildren", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HtmlBlocksChildren_HtmlBlocks_SiteBlockId",
                        column: x => x.SiteBlockId,
                        principalTable: "HtmlBlocks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Password = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    RankId = table.Column<Guid>(type: "uuid", nullable: true),
                    Email = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    CarryCoinsValue = table.Column<decimal>(type: "numeric(18,2)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Ranks_RankId",
                        column: x => x.RankId,
                        principalTable: "Ranks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Password = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    RoleId = table.Column<Guid>(type: "uuid", nullable: true),
                    Email = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    DefaultPage = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductGame",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    GameName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    GameDescription = table.Column<string>(type: "text", nullable: true),
                    GameShortUrl = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    GameSeoId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductGame", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductGame_Seo_GameSeoId",
                        column: x => x.GameSeoId,
                        principalTable: "Seo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TempOptionParams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ParameterName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ParameterTooltip = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    ParameterPrice = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    ParentOptionId = table.Column<Guid>(type: "uuid", nullable: true),
                    ParameterSale = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Delete = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempOptionParams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TempOptionParams_TemplateOptions_ParentOptionId",
                        column: x => x.ParentOptionId,
                        principalTable: "TemplateOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TempOptionParams_TempOptionParams_Delete",
                        column: x => x.Delete,
                        principalTable: "TempOptionParams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uuid", nullable: true),
                    Discord = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Comment = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    OrderCustomFieldsId = table.Column<Guid>(type: "uuid", nullable: true),
                    Email = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    PaymentMethod = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    PaymentCode = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Total = table.Column<decimal>(type: "numeric", nullable: true),
                    OrderStatus = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Currency = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    CustomerIP = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    UserAgent = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    EmailSended = table.Column<bool>(type: "boolean", nullable: true),
                    EmailSendTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CarryCoinsSpent = table.Column<decimal>(type: "numeric", nullable: true),
                    CarryCoinsCollected = table.Column<decimal>(type: "numeric", nullable: true),
                    OrderNumber = table.Column<int>(type: "integer", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_OrderCustomFields_OrderCustomFieldsId",
                        column: x => x.OrderCustomFieldsId,
                        principalTable: "OrderCustomFields",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Article",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    ShortDescription = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ReadTime = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    Tags = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ProductGameId = table.Column<Guid>(type: "uuid", nullable: true),
                    ArticleSeoId = table.Column<Guid>(type: "uuid", nullable: true),
                    ImagePath = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    Enabled = table.Column<bool>(type: "boolean", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Article", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Article_ProductGame_ProductGameId",
                        column: x => x.ProductGameId,
                        principalTable: "ProductGame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Article_Seo_ArticleSeoId",
                        column: x => x.ArticleSeoId,
                        principalTable: "Seo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductCategoryName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ProductGameId = table.Column<Guid>(type: "uuid", nullable: true),
                    CategoryDescription = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CategorySeoId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategory_ProductGame_ProductGameId",
                        column: x => x.ProductGameId,
                        principalTable: "ProductGame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductCategory_Seo_CategorySeoId",
                        column: x => x.CategorySeoId,
                        principalTable: "Seo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Realms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductGameId = table.Column<Guid>(type: "uuid", nullable: false),
                    RealmName = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Realms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Realms_ProductGame_ProductGameId",
                        column: x => x.ProductGameId,
                        principalTable: "ProductGame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductCategoryName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ProductCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    CategoryDescription = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    SubCategorySeoId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubCategory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSubCategory_ProductCategory_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductSubCategory_Seo_SubCategorySeoId",
                        column: x => x.SubCategorySeoId,
                        principalTable: "Seo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ProductCategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    InStock = table.Column<bool>(type: "boolean", nullable: false),
                    PreOrder = table.Column<bool>(type: "boolean", nullable: false),
                    ProductQuantity = table.Column<int>(type: "integer", nullable: true),
                    ProductImage = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ProductDescriptionId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProductSeoId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProductGameId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProductSubCategoryId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProductPriority = table.Column<int>(type: "integer", nullable: true),
                    ProductEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    ProductImageThumb = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_ProductDescription_ProductDescriptionId",
                        column: x => x.ProductDescriptionId,
                        principalTable: "ProductDescription",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_ProductGame_ProductGameId",
                        column: x => x.ProductGameId,
                        principalTable: "ProductGame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_ProductSubCategory_ProductSubCategoryId",
                        column: x => x.ProductSubCategoryId,
                        principalTable: "ProductSubCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Seo_ProductSeoId",
                        column: x => x.ProductSeoId,
                        principalTable: "Seo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderProduct",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OrderId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: true),
                    ProductOptions = table.Column<string>(type: "text", nullable: true),
                    ProductCheckoutPrice = table.Column<decimal>(type: "numeric(19,1)", nullable: true),
                    TotalOptionsCheckoutPrice = table.Column<decimal>(type: "numeric(19,1)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    OptionName = table.Column<string>(type: "character varying(55)", maxLength: 55, nullable: true),
                    OptionType = table.Column<int>(type: "integer", nullable: true),
                    OptionParentId = table.Column<Guid>(type: "uuid", nullable: true),
                    OptionProductId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductOptions_Product_OptionProductId",
                        column: x => x.OptionProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductOptions_ProductOptions_OptionParentId",
                        column: x => x.OptionParentId,
                        principalTable: "ProductOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductPrice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    UsPrice = table.Column<decimal>(type: "numeric(18,1)", nullable: true),
                    UsSale = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    EuPrice = table.Column<decimal>(type: "numeric(18,1)", nullable: true),
                    EuSale = table.Column<decimal>(type: "numeric(18,0)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductPrice_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductOptionParams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ParameterName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    ParameterTooltip = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    ParameterPrice = table.Column<decimal>(type: "numeric(18,2)", nullable: false),
                    ParentOptionId = table.Column<Guid>(type: "uuid", nullable: true),
                    ParameterSale = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ParameterParentId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IsArchive = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOptionParams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductOptionParams_ProductOptionParams_ParameterParentId",
                        column: x => x.ParameterParentId,
                        principalTable: "ProductOptionParams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductOptionParams_ProductOptions_ParentOptionId",
                        column: x => x.ParentOptionId,
                        principalTable: "ProductOptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Article_ArticleSeoId",
                table: "Article",
                column: "ArticleSeoId");

            migrationBuilder.CreateIndex(
                name: "IX_Article_ProductGameId",
                table: "Article",
                column: "ProductGameId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_RankId",
                table: "Customers",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "IX_HtmlBlocksChildren_SiteBlockId",
                table: "HtmlBlocksChildren",
                column: "SiteBlockId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_OrderId",
                table: "OrderProduct",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProduct_ProductId",
                table: "OrderProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderCustomFieldsId",
                table: "Orders",
                column: "OrderCustomFieldsId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryId",
                table: "Product",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductDescriptionId",
                table: "Product",
                column: "ProductDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductGameId",
                table: "Product",
                column: "ProductGameId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductSeoId",
                table: "Product",
                column: "ProductSeoId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductSubCategoryId",
                table: "Product",
                column: "ProductSubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_CategorySeoId",
                table: "ProductCategory",
                column: "CategorySeoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategory_ProductGameId",
                table: "ProductCategory",
                column: "ProductGameId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductGame_GameSeoId",
                table: "ProductGame",
                column: "GameSeoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOptionParams_ParameterParentId",
                table: "ProductOptionParams",
                column: "ParameterParentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOptionParams_ParentOptionId",
                table: "ProductOptionParams",
                column: "ParentOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOptions_OptionParentId",
                table: "ProductOptions",
                column: "OptionParentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOptions_OptionProductId",
                table: "ProductOptions",
                column: "OptionProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrice_ProductId",
                table: "ProductPrice",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubCategory_ProductCategoryId",
                table: "ProductSubCategory",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubCategory_SubCategorySeoId",
                table: "ProductSubCategory",
                column: "SubCategorySeoId");

            migrationBuilder.CreateIndex(
                name: "IX_Realms_ProductGameId",
                table: "Realms",
                column: "ProductGameId");

            migrationBuilder.CreateIndex(
                name: "IX_TempOptionParams_Delete",
                table: "TempOptionParams",
                column: "Delete");

            migrationBuilder.CreateIndex(
                name: "IX_TempOptionParams_ParentOptionId",
                table: "TempOptionParams",
                column: "ParentOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Article");

            migrationBuilder.DropTable(
                name: "HtmlBlocksChildren");

            migrationBuilder.DropTable(
                name: "OrderProduct");

            migrationBuilder.DropTable(
                name: "ProductOptionParams");

            migrationBuilder.DropTable(
                name: "ProductPrice");

            migrationBuilder.DropTable(
                name: "Realms");

            migrationBuilder.DropTable(
                name: "TempOptionParams");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "HtmlBlocks");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductOptions");

            migrationBuilder.DropTable(
                name: "TemplateOptions");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OrderCustomFields");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Ranks");

            migrationBuilder.DropTable(
                name: "ProductDescription");

            migrationBuilder.DropTable(
                name: "ProductSubCategory");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "ProductGame");

            migrationBuilder.DropTable(
                name: "Seo");
        }
    }
}
