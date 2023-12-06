using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class _051223init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Email",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetRoles");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "AspNetRoles");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 5, 16, 54, 58, 498, DateTimeKind.Local).AddTicks(4660),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 21, 16, 27, 57, 602, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 5, 16, 54, 58, 498, DateTimeKind.Local).AddTicks(4335),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 11, 21, 16, 27, 57, 602, DateTimeKind.Local).AddTicks(4775));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Addresses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Addresses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Addresses",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ZIP",
                table: "Addresses",
                type: "int",
                maxLength: 5,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "FirstName", "LastName", "PhoneNumber", "ZIP" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(1626), "Beste", "Yasak", "05360249093", 34700 });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "FirstName", "LastName", "PhoneNumber", "ZIP" },
                values: new object[] { new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(1630), "Hüseyin", "Gülerman", "05360249093", 34700 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Name" },
                values: new object[] { "18b49523-99c7-409d-8114-22a3d05c24c9", new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2656), "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "NormalizedName", "Status" },
                values: new object[] { 2, "d583410c-a6db-4fcc-9b66-12368a2d911e", new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2659), null, true, null, "Customer", null, 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "bf5f79aa-868b-401c-8208-5aefe7bdb198", new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "0cb27991-18cb-4cf6-8cad-2205f46afe33", new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2188) });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDate", "DateOfBirth", "DeletedDate", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "ModifiedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { 3, 0, "89aa92da-4acf-4347-b719-11100883afa6", new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2192), new DateTime(1997, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orangepressstore@gmail.com", false, "Ayşe", true, "Tabak", false, null, null, null, null, "Beste1998.", "05325841236", false, null, 1, false, null });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(1748));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(1927));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2039));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2093));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2298));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2595));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 5, 16, 54, 58, 499, DateTimeKind.Local).AddTicks(2894));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "ZIP",
                table: "Addresses");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 16, 27, 57, 602, DateTimeKind.Local).AddTicks(5088),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 5, 16, 54, 58, 498, DateTimeKind.Local).AddTicks(4660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 11, 21, 16, 27, 57, 602, DateTimeKind.Local).AddTicks(4775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 5, 16, 54, 58, 498, DateTimeKind.Local).AddTicks(4335));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "AspNetRoles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetRoles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetRoles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "AspNetRoles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "Email", "FirstName", "LastName", "Name", "Password" },
                values: new object[] { "2a2a9876-eff0-4aa4-8a80-ee5be8b6406f", new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2381), "orangepressstore@gmail.com", "Ayşe Nur", "Tabak", null, "Beste1998." });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "d5d50448-7be0-40b8-95bc-46c0280ae2dc", new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "CreatedDate" },
                values: new object[] { "97a74406-25c0-4948-a1c0-703c51cc76f2", new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2953) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3007));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3146));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3209));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3284));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3379));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3380));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 21, 16, 27, 57, 603, DateTimeKind.Local).AddTicks(3587));
        }
    }
}
