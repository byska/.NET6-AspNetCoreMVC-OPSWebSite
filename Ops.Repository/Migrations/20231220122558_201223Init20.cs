using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class _201223Init20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 10000);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 20000);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 30000);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 40000);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 3000);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 4000);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 5000);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 6000);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 7000);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 8000);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 9000);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 10000);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 11000);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 12000);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 15, 25, 58, 84, DateTimeKind.Local).AddTicks(9352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 15, 21, 22, 465, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 15, 25, 58, 84, DateTimeKind.Local).AddTicks(9036),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 15, 21, 22, 465, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8075));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8082));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8752));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 25, 58, 85, DateTimeKind.Local).AddTicks(9020));
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
                defaultValue: new DateTime(2023, 12, 20, 15, 21, 22, 465, DateTimeKind.Local).AddTicks(4330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 15, 25, 58, 84, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 15, 21, 22, 465, DateTimeKind.Local).AddTicks(4042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 15, 25, 58, 84, DateTimeKind.Local).AddTicks(9036));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(1816));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(1895));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(1985));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2036));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2091));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "Id", "AddressId", "CreatedDate", "CustomerId", "DeletedDate", "IsActive", "ModifiedDate", "OrderStatus", "ShipCode", "Status", "TotalPrice" },
                values: new object[,]
                {
                    { 10000, 0, new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2344), 1, null, true, null, 1, null, 1, 0m },
                    { 20000, 0, new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2346), 1, null, true, null, 4, null, 1, 0m },
                    { 30000, 0, new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2346), 1, null, true, null, 3, null, 1, 0m },
                    { 40000, 0, new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2347), 2, null, true, null, 2, null, 1, 0m }
                });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.InsertData(
                table: "ProductOrders",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "Price", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { 1000, 1, new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2541), null, true, null, "Tişört", 200m, 1, null },
                    { 2000, 1, new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2546), null, true, null, "Kısa Kollu Tişört", 150m, 1, null },
                    { 3000, 2, new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2548), null, true, null, " Uzun Kollu Tişört", 300m, 1, null },
                    { 4000, 5, new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2549), null, true, null, "Çanta", 400m, 1, null },
                    { 5000, 6, new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2550), null, true, null, "Cüzdan", 400m, 1, null },
                    { 6000, 3, new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2551), null, true, null, "Hoodie", 400m, 1, null },
                    { 7000, 7, new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2552), null, true, null, "Baf", 400m, 1, null },
                    { 8000, 4, new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2553), null, true, null, "Sweat", 500m, 1, null },
                    { 9000, 1, new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2554), null, true, null, "Kısa Kollu Tişört", 250m, 1, null },
                    { 10000, 1, new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2555), null, true, null, "Kısa Kollu Tişört", 350m, 1, null },
                    { 11000, 1, new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2572), null, true, null, "Kısa Kollu Tişört", 450m, 1, null },
                    { 12000, 1, new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2573), null, true, null, "Kısa Kollu Tişört", 1050m, 1, null }
                });

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2806));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2858));
        }
    }
}
