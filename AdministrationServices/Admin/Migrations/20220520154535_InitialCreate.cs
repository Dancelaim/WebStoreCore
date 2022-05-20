using Microsoft.EntityFrameworkCore.Migrations;

namespace Admin.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ParameterName",
                table: "TempOptionParams",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "OptionName",
                table: "TemplateOptions",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "RoleName",
                table: "Roles",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "RealmName",
                table: "Realms",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ProductCategoryName",
                table: "ProductSubCategory",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "OptionName",
                table: "ProductOptions",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ParameterName",
                table: "ProductOptionParams",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "GameName",
                table: "ProductGame",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ProductCategoryName",
                table: "ProductCategory",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Product",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TempOptionParams",
                newName: "ParameterName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TemplateOptions",
                newName: "OptionName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Roles",
                newName: "RoleName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Realms",
                newName: "RealmName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ProductSubCategory",
                newName: "ProductCategoryName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ProductOptions",
                newName: "OptionName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ProductOptionParams",
                newName: "ParameterName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ProductGame",
                newName: "GameName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ProductCategory",
                newName: "ProductCategoryName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Product",
                newName: "ProductName");
        }
    }
}
