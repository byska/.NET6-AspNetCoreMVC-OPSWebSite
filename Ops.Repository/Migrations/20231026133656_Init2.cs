using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class Init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_ProductFeatures_ProductFeatureId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_ProductFeatures_ProductFeatureId",
                table: "Stocks");

            migrationBuilder.DropTable(
                name: "ColorProductFeature");

            migrationBuilder.DropTable(
                name: "SizeProductFeature");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_ColorId",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_ProductFeatureId",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_SizeId",
                table: "Stocks");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "ProductFeatureId",
                table: "Stocks",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "ProductFeatureId",
                table: "Photos",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_ProductFeatureId",
                table: "Photos",
                newName: "IX_Photos_ProductId");

            migrationBuilder.CreateTable(
                name: "ColorProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "SizeProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SizeProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SizeProduct_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
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

            migrationBuilder.InsertData(
                table: "SizeProduct",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "ProductId", "SizeId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(9353), null, true, null, 1, 1, 0 },
                    { 2, new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(9367), null, true, null, 2, 2, 0 },
                    { 3, new DateTime(2023, 10, 26, 16, 36, 54, 557, DateTimeKind.Local).AddTicks(9372), null, true, null, 3, 3, 0 }
                });

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
                name: "IX_Stocks_ColorId",
                table: "Stocks",
                column: "ColorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                table: "Stocks",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_SizeId",
                table: "Stocks",
                column: "SizeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ColorProduct_ColorId",
                table: "ColorProduct",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ColorProduct_ProductId",
                table: "ColorProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SizeProduct_ProductId",
                table: "SizeProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SizeProduct_SizeId",
                table: "SizeProduct",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Products_ProductId",
                table: "Photos",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Products_ProductId",
                table: "Stocks",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Products_ProductId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Products_ProductId",
                table: "Stocks");

            migrationBuilder.DropTable(
                name: "ColorProduct");

            migrationBuilder.DropTable(
                name: "SizeProduct");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_ColorId",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_ProductId",
                table: "Stocks");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_SizeId",
                table: "Stocks");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Stocks",
                newName: "ProductFeatureId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Photos",
                newName: "ProductFeatureId");

            migrationBuilder.RenameIndex(
                name: "IX_Photos_ProductId",
                table: "Photos",
                newName: "IX_Photos_ProductFeatureId");

            migrationBuilder.CreateTable(
                name: "ColorProductFeature",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    ProductFeatureId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorProductFeature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ColorProductFeature_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ColorProductFeature_ProductFeatures_ProductFeatureId",
                        column: x => x.ProductFeatureId,
                        principalTable: "ProductFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SizeProductFeature",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductFeatureId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SizeProductFeature", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SizeProductFeature_ProductFeatures_ProductFeatureId",
                        column: x => x.ProductFeatureId,
                        principalTable: "ProductFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SizeProductFeature_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "SizeProductFeature",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "ProductFeatureId", "SizeId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(2132), null, true, null, 1, 1, 0 },
                    { 2, new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(2141), null, true, null, 2, 2, 0 },
                    { 3, new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(2144), null, true, null, 3, 3, 0 }
                });

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
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "ColorId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "ProductFeatureId", "SizeId", "Status", "Stocks" },
                values: new object[] { 1, 1, new DateTime(2023, 10, 26, 15, 6, 18, 774, DateTimeKind.Local).AddTicks(2489), null, true, null, 1, 1, 0, 10 });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ColorId",
                table: "Stocks",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductFeatureId",
                table: "Stocks",
                column: "ProductFeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_SizeId",
                table: "Stocks",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_ColorProductFeature_ColorId",
                table: "ColorProductFeature",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ColorProductFeature_ProductFeatureId",
                table: "ColorProductFeature",
                column: "ProductFeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_SizeProductFeature_ProductFeatureId",
                table: "SizeProductFeature",
                column: "ProductFeatureId");

            migrationBuilder.CreateIndex(
                name: "IX_SizeProductFeature_SizeId",
                table: "SizeProductFeature",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_ProductFeatures_ProductFeatureId",
                table: "Photos",
                column: "ProductFeatureId",
                principalTable: "ProductFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_ProductFeatures_ProductFeatureId",
                table: "Stocks",
                column: "ProductFeatureId",
                principalTable: "ProductFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
