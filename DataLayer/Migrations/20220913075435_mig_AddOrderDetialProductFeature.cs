using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class mig_AddOrderDetialProductFeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductPriceId",
                table: "OrderDetails",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrderDetailProductFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FeatureValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDetailId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetailProductFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetailProductFeatures_OrderDetails_OrderDetailId",
                        column: x => x.OrderDetailId,
                        principalTable: "OrderDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductPriceId",
                table: "OrderDetails",
                column: "ProductPriceId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetailProductFeatures_OrderDetailId",
                table: "OrderDetailProductFeatures",
                column: "OrderDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_ProductPrices_ProductPriceId",
                table: "OrderDetails",
                column: "ProductPriceId",
                principalTable: "ProductPrices",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_ProductPrices_ProductPriceId",
                table: "OrderDetails");

            migrationBuilder.DropTable(
                name: "OrderDetailProductFeatures");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_ProductPriceId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "ProductPriceId",
                table: "OrderDetails");
        }
    }
}
