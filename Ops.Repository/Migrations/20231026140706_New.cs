using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColorProduct");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(4422));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(4977));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(6987));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(8676));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(9081));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 17, 7, 4, 461, DateTimeKind.Local).AddTicks(9243));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.CreateTable(
                name: "ColorProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ColorProduct_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColorProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(5276));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(5947));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.InsertData(
                table: "ColorProduct",
                columns: new[] { "Id", "ColorId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(6500), null, true, null, 1, 0 },
                    { 2, 2, new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(6516), null, true, null, 1, 0 },
                    { 3, 2, new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(6522), null, true, null, 2, 0 },
                    { 4, 2, new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(6527), null, true, null, 3, 0 }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(7171));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(7174));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(7457));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(7709));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(7991));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(9095));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(9103));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(9353));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(9844));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 16, 36, 54, 558, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.CreateIndex(
                name: "IX_ColorProduct_ColorId",
                table: "ColorProduct",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ColorProduct_ProductId",
                table: "ColorProduct",
                column: "ProductId");
        }
    }
}
