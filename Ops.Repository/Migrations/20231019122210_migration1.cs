using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ProductFeatures");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ProductFeatures");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "ProductFeatures");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Counties");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Counties");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Counties");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "Addresses");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ProductFeatures",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "ProductFeatures",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "ProductFeatures",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Counties",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Counties",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Counties",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DeletedBy",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(744), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(755), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1099), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1204), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1207), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1209), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1362), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1366), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1460), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1462), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1464), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1465), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1558), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1561), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1562), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Counties",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1563), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1659), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1838), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1939), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1941), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1943), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1944), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(2034), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(2036), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(2099), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(2101), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "ProductFeatures",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(2102), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(2198), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(2203), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(2204), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(2206), "admin", "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "CreatedDate", "DeletedBy", "ModifiedBy" },
                values: new object[] { "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(2207), "admin", "admin" });
        }
    }
}
