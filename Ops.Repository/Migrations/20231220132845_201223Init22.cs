using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class _201223Init22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                defaultValue: new DateTime(2023, 12, 20, 16, 28, 44, 413, DateTimeKind.Local).AddTicks(4643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 16, 19, 7, 823, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 16, 28, 44, 413, DateTimeKind.Local).AddTicks(4214),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 16, 19, 7, 823, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7261));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7882));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(7965));

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "Id", "AddressId", "CreatedDate", "CustomerId", "DeletedDate", "IsActive", "ModifiedDate", "OrderStatus", "ShipCode", "Status", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8050), 1, null, true, null, 1, null, 1, 0m },
                    { 2, 0, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8053), 1, null, true, null, 4, null, 1, 0m },
                    { 3, 0, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8054), 1, null, true, null, 3, null, 1, 0m },
                    { 4, 0, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8055), 2, null, true, null, 2, null, 1, 0m }
                });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.InsertData(
                table: "ProductOrders",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "Price", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8445), null, true, null, "Tişört", 200m, 1, null },
                    { 2, 1, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8450), null, true, null, "Kısa Kollu Tişört", 150m, 1, null },
                    { 3, 2, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8452), null, true, null, " Uzun Kollu Tişört", 300m, 1, null },
                    { 4, 5, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8454), null, true, null, "Çanta", 400m, 1, null },
                    { 5, 6, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8456), null, true, null, "Cüzdan", 400m, 1, null },
                    { 6, 3, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8458), null, true, null, "Hoodie", 400m, 1, null },
                    { 7, 7, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8492), null, true, null, "Baf", 400m, 1, null },
                    { 8, 4, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8494), null, true, null, "Sweat", 500m, 1, null },
                    { 9, 1, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8496), null, true, null, "Kısa Kollu Tişört", 250m, 1, null },
                    { 10, 1, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8497), null, true, null, "Kısa Kollu Tişört", 350m, 1, null },
                    { 11, 1, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8499), null, true, null, "Kısa Kollu Tişört", 450m, 1, null },
                    { 12, 1, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8500), null, true, null, "Kısa Kollu Tişört", 1050m, 1, null }
                });

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.InsertData(
                table: "ProductOrder",
                columns: new[] { "Id", "Amount", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "OrderId", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8351), null, true, null, 1, 1, 0 },
                    { 2, 2, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8353), null, true, null, 1, 2, 0 },
                    { 3, 1, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8355), null, true, null, 2, 3, 0 },
                    { 4, 2, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8356), null, true, null, 2, 2, 0 },
                    { 5, 2, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8357), null, true, null, 3, 4, 0 },
                    { 6, 2, new DateTime(2023, 12, 20, 16, 28, 44, 414, DateTimeKind.Local).AddTicks(8358), null, true, null, 4, 5, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductOrders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 16, 19, 7, 823, DateTimeKind.Local).AddTicks(1978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 16, 28, 44, 413, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 16, 19, 7, 823, DateTimeKind.Local).AddTicks(1613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 16, 28, 44, 413, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(2559));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(2981));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3092));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3415));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3419));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3425));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3520));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3522));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3597));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3682));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3688));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 16, 19, 7, 824, DateTimeKind.Local).AddTicks(3759));
        }
    }
}
