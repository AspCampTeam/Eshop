using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class mig_AddOrderDetialProductPriceRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_ProductPrices_ProductPriceId",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "ProductPriceId",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_ProductPrices_ProductPriceId",
                table: "OrderDetails",
                column: "ProductPriceId",
                principalTable: "ProductPrices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_ProductPrices_ProductPriceId",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "ProductPriceId",
                table: "OrderDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_ProductPrices_ProductPriceId",
                table: "OrderDetails",
                column: "ProductPriceId",
                principalTable: "ProductPrices",
                principalColumn: "Id");
        }
    }
}
