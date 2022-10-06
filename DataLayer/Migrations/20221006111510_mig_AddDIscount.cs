using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class mig_AddDIscount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountCode = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DicountPercent = table.Column<int>(type: "int", nullable: false),
                    Useable = table.Column<int>(type: "int", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(3783));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4223));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4293));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4551));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4792));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4866));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4956));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5452));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5477));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5594));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5617));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5687));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5709));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5777));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5800));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5845));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5893));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatDate" },
                values: new object[] { new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5130), new DateTime(2022, 10, 6, 14, 45, 8, 606, DateTimeKind.Local).AddTicks(5126) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(751));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1079));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1154));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1244));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1251));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1260));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1282));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1290));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatDate" },
                values: new object[] { new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(876), new DateTime(2022, 10, 6, 12, 3, 3, 201, DateTimeKind.Local).AddTicks(873) });
        }
    }
}
