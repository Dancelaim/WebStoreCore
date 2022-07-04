using Microsoft.EntityFrameworkCore.Migrations;

namespace Admin.Migrations
{
    public partial class Rename_IsArchive_to_IsArchived : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "Users",
                newName: "IsArchived");

            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "TempOptionParams",
                newName: "IsArchived");

            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "TemplateOptions",
                newName: "IsArchived");

            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "Seo",
                newName: "IsArchived");

            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "Roles",
                newName: "IsArchived");

            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "Realms",
                newName: "IsArchived");

            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "Ranks",
                newName: "IsArchived");

            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "ProductSubCategory",
                newName: "IsArchived");

            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "ProductPrice",
                newName: "IsArchived");

            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "ProductOptions",
                newName: "IsArchived");

            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "ProductOptionParams",
                newName: "IsArchived");

            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "ProductGame",
                newName: "IsArchived");

            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "ProductDescription",
                newName: "IsArchived");

            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "ProductCategory",
                newName: "IsArchived");

            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "Product",
                newName: "IsArchived");

            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "Orders",
                newName: "IsArchived");

            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "OrderProduct",
                newName: "IsArchived");

            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "OrderCustomFields",
                newName: "IsArchived");

            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "HtmlBlocksChildren",
                newName: "IsArchived");

            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "HtmlBlocks",
                newName: "IsArchived");

            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "Customers",
                newName: "IsArchived");

            migrationBuilder.RenameColumn(
                name: "IsArchive",
                table: "Article",
                newName: "IsArchived");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "Users",
                newName: "IsArchive");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "TempOptionParams",
                newName: "IsArchive");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "TemplateOptions",
                newName: "IsArchive");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "Seo",
                newName: "IsArchive");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "Roles",
                newName: "IsArchive");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "Realms",
                newName: "IsArchive");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "Ranks",
                newName: "IsArchive");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "ProductSubCategory",
                newName: "IsArchive");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "ProductPrice",
                newName: "IsArchive");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "ProductOptions",
                newName: "IsArchive");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "ProductOptionParams",
                newName: "IsArchive");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "ProductGame",
                newName: "IsArchive");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "ProductDescription",
                newName: "IsArchive");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "ProductCategory",
                newName: "IsArchive");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "Product",
                newName: "IsArchive");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "Orders",
                newName: "IsArchive");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "OrderProduct",
                newName: "IsArchive");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "OrderCustomFields",
                newName: "IsArchive");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "HtmlBlocksChildren",
                newName: "IsArchive");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "HtmlBlocks",
                newName: "IsArchive");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "Customers",
                newName: "IsArchive");

            migrationBuilder.RenameColumn(
                name: "IsArchived",
                table: "Article",
                newName: "IsArchive");
        }
    }
}
