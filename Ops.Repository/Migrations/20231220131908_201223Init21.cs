using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class _201223Init21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_AspNetUsers_CustomerId",
                table: "OrderProducts");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "OrderProducts",
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
                defaultValue: new DateTime(2023, 12, 20, 16, 19, 7, 823, DateTimeKind.Local).AddTicks(1978),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 15, 25, 58, 84, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 16, 19, 7, 823, DateTimeKind.Local).AddTicks(1613),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 15, 25, 58, 84, DateTimeKind.Local).AddTicks(9036));

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

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_AspNetUsers_CustomerId",
                table: "OrderProducts",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderProducts_AspNetUsers_CustomerId",
                table: "OrderProducts");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "OrderProducts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 15, 25, 58, 84, DateTimeKind.Local).AddTicks(9352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 16, 19, 7, 823, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 15, 25, 58, 84, DateTimeKind.Local).AddTicks(9036),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 16, 19, 7, 823, DateTimeKind.Local).AddTicks(1613));

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

            migrationBuilder.AddForeignKey(
                name: "FK_OrderProducts_AspNetUsers_CustomerId",
                table: "OrderProducts",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
