using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class _201223Init18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColorProduct_Products_ProductId",
                table: "ColorProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Products_ProductId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Products_ProductId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductFeatures_Products_ProductId",
                table: "ProductFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrder_Orders_OrderId",
                table: "ProductOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrder_Products_ProductId",
                table: "ProductOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_SizeProduct_Products_ProductId",
                table: "SizeProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Products_ProductId",
                table: "Stocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "ProductOrders");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "OrderProducts");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "ProductOrders",
                newName: "IX_ProductOrders_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CustomerId",
                table: "OrderProducts",
                newName: "IX_OrderProducts_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_AddressId",
                table: "OrderProducts",
                newName: "IX_OrderProducts_AddressId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 15, 17, 32, 735, DateTimeKind.Local).AddTicks(2032),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 15, 6, 46, 984, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 15, 17, 32, 735, DateTimeKind.Local).AddTicks(1738),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 15, 6, 46, 984, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductOrders",
                table: "ProductOrders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts",
                column: "Id");

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

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1268));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 17, 32, 736, DateTimeKind.Local).AddTicks(1271));

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
                name: "FK_ColorProduct_ProductOrders_ProductId",
                table: "ColorProduct",
                column: "ProductId",
                principalTable: "ProductOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_ProductOrders_ProductId",
                table: "Comments",
                column: "ProductId",
                principalTable: "ProductOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_Addresses_AddressId",
                table: "OrderProducts",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_AspNetUsers_CustomerId",
                table: "OrderProducts",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_ProductOrders_ProductId",
                table: "Photos",
                column: "ProductId",
                principalTable: "ProductOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFeatures_ProductOrders_ProductId",
                table: "ProductFeatures",
                column: "ProductId",
                principalTable: "ProductOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrders_Categories_CategoryId",
                table: "ProductOrders",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SizeProduct_ProductOrders_ProductId",
                table: "SizeProduct",
                column: "ProductId",
                principalTable: "ProductOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_ProductOrders_ProductId",
                table: "Stocks",
                column: "ProductId",
                principalTable: "ProductOrders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColorProduct_ProductOrders_ProductId",
                table: "ColorProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_ProductOrders_ProductId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_Addresses_AddressId",
                table: "OrderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_AspNetUsers_CustomerId",
                table: "OrderProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_ProductOrders_ProductId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductFeatures_ProductOrders_ProductId",
                table: "ProductFeatures");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrder_OrderProducts_OrderId",
                table: "ProductOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrder_ProductOrders_ProductId",
                table: "ProductOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOrders_Categories_CategoryId",
                table: "ProductOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_SizeProduct_ProductOrders_ProductId",
                table: "SizeProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_ProductOrders_ProductId",
                table: "Stocks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductOrders",
                table: "ProductOrders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "ProductOrders",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "OrderProducts",
                newName: "Orders");

            migrationBuilder.RenameIndex(
                name: "IX_ProductOrders_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProducts_CustomerId",
                table: "Orders",
                newName: "IX_Orders_CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderProducts_AddressId",
                table: "Orders",
                newName: "IX_Orders_AddressId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 15, 6, 46, 984, DateTimeKind.Local).AddTicks(6688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 15, 17, 32, 735, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 15, 6, 46, 984, DateTimeKind.Local).AddTicks(6425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 15, 17, 32, 735, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3449));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3450));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3509));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3615));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3794));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3818));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3819));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3876));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3877));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3878));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3879));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4430));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4509));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4511));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4771));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 15, 6, 46, 985, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.AddForeignKey(
                name: "FK_ColorProduct_Products_ProductId",
                table: "ColorProduct",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Products_ProductId",
                table: "Comments",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Products_ProductId",
                table: "Photos",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFeatures_Products_ProductId",
                table: "ProductFeatures",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrder_Orders_OrderId",
                table: "ProductOrder",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOrder_Products_ProductId",
                table: "ProductOrder",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SizeProduct_Products_ProductId",
                table: "SizeProduct",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Products_ProductId",
                table: "Stocks",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
