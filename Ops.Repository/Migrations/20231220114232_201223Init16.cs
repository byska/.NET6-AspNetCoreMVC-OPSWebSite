using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class _201223Init16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 14, 42, 32, 280, DateTimeKind.Local).AddTicks(7513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 14, 23, 37, 778, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 14, 42, 32, 280, DateTimeKind.Local).AddTicks(6984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 14, 23, 37, 778, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(2908));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(2910));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3478));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3481));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3483));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3486));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3867));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "CreatedDate", "CustomerId", "DeletedDate", "IsActive", "ModifiedDate", "OrderStatus", "ShipCode", "Status", "TotalPrice" },
                values: new object[,]
                {
                    { 10000, 0, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4070), 1, null, true, null, 1, null, 1, 0m },
                    { 20000, 0, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4071), 1, null, true, null, 4, null, 1, 0m },
                    { 30000, 0, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4072), 1, null, true, null, 3, null, 1, 0m },
                    { 40000, 0, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4073), 2, null, true, null, 2, null, 1, 0m }
                });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4424));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4502));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "Price", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { 1000, 1, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4636), null, true, null, "Tişört", 200m, 1, null },
                    { 2000, 1, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4641), null, true, null, "Kısa Kollu Tişört", 150m, 1, null },
                    { 3000, 2, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4642), null, true, null, " Uzun Kollu Tişört", 300m, 1, null },
                    { 4000, 5, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4643), null, true, null, "Çanta", 400m, 1, null },
                    { 5000, 6, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4645), null, true, null, "Cüzdan", 400m, 1, null },
                    { 6000, 3, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4646), null, true, null, "Hoodie", 400m, 1, null },
                    { 7000, 7, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4647), null, true, null, "Baf", 400m, 1, null },
                    { 8000, 4, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4933), null, true, null, "Sweat", 500m, 1, null },
                    { 9000, 1, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4935), null, true, null, "Kısa Kollu Tişört", 250m, 1, null },
                    { 10000, 1, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4936), null, true, null, "Kısa Kollu Tişört", 350m, 1, null },
                    { 11000, 1, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4937), null, true, null, "Kısa Kollu Tişört", 450m, 1, null },
                    { 12000, 1, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4938), null, true, null, "Kısa Kollu Tişört", 1050m, 1, null }
                });

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.InsertData(
                table: "ProductOrder",
                columns: new[] { "Id", "Amount", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "OrderId", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4569), null, true, null, 10000, 1000, 0 },
                    { 2, 2, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4570), null, true, null, 10000, 2000, 0 },
                    { 3, 1, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4571), null, true, null, 20000, 3000, 0 },
                    { 4, 2, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4571), null, true, null, 20000, 2000, 0 },
                    { 5, 2, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4572), null, true, null, 30000, 4000, 0 },
                    { 6, 2, new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4573), null, true, null, 40000, 5000, 0 }
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
                table: "Products",
                keyColumn: "Id",
                keyValue: 6000);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7000);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8000);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9000);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10000);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11000);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12000);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10000);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20000);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30000);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40000);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3000);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4000);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5000);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 14, 23, 37, 778, DateTimeKind.Local).AddTicks(8688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 14, 42, 32, 280, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 14, 23, 37, 778, DateTimeKind.Local).AddTicks(8370),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 14, 42, 32, 280, DateTimeKind.Local).AddTicks(6984));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6494));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6652));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6654));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6806));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "CreatedDate", "CustomerId", "DeletedDate", "IsActive", "ModifiedDate", "OrderStatus", "ShipCode", "Status", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6971), 1, null, true, null, 1, null, 1, 0m },
                    { 2, 0, new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6974), 1, null, true, null, 4, null, 1, 0m },
                    { 3, 0, new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6975), 1, null, true, null, 3, null, 1, 0m },
                    { 4, 0, new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(6975), 2, null, true, null, 2, null, 1, 0m }
                });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "Price", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7163), null, true, null, "Tişört", 200m, 1, null },
                    { 2, 1, new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7166), null, true, null, "Kısa Kollu Tişört", 150m, 1, null },
                    { 3, 2, new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7168), null, true, null, " Uzun Kollu Tişört", 300m, 1, null },
                    { 4, 5, new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7169), null, true, null, "Çanta", 400m, 1, null },
                    { 5, 6, new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7190), null, true, null, "Cüzdan", 400m, 1, null },
                    { 6, 3, new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7195), null, true, null, "Hoodie", 400m, 1, null },
                    { 7, 7, new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7196), null, true, null, "Baf", 400m, 1, null },
                    { 8, 4, new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7197), null, true, null, "Sweat", 500m, 1, null },
                    { 9, 1, new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7198), null, true, null, "Kısa Kollu Tişört", 250m, 1, null },
                    { 10, 1, new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7199), null, true, null, "Kısa Kollu Tişört", 350m, 1, null },
                    { 11, 1, new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7200), null, true, null, "Kısa Kollu Tişört", 450m, 1, null },
                    { 12, 1, new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7201), null, true, null, "Kısa Kollu Tişört", 1050m, 1, null }
                });

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7272));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7331));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 23, 37, 779, DateTimeKind.Local).AddTicks(7419));
        }
    }
}
