using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class Init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoUrl",
                table: "ProductFeatures",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "HomeSlider",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Subtitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeSlider", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(954));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(1288));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(1639));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(2147));

            migrationBuilder.InsertData(
                table: "HomeSlider",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "PhotoUrl", "Status", "Subtitle", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(2341), null, true, null, "img/bg-img/bg-1.jpg", 1, "Eşsiz Bahar Koleksiyonumuza Bir Göz Gezdirin.", "Bahar Koleksiyonu" },
                    { 2, new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(2346), null, true, null, "img/bg-img/bg-2.jpg", 1, "29 Ekime Özel Kargo Bedava.", "Kargo Bedava" }
                });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PhotoUrl" },
                values: new object[] { new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(2605), "adafa" });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PhotoUrl" },
                values: new object[] { new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(2608), "adafa" });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PhotoUrl" },
                values: new object[] { new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(2610), "adafa" });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PhotoUrl" },
                values: new object[] { new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(2612), "adafa" });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PhotoUrl" },
                values: new object[] { new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(2613), "adafa" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amount", "CreatedDate" },
                values: new object[] { 10, new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(2752) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amount", "CreatedDate" },
                values: new object[] { 20, new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(2754) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "CreatedDate" },
                values: new object[] { 100, new DateTime(2023, 10, 21, 1, 6, 25, 466, DateTimeKind.Local).AddTicks(2756) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomeSlider");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "PhotoUrl",
                table: "ProductFeatures");

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 288, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 288, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 288, DateTimeKind.Local).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 288, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 288, DateTimeKind.Local).AddTicks(8672));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 288, DateTimeKind.Local).AddTicks(8675));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 288, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 288, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 288, DateTimeKind.Local).AddTicks(9818));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 288, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 288, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 288, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 289, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 289, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 289, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 289, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 289, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 289, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 289, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 289, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 289, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 289, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 289, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 289, DateTimeKind.Local).AddTicks(2047));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 289, DateTimeKind.Local).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 289, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 289, DateTimeKind.Local).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 289, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 289, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 289, DateTimeKind.Local).AddTicks(2609));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 289, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 15, 22, 8, 289, DateTimeKind.Local).AddTicks(2615));
        }
    }
}
