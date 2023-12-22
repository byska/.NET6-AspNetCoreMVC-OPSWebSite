using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class _201223Init11 : Migration
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
                defaultValue: new DateTime(2023, 12, 20, 13, 54, 52, 588, DateTimeKind.Local).AddTicks(2962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 13, 53, 38, 55, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 13, 54, 52, 588, DateTimeKind.Local).AddTicks(2697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 13, 53, 38, 55, DateTimeKind.Local).AddTicks(6862));

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
                defaultValue: new DateTime(2023, 12, 20, 13, 53, 38, 55, DateTimeKind.Local).AddTicks(7142),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 13, 54, 52, 588, DateTimeKind.Local).AddTicks(2962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 13, 53, 38, 55, DateTimeKind.Local).AddTicks(6862),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 13, 54, 52, 588, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4132));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4285));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4351));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4414));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4418));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4812));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4901));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4978));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5103));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5104));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5136));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 13, 53, 38, 56, DateTimeKind.Local).AddTicks(5348));
        }
    }
}
