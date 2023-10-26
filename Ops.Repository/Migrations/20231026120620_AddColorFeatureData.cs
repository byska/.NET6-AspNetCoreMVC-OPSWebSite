using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class AddColorFeatureData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 773, DateTimeKind.Local).AddTicks(9786));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 773, DateTimeKind.Local).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.InsertData(
                table: "ColorProductFeature",
                columns: new[] { "Id", "ColorId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "ProductFeatureId", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(555), null, true, null, 1, 0 },
                    { 2, 2, new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(565), null, true, null, 1, 0 },
                    { 3, 2, new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(568), null, true, null, 2, 0 },
                    { 4, 2, new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(571), null, true, null, 3, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1499));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1837));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1843));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "SizeProductFeature",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(2132));

            migrationBuilder.UpdateData(
                table: "SizeProductFeature",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.UpdateData(
                table: "SizeProductFeature",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(2499));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ColorProductFeature",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ColorProductFeature",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ColorProductFeature",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ColorProductFeature",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(5465));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(5870));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(5874));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(6955));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7246));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7318));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7477));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "SizeProductFeature",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "SizeProductFeature",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "SizeProductFeature",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7848));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(8280));
        }
    }
}
