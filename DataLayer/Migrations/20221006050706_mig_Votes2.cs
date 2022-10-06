using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class mig_Votes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ProductVotes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "CommentVotes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(4955));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(4982));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5016));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5033));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5221));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5238));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5289));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5297));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5436));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5489));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5506));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5816));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "CreatDate" },
                values: new object[] { new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5356), new DateTime(2022, 10, 6, 8, 37, 5, 995, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVotes_UserId",
                table: "ProductVotes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentVotes_UserId",
                table: "CommentVotes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CommentVotes_Users_UserId",
                table: "CommentVotes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVotes_Users_UserId",
                table: "ProductVotes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CommentVotes_Users_UserId",
                table: "CommentVotes");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVotes_Users_UserId",
                table: "ProductVotes");

            migrationBuilder.DropIndex(
                name: "IX_ProductVotes_UserId",
                table: "ProductVotes");

            migrationBuilder.DropIndex(
                name: "IX_CommentVotes_UserId",
                table: "CommentVotes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ProductVotes");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CommentVotes");

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
                columns: new[] { "BirthDate", "CreatDate" },
                values: new object[] { new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8092), new DateTime(2022, 10, 6, 8, 26, 31, 354, DateTimeKind.Local).AddTicks(8088) });
        }
    }
}
