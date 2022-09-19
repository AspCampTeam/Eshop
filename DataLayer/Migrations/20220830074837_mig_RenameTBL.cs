using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class mig_RenameTBL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProductCategory_Product_ProductsId",
                table: "ProductProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSelectedCategory_Product_ProductId",
                table: "ProductSelectedCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSelectedCategory_ProductCategories_CategoryId",
                table: "ProductSelectedCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSelectedCategory",
                table: "ProductSelectedCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.RenameTable(
                name: "ProductSelectedCategory",
                newName: "ProductSelectedCategories");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSelectedCategory_ProductId",
                table: "ProductSelectedCategories",
                newName: "IX_ProductSelectedCategories_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSelectedCategory_CategoryId",
                table: "ProductSelectedCategories",
                newName: "IX_ProductSelectedCategories_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSelectedCategories",
                table: "ProductSelectedCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProductCategory_Products_ProductsId",
                table: "ProductProductCategory",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSelectedCategories_ProductCategories_CategoryId",
                table: "ProductSelectedCategories",
                column: "CategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSelectedCategories_Products_ProductId",
                table: "ProductSelectedCategories",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductProductCategory_Products_ProductsId",
                table: "ProductProductCategory");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSelectedCategories_ProductCategories_CategoryId",
                table: "ProductSelectedCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSelectedCategories_Products_ProductId",
                table: "ProductSelectedCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSelectedCategories",
                table: "ProductSelectedCategories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "ProductSelectedCategories",
                newName: "ProductSelectedCategory");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSelectedCategories_ProductId",
                table: "ProductSelectedCategory",
                newName: "IX_ProductSelectedCategory_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSelectedCategories_CategoryId",
                table: "ProductSelectedCategory",
                newName: "IX_ProductSelectedCategory_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSelectedCategory",
                table: "ProductSelectedCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductProductCategory_Product_ProductsId",
                table: "ProductProductCategory",
                column: "ProductsId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSelectedCategory_Product_ProductId",
                table: "ProductSelectedCategory",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSelectedCategory_ProductCategories_CategoryId",
                table: "ProductSelectedCategory",
                column: "CategoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
