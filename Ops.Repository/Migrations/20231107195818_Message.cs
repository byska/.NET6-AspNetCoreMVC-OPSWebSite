using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class Message : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(6824), "Tişört Regular" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(6829), "Tişört Oversize" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(6830), "Hoodie" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 4, new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(6831), null, true, null, "Sweatshirt", 1 },
                    { 5, new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(6832), null, true, null, "Kol Çantası", 1 },
                    { 6, new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(6833), null, true, null, "Cüzdan", 1 },
                    { 7, new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(6835), null, true, null, "Baf", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(6964));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(7273));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(7406));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(7631));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "Email", "IsActive", "ModifiedDate", "Name", "Status", "Subject" },
                values: new object[] { 1, new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(7869), null, "Fiziksel bir mağazanız bulunuyor mu acaba?", "beyasak@hotmail.com", true, null, "Beste", 0, "Bilgi Alma" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8302));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8424) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "CategoryId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "Price", "Status" },
                values: new object[] { 6, 20, 3, new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8429), null, true, null, "Hoodie", 400m, 1 });

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 5, new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8426) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "CategoryId", "CreatedDate", "Name", "Price" },
                values: new object[] { 20, 6, new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8428), "Cüzdan", 400m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "CategoryId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "Price", "Status" },
                values: new object[,]
                {
                    { 7, 20, 7, new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8495), null, true, null, "Baf", 400m, 1 },
                    { 8, 100, 4, new DateTime(2023, 11, 7, 22, 58, 16, 805, DateTimeKind.Local).AddTicks(8497), null, true, null, "Sweat", 500m, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

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
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(5540), "Tişört" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(5545), "Sweat" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(5547), "Çanta" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(5868));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(7314));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(7579));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(8062));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(8073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(8075) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate" },
                values: new object[] { 3, new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "CategoryId", "CreatedDate", "Name", "Price" },
                values: new object[] { 100, 2, new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(8080), "Sweat", 500m });

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 6, 18, 9, 12, 146, DateTimeKind.Local).AddTicks(8645));
        }
    }
}
