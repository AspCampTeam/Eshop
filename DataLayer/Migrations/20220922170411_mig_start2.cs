using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    public partial class mig_start2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreatDate", "IsDelete", "ParentId", "Title" },
                values: new object[] { 1, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3555), false, null, "مدیریت سایت" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatDate", "IsDelete", "RoleTitle" },
                values: new object[] { 1, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3398), false, "مدیریت اصلی سایت" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ActiveCode", "BirthDate", "CreatDate", "Email", "FirstName", "Gender", "IsAdmin", "IsDelete", "LastName", "Password", "PhoneNumber", "Status" },
                values: new object[] { 1, "123456", new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4363), new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4358), "/", null, 0, true, false, null, "20-2C-B9-62-AC-59-07-5B-96-4B-07-15-2D-23-4B-70", "12345678910", 0 });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreatDate", "IsDelete", "ParentId", "Title" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3576), false, 1, "مدیریت کاربران" },
                    { 13, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3690), false, 1, "مدیریت تماس با ما" },
                    { 17, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3768), false, 1, "مدیریت تیکت ها" },
                    { 22, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3833), false, 1, "میدیریت محصولات" },
                    { 30, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3947), false, 1, "مدیریت ویژگی ها" },
                    { 32, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3979), false, 1, "مدیریت دسته بندی محصولات" },
                    { 35, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4025), false, 1, "مدیریت نقش ها" },
                    { 39, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4087), false, 1, "مدیریت لینک" },
                    { 46, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4195), false, 1, "مدیریت بنر" },
                    { 50, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4315), false, 1, " مدیریت صفحه های داینامیک" },
                    { 51, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4331), false, 1, " مدیریت سوالات متداول" }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "Id", "CreatDate", "IsDelete", "PermissionId", "RoleId" },
                values: new object[] { 1, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4388), false, 1, 1 });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "CreatDate", "IsDelete", "RoleId", "UserId" },
                values: new object[] { 1, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(5132), false, 1, 1 });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreatDate", "IsDelete", "ParentId", "Title" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3593), false, 2, "افزودن کاربر" },
                    { 4, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3609), false, 2, "ویرایش کاربر" },
                    { 5, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3626), false, 2, "حذف کاربر" },
                    { 6, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3644), false, 2, "سفارشات کاربران" },
                    { 7, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3659), false, 2, "دسترسی کاربر" },
                    { 8, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3674), false, 2, "محصولات مورد علافه کاربر" },
                    { 15, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3708), false, 13, "حذف تماس با ما" },
                    { 16, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3725), false, 13, "پاسخ تماس با ما" },
                    { 18, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3785), false, 17, "افزودن تیکت" },
                    { 20, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3801), false, 17, "بستن تیکت" },
                    { 21, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3817), false, 17, "پاسخ به تیکت" },
                    { 23, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3849), false, 22, "افزودن محصول" },
                    { 24, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3867), false, 22, "مدیریت تصاویر محصول" },
                    { 25, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3886), false, 22, "مدیریت نظرات محصول" },
                    { 27, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3901), false, 22, "مدیریت تگ های محصول" },
                    { 28, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3917), false, 22, "ویرایش محصول" },
                    { 29, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3932), false, 22, "حذف محصول" },
                    { 31, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3963), false, 30, "مدیریت مقادیر ویژگی ها" },
                    { 36, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4041), false, 35, "افزودن نقش" },
                    { 37, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4056), false, 35, "ویرایش نقش" },
                    { 38, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4071), false, 35, "حذف نقش" },
                    { 40, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4102), false, 39, "افزودن لینک" },
                    { 41, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4121), false, 39, "ویرایش لینک" },
                    { 42, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4136), false, 39, "حذف لینک" },
                    { 43, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4151), false, 32, "افزودن دسته بندی" },
                    { 44, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4165), false, 32, "ویرایش دسته بندی" },
                    { 45, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4180), false, 32, "حذف دسته بندی" },
                    { 47, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4264), false, 46, "افزودن بنر" },
                    { 48, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4284), false, 46, "ویرایش بنر" },
                    { 49, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4300), false, 46, "حذف بنر" }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "Id", "CreatDate", "IsDelete", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4430), false, 2, 1 },
                    { 9, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4545), false, 13, 1 },
                    { 12, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4594), false, 17, 1 },
                    { 16, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4653), false, 22, 1 },
                    { 23, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4761), false, 30, 1 },
                    { 25, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4820), false, 32, 1 },
                    { 28, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4865), false, 35, 1 },
                    { 32, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4928), false, 39, 1 },
                    { 39, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(5040), false, 46, 1 },
                    { 43, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(5100), false, 50, 1 },
                    { 44, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(5115), false, 51, 1 }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "CreatDate", "IsDelete", "ParentId", "Title" },
                values: new object[,]
                {
                    { 33, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(3994), false, 7, "افزودن نقش کاربر" },
                    { 34, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4010), false, 7, "حذف نقش کاربر" }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "Id", "CreatDate", "IsDelete", "PermissionId", "RoleId" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4449), false, 3, 1 },
                    { 4, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4465), false, 4, 1 },
                    { 5, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4480), false, 5, 1 },
                    { 6, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4496), false, 6, 1 },
                    { 7, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4515), false, 7, 1 },
                    { 8, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4530), false, 8, 1 },
                    { 10, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4564), false, 15, 1 },
                    { 11, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4579), false, 16, 1 },
                    { 13, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4609), false, 18, 1 },
                    { 14, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4624), false, 20, 1 },
                    { 15, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4639), false, 21, 1 },
                    { 17, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4667), false, 23, 1 },
                    { 18, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4683), false, 24, 1 },
                    { 19, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4698), false, 25, 1 },
                    { 20, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4713), false, 27, 1 },
                    { 21, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4728), false, 28, 1 },
                    { 22, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4744), false, 29, 1 },
                    { 24, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4804), false, 31, 1 },
                    { 29, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4881), false, 36, 1 },
                    { 30, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4896), false, 37, 1 },
                    { 31, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4911), false, 38, 1 },
                    { 33, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4943), false, 40, 1 },
                    { 34, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4962), false, 41, 1 },
                    { 35, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4978), false, 42, 1 },
                    { 36, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4993), false, 43, 1 },
                    { 37, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(5008), false, 44, 1 },
                    { 38, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(5025), false, 45, 1 },
                    { 40, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(5055), false, 47, 1 },
                    { 41, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(5070), false, 48, 1 },
                    { 42, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(5085), false, 49, 1 }
                });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "Id", "CreatDate", "IsDelete", "PermissionId", "RoleId" },
                values: new object[] { 26, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4835), false, 33, 1 });

            migrationBuilder.InsertData(
                table: "RolePermissions",
                columns: new[] { "Id", "CreatDate", "IsDelete", "PermissionId", "RoleId" },
                values: new object[] { 27, new DateTime(2022, 9, 22, 20, 34, 11, 368, DateTimeKind.Local).AddTicks(4850), false, 34, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "RolePermissions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
