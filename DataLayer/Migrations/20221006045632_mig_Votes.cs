using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class mig_Votes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CommentVotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vote = table.Column<bool>(type: "bit", nullable: false),
                    CommentId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentVotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommentVotes_ProductComments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "ProductComments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductVotes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vote = table.Column<bool>(type: "bit", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreatDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductVotes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7747));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7805));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7949));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7957));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7981));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7988));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8054));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8168));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8367));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8452));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatDate", "Email" },
                values: new object[] { new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8092), new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8088), "yektakala@admin.com" });

            migrationBuilder.CreateIndex(
                name: "IX_CommentVotes_CommentId",
                table: "CommentVotes",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVotes_ProductId",
                table: "ProductVotes",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentVotes");

            migrationBuilder.DropTable(
                name: "ProductVotes");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3609));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3644));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3917));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3932));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4087));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4315));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4388));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4449));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4639));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4653));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4667));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4804));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4835));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4896));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4962));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(5008));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatDate", "Email" },
                values: new object[] { new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4363), new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4358), "/" });
        }
    }
}
