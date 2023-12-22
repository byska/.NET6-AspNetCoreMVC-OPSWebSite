using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class _201223Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "Amount",
                table: "Products",
                newName: "TotalAmount");

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "ProductOrder",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ShipCode",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 11, 16, 11, 825, DateTimeKind.Local).AddTicks(5404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 16, 18, 19, 108, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 20, 11, 16, 11, 825, DateTimeKind.Local).AddTicks(5095),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 19, 16, 18, 19, 108, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4363));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4532));

            migrationBuilder.UpdateData(
                table: "ColorProduct",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4589));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4679));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4680));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4684));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4687));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4768));

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4769));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "HomeSlider",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5002));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amount", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amount", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "CreatedDate" },
                values: new object[] { 1, new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "ProductOrder",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amount", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5224), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5229), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5231), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5232), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5234), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5235), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5236), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5237), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5238), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5239), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5242), null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "TotalAmount" },
                values: new object[] { new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5243), null });

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "SizeProduct",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 20, 11, 16, 11, 826, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressId",
                table: "Orders",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AddressId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "ProductOrder");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ShipCode",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "Products",
                newName: "Amount");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 16, 18, 19, 108, DateTimeKind.Local).AddTicks(6115),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 11, 16, 11, 825, DateTimeKind.Local).AddTicks(5404));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetRoles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 19, 16, 18, 19, 108, DateTimeKind.Local).AddTicks(5852),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 20, 11, 16, 11, 825, DateTimeKind.Local).AddTicks(5095));

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
                columns: new[] { "Amount", "CreatedDate" },
                values: new object[] { 200, new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amount", "CreatedDate" },
                values: new object[] { 10, new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7063) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "CreatedDate" },
                values: new object[] { 2, new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7064) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Amount", "CreatedDate" },
                values: new object[] { 20, new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Amount", "CreatedDate" },
                values: new object[] { 20, new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Amount", "CreatedDate" },
                values: new object[] { 20, new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Amount", "CreatedDate" },
                values: new object[] { 20, new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7068) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Amount", "CreatedDate" },
                values: new object[] { 100, new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Amount", "CreatedDate" },
                values: new object[] { 10, new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Amount", "CreatedDate" },
                values: new object[] { 10, new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Amount", "CreatedDate" },
                values: new object[] { 10, new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Amount", "CreatedDate" },
                values: new object[] { 10, new DateTime(2023, 12, 19, 16, 18, 19, 109, DateTimeKind.Local).AddTicks(7103) });

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
    }
}
