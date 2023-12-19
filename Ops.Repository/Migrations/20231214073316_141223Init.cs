using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class _141223Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 33, 15, 259, DateTimeKind.Local).AddTicks(1725),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 11, 24, 20, 386, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 14, 10, 33, 15, 259, DateTimeKind.Local).AddTicks(1352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 6, 11, 24, 20, 386, DateTimeKind.Local).AddTicks(6810));

            migrationBuilder.AddColumn<string>(
                name: "DisplayName",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1158));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1159));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1161));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1297));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1444));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1607));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1932));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 14, 10, 33, 15, 260, DateTimeKind.Local).AddTicks(2202));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "AspNetRoles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 11, 24, 20, 386, DateTimeKind.Local).AddTicks(7597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 33, 15, 259, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 6, 11, 24, 20, 386, DateTimeKind.Local).AddTicks(6810),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 14, 10, 33, 15, 259, DateTimeKind.Local).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9113));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "NormalizedName", "Status" },
                values: new object[,]
                {
                    { 1, "e7b35378-c44e-4d4f-abba-8cb99344752e", new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(1227), null, true, null, "Admin", null, 1 },
                    { 2, "76a9e3b9-f057-484c-a0ad-ac587b3754d3", new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(1248), null, true, null, "Customer", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDate", "DateOfBirth", "DeletedDate", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MembershipAgreement", "ModifiedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonelDataProtection", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "30d4e1fb-fb8f-4cc4-8a9d-6f7e6f9a5261", new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(221), new DateTime(1998, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "besteyasak@gmail.com", false, "Beste", true, "Yasak", false, null, false, null, null, null, "Beste1998.", false, "05362459825", false, null, 1, false, "bf79eb40-e3f4-447a-bca0-795d674e77e2" },
                    { 2, 0, "112f7648-3960-4b1a-919e-669087ef421c", new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(279), new DateTime(1997, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "huseyingulerman.1997@gmail.com", false, "Hüseyin", true, "Gülerman", false, null, false, null, null, null, "Beste1998.", false, "05325841236", false, null, 1, false, "a528518f-c4e7-418b-85b4-5591940448de" },
                    { 3, 0, "4dad3b45-9777-4ebc-86a2-50463cb408bb", new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(288), new DateTime(1997, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orangepressstore@gmail.com", false, "Ayşe", true, "Tabak", false, null, false, null, null, null, "Beste1998.", false, "05325841236", false, null, 1, false, "599aff89-b854-4d9d-adec-f1a265cc378f" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9403));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9675));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9685));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9976));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9980));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 388, DateTimeKind.Local).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(905));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 6, 11, 24, 20, 389, DateTimeKind.Local).AddTicks(1713));
        }
    }
}
