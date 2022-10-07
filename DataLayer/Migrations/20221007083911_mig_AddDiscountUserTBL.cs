using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class mig_AddDiscountUserTBL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserDiscountCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DiscountId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDiscountCodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDiscountCodes_Discounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserDiscountCodes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(6821));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(7196));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(7338));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(8252));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(8964));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(9270));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(9338));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(9481));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(9958));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(1898));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 436, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatDate" },
                values: new object[] { new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(54), new DateTime(2022, 10, 7, 12, 9, 8, 437, DateTimeKind.Local).AddTicks(45) });

            migrationBuilder.CreateIndex(
                name: "IX_UserDiscountCodes_DiscountId",
                table: "UserDiscountCodes",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDiscountCodes_UserId",
                table: "UserDiscountCodes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDiscountCodes");

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
    }
}
