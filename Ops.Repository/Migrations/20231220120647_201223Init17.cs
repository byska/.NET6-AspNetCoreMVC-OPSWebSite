using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class _201223Init17 : Migration
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
                defaultValue: new DateTime(2023, 12, 20, 15, 6, 46, 984, DateTimeKind.Local).AddTicks(6688),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 14, 42, 32, 280, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 15, 6, 46, 984, DateTimeKind.Local).AddTicks(6425),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 14, 42, 32, 280, DateTimeKind.Local).AddTicks(6984));

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
                defaultValue: new DateTime(2023, 12, 20, 14, 42, 32, 280, DateTimeKind.Local).AddTicks(7513),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 15, 6, 46, 984, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 14, 42, 32, 280, DateTimeKind.Local).AddTicks(6984),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 15, 6, 46, 984, DateTimeKind.Local).AddTicks(6425));

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

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4070));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 20000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 30000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 40000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4073));

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

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4641));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4643));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4645));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12000,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 14, 42, 32, 282, DateTimeKind.Local).AddTicks(4938));

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
        }
    }
}
