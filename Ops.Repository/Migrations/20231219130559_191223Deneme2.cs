using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class _191223Deneme2 : Migration
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
                defaultValue: new DateTime(2023, 12, 19, 16, 5, 58, 487, DateTimeKind.Local).AddTicks(6427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 15, 53, 29, 739, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 16, 5, 58, 487, DateTimeKind.Local).AddTicks(6009),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 15, 53, 29, 739, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9107));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9190));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9191));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.InsertData(
                table: "ProductOrder",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "OrderId", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9275), null, true, null, 1, 1, 0 },
                    { 2, new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9277), null, true, null, 1, 2, 0 },
                    { 3, new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9278), null, true, null, 2, 3, 0 },
                    { 4, new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9279), null, true, null, 2, 2, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9357));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9412));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9415));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9506));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9714));
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
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 15, 53, 29, 739, DateTimeKind.Local).AddTicks(1179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 16, 5, 58, 487, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 15, 53, 29, 739, DateTimeKind.Local).AddTicks(812),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 16, 5, 58, 487, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(867));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1230));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1378));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1784));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1973));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1976));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(2058));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(2060));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(2151));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 15, 53, 29, 740, DateTimeKind.Local).AddTicks(2223));
        }
    }
}
