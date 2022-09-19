using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class mig_selectedfeature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductPrice_Products_ProductId",
                table: "ProductPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSelectedFeature_Features_FeatureId",
                table: "ProductSelectedFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSelectedFeature_FeatureValues_FeatureValueId",
                table: "ProductSelectedFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSelectedFeature_ProductPrice_ProductPriceId",
                table: "ProductSelectedFeature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSelectedFeature",
                table: "ProductSelectedFeature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductPrice",
                table: "ProductPrice");

            migrationBuilder.RenameTable(
                name: "ProductSelectedFeature",
                newName: "ProductSelectedFeatures");

            migrationBuilder.RenameTable(
                name: "ProductPrice",
                newName: "ProductPrices");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSelectedFeature_ProductPriceId",
                table: "ProductSelectedFeatures",
                newName: "IX_ProductSelectedFeatures_ProductPriceId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSelectedFeature_FeatureValueId",
                table: "ProductSelectedFeatures",
                newName: "IX_ProductSelectedFeatures_FeatureValueId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSelectedFeature_FeatureId",
                table: "ProductSelectedFeatures",
                newName: "IX_ProductSelectedFeatures_FeatureId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductPrice_ProductId",
                table: "ProductPrices",
                newName: "IX_ProductPrices_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSelectedFeatures",
                table: "ProductSelectedFeatures",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductPrices",
                table: "ProductPrices",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPrices_Products_ProductId",
                table: "ProductPrices",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSelectedFeatures_Features_FeatureId",
                table: "ProductSelectedFeatures",
                column: "FeatureId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSelectedFeatures_FeatureValues_FeatureValueId",
                table: "ProductSelectedFeatures",
                column: "FeatureValueId",
                principalTable: "FeatureValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSelectedFeatures_ProductPrices_ProductPriceId",
                table: "ProductSelectedFeatures",
                column: "ProductPriceId",
                principalTable: "ProductPrices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductPrices_Products_ProductId",
                table: "ProductPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSelectedFeatures_Features_FeatureId",
                table: "ProductSelectedFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSelectedFeatures_FeatureValues_FeatureValueId",
                table: "ProductSelectedFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductSelectedFeatures_ProductPrices_ProductPriceId",
                table: "ProductSelectedFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductSelectedFeatures",
                table: "ProductSelectedFeatures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductPrices",
                table: "ProductPrices");

            migrationBuilder.RenameTable(
                name: "ProductSelectedFeatures",
                newName: "ProductSelectedFeature");

            migrationBuilder.RenameTable(
                name: "ProductPrices",
                newName: "ProductPrice");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSelectedFeatures_ProductPriceId",
                table: "ProductSelectedFeature",
                newName: "IX_ProductSelectedFeature_ProductPriceId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSelectedFeatures_FeatureValueId",
                table: "ProductSelectedFeature",
                newName: "IX_ProductSelectedFeature_FeatureValueId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductSelectedFeatures_FeatureId",
                table: "ProductSelectedFeature",
                newName: "IX_ProductSelectedFeature_FeatureId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductPrices_ProductId",
                table: "ProductPrice",
                newName: "IX_ProductPrice_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductSelectedFeature",
                table: "ProductSelectedFeature",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductPrice",
                table: "ProductPrice",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPrice_Products_ProductId",
                table: "ProductPrice",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSelectedFeature_Features_FeatureId",
                table: "ProductSelectedFeature",
                column: "FeatureId",
                principalTable: "Features",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSelectedFeature_FeatureValues_FeatureValueId",
                table: "ProductSelectedFeature",
                column: "FeatureValueId",
                principalTable: "FeatureValues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductSelectedFeature_ProductPrice_ProductPriceId",
                table: "ProductSelectedFeature",
                column: "ProductPriceId",
                principalTable: "ProductPrice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
