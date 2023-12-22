using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class _201223Init19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrder_OrderProducts_OrderId",
                table: "ProductOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrder_ProductOrders_ProductId",
                table: "ProductOrder");

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
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductOrder",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "ProductOrder",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 15, 21, 22, 465, DateTimeKind.Local).AddTicks(4330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 15, 17, 32, 735, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 15, 21, 22, 465, DateTimeKind.Local).AddTicks(4042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 15, 17, 32, 735, DateTimeKind.Local).AddTicks(1738));

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

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 10000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 20000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 30000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 40000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2347));

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

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 2000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 3000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 4000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 5000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 6000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2551));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 7000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 8000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 9000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 10000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2555));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 11000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 12000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 21, 22, 466, DateTimeKind.Local).AddTicks(2573));

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrder_OrderProducts_OrderId",
                table: "ProductOrder",
                column: "OrderId",
                principalTable: "OrderProducts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrder_ProductOrders_ProductId",
                table: "ProductOrder",
                column: "ProductId",
                principalTable: "ProductOrders",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrder_OrderProducts_OrderId",
                table: "ProductOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrder_ProductOrders_ProductId",
                table: "ProductOrder");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductOrder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "ProductOrder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 15, 17, 32, 735, DateTimeKind.Local).AddTicks(2032),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 15, 21, 22, 465, DateTimeKind.Local).AddTicks(4330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 15, 17, 32, 735, DateTimeKind.Local).AddTicks(1738),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 15, 21, 22, 465, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(432));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(870));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 10000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 20000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 30000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 40000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.InsertData(
                table: "ProductOrder",
                columns: new[] { "Id", "Amount", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "OrderId", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1267), null, true, null, 10000, 1000, 0 },
                    { 2, 2, new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1268), null, true, null, 10000, 2000, 0 },
                    { 3, 1, new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1269), null, true, null, 20000, 3000, 0 },
                    { 4, 2, new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1270), null, true, null, 20000, 2000, 0 },
                    { 5, 2, new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1270), null, true, null, 30000, 4000, 0 },
                    { 6, 2, new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1271), null, true, null, 40000, 5000, 0 }
                });

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 2000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1337));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 3000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 4000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 5000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 6000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 7000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 8000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 9000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 10000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 11000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 12000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1483));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1487));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrder_OrderProducts_OrderId",
                table: "ProductOrder",
                column: "OrderId",
                principalTable: "OrderProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrder_ProductOrders_ProductId",
                table: "ProductOrder",
                column: "ProductId",
                principalTable: "ProductOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
