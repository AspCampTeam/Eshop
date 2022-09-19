using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class mig_CommentStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAnswered",
                table: "ProductComments");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ProductComments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "ProductComments");

            migrationBuilder.AddColumn<bool>(
                name: "IsAnswered",
                table: "ProductComments",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
