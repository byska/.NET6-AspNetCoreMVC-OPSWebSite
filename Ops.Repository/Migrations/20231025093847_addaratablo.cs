using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class addaratablo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColorProductFeature_Colors_ColorsId",
                table: "ColorProductFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_ColorProductFeature_ProductFeatures_ProductFeaturesId",
                table: "ColorProductFeature");

            migrationBuilder.DropTable(
                name: "ProductFeatureSize");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ColorProductFeature",
                table: "ColorProductFeature");

            migrationBuilder.DropIndex(
                name: "IX_ColorProductFeature_ProductFeaturesId",
                table: "ColorProductFeature");

            migrationBuilder.RenameColumn(
                name: "ProductFeaturesId",
                table: "ColorProductFeature",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "ColorsId",
                table: "ColorProductFeature",
                newName: "ProductFeatureId");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ColorProductFeature",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "ColorProductFeature",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ColorProductFeature",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "ColorProductFeature",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "ColorProductFeature",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedDate",
                table: "ColorProductFeature",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ColorProductFeature",
                table: "ColorProductFeature",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "SizeProductFeature",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductFeatureId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
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

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 2, new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(6208), null, true, null, "Blue", 0 },
                    { 3, new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(6211), null, true, null, "Yellow", 0 }
                });

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

            migrationBuilder.InsertData(
                table: "SizeProductFeature",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "ProductFeatureId", "SizeId", "Status" },
                values: new object[] { 1, new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7837), null, true, null, 1, 1, 0 });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 2, new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(8081), null, true, null, "Medium", 0 },
                    { 3, new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(8085), null, true, null, "Large", 0 }
                });

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

            migrationBuilder.InsertData(
                table: "SizeProductFeature",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "ProductFeatureId", "SizeId", "Status" },
                values: new object[] { 2, new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7845), null, true, null, 2, 2, 0 });

            migrationBuilder.InsertData(
                table: "SizeProductFeature",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "ProductFeatureId", "SizeId", "Status" },
                values: new object[] { 3, new DateTime(2023, 10, 25, 12, 38, 45, 383, DateTimeKind.Local).AddTicks(7848), null, true, null, 3, 3, 0 });

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
                name: "FK_ColorProductFeature_Colors_ColorId",
                table: "ColorProductFeature",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColorProductFeature_ProductFeatures_ProductFeatureId",
                table: "ColorProductFeature",
                column: "ProductFeatureId",
                principalTable: "ProductFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ColorProductFeature_Colors_ColorId",
                table: "ColorProductFeature");

            migrationBuilder.DropForeignKey(
                name: "FK_ColorProductFeature_ProductFeatures_ProductFeatureId",
                table: "ColorProductFeature");

            migrationBuilder.DropTable(
                name: "SizeProductFeature");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ColorProductFeature",
                table: "ColorProductFeature");

            migrationBuilder.DropIndex(
                name: "IX_ColorProductFeature_ColorId",
                table: "ColorProductFeature");

            migrationBuilder.DropIndex(
                name: "IX_ColorProductFeature_ProductFeatureId",
                table: "ColorProductFeature");

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ColorProductFeature");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "ColorProductFeature");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ColorProductFeature");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "ColorProductFeature");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "ColorProductFeature");

            migrationBuilder.DropColumn(
                name: "ModifiedDate",
                table: "ColorProductFeature");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "ColorProductFeature",
                newName: "ProductFeaturesId");

            migrationBuilder.RenameColumn(
                name: "ProductFeatureId",
                table: "ColorProductFeature",
                newName: "ColorsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ColorProductFeature",
                table: "ColorProductFeature",
                columns: new[] { "ColorsId", "ProductFeaturesId" });

            migrationBuilder.CreateTable(
                name: "ProductFeatureSize",
                columns: table => new
                {
                    ProductFeaturesId = table.Column<int>(type: "int", nullable: false),
                    SizesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatureSize", x => new { x.ProductFeaturesId, x.SizesId });
                    table.ForeignKey(
                        name: "FK_ProductFeatureSize_ProductFeatures_ProductFeaturesId",
                        column: x => x.ProductFeaturesId,
                        principalTable: "ProductFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductFeatureSize_Sizes_SizesId",
                        column: x => x.SizesId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(1990));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(2797));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(2990));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(2992));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(2993));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(3214));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(3776));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(3785));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(3944));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(3947));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(3951));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(4174));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(4549));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 24, 13, 29, 43, 129, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.CreateIndex(
                name: "IX_ColorProductFeature_ProductFeaturesId",
                table: "ColorProductFeature",
                column: "ProductFeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatureSize_SizesId",
                table: "ProductFeatureSize",
                column: "SizesId");

            migrationBuilder.AddForeignKey(
                name: "FK_ColorProductFeature_Colors_ColorsId",
                table: "ColorProductFeature",
                column: "ColorsId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ColorProductFeature_ProductFeatures_ProductFeaturesId",
                table: "ColorProductFeature",
                column: "ProductFeaturesId",
                principalTable: "ProductFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
