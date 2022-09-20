using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class mig_dynamicPage2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LinkId",
                table: "DynamicPages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DynamicPages_LinkId",
                table: "DynamicPages",
                column: "LinkId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DynamicPages_DynamicLinks_LinkId",
                table: "DynamicPages",
                column: "LinkId",
                principalTable: "DynamicLinks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DynamicPages_DynamicLinks_LinkId",
                table: "DynamicPages");

            migrationBuilder.DropIndex(
                name: "IX_DynamicPages_LinkId",
                table: "DynamicPages");

            migrationBuilder.DropColumn(
                name: "LinkId",
                table: "DynamicPages");
        }
    }
}
