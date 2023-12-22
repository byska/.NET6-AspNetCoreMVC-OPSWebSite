using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class _191223Deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 15, 53, 29, 739, DateTimeKind.Local).AddTicks(1179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 15, 17, 51, 633, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 15, 53, 29, 739, DateTimeKind.Local).AddTicks(812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 15, 17, 51, 633, DateTimeKind.Local).AddTicks(7418));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(2223));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 15, 17, 51, 633, DateTimeKind.Local).AddTicks(7884),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 15, 53, 29, 739, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 15, 17, 51, 633, DateTimeKind.Local).AddTicks(7418),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 15, 53, 29, 739, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(8913));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9106));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9110));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9210));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9213));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9428));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9564));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9566));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9571));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9574));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9681));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9684));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 635, DateTimeKind.Local).AddTicks(9979));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(129));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.InsertData(
                table: "ProductOrder",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "OrderId", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(433), null, true, null, 1, 1, 0 },
                    { 2, new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(434), null, true, null, 1, 2, 0 },
                    { 3, new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(435), null, true, null, 2, 3, 0 },
                    { 4, new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(436), null, true, null, 2, 2, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 17, 51, 636, DateTimeKind.Local).AddTicks(948));
        }
    }
}
