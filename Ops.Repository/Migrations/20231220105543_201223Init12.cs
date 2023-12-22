using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class _201223Init12 : Migration
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
                defaultValue: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(2375),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 13, 54, 52, 588, DateTimeKind.Local).AddTicks(2962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(2119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 13, 54, 52, 588, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9155));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9255));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9257));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9258));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9386));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9392));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9437));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9492));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9493));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9494));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9626));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9628));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9737));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9798));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9849));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9988));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9995));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 429, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 429, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 429, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 429, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 429, DateTimeKind.Local).AddTicks(153));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 429, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 55, 42, 429, DateTimeKind.Local).AddTicks(209));
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
                defaultValue: new DateTime(2023, 12, 20, 13, 54, 52, 588, DateTimeKind.Local).AddTicks(2962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 13, 54, 52, 588, DateTimeKind.Local).AddTicks(2697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 13, 55, 42, 428, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(910));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1124));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1128));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1130));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1132));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1133));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1252));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1414));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1480));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1877));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 54, 52, 589, DateTimeKind.Local).AddTicks(2079));
        }
    }
}
