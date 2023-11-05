using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class AddSeedDataPhoto3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 524, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 524, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 524, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 524, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 524, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 524, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 524, DateTimeKind.Local).AddTicks(9391));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 524, DateTimeKind.Local).AddTicks(9398));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 524, DateTimeKind.Local).AddTicks(9659));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 524, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 524, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 524, DateTimeKind.Local).AddTicks(9683));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 524, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 524, DateTimeKind.Local).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 524, DateTimeKind.Local).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PhotoUrl" },
                values: new object[] { new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(1753), "tshirt-1.jpeg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PhotoUrl" },
                values: new object[] { new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(1771), "tshirt-1.jpeg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PhotoUrl" },
                values: new object[] { new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(1777), "tshirt-1.jpeg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PhotoUrl" },
                values: new object[] { new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(1781), "tshirt-1.jpeg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PhotoUrl" },
                values: new object[] { new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(1786), "tshirt-1.jpeg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "PhotoUrl" },
                values: new object[] { new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(1794), "tshirt-1.jpeg" });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 53, 34, 525, DateTimeKind.Local).AddTicks(3226));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(6749));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(6763));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(7402));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(8990));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9098));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PhotoUrl" },
                values: new object[] { new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9276), "~/img/tshirt-1.jpeg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PhotoUrl" },
                values: new object[] { new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9287), "~/img/tshirt-1.jpeg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PhotoUrl" },
                values: new object[] { new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9291), "~/img/tshirt-1.jpeg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PhotoUrl" },
                values: new object[] { new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9294), "~/img/tshirt-1.jpeg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PhotoUrl" },
                values: new object[] { new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9297), "~/img/tshirt-1.jpeg" });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "PhotoUrl" },
                values: new object[] { new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9303), "~/img/tshirt-1.jpeg" });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9835));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9845));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 839, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 840, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 840, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 5, 18, 31, 5, 840, DateTimeKind.Local).AddTicks(149));
        }
    }
}
