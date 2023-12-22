using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class _191223Deneme3 : Migration
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
                defaultValue: new DateTime(2023, 12, 19, 16, 18, 19, 108, DateTimeKind.Local).AddTicks(6115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 16, 5, 58, 487, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 16, 18, 19, 108, DateTimeKind.Local).AddTicks(5852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 16, 5, 58, 487, DateTimeKind.Local).AddTicks(6009));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6550));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6614));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6615));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6786));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6789));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6842));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6846));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6893));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(6950));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7004));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7100));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7214));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7269));
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
                defaultValue: new DateTime(2023, 12, 19, 16, 5, 58, 487, DateTimeKind.Local).AddTicks(6427),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 16, 18, 19, 108, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 16, 5, 58, 487, DateTimeKind.Local).AddTicks(6009),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 16, 18, 19, 108, DateTimeKind.Local).AddTicks(5852));

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

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9277));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9278));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 19, 16, 5, 58, 488, DateTimeKind.Local).AddTicks(9279));

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
    }
}
