using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Counties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Counties_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Mark = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CountyId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Addresses_Counties_CountyId",
                        column: x => x.CountyId,
                        principalTable: "Counties",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Addresses_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Email", "FirstName", "IsActive", "LastName", "ModifiedBy", "ModifiedDate", "Password", "Status" },
                values: new object[] { 1, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1099), "admin", null, "orangepressstore@gmail.com", "Ayşe Nur", true, "Tabak", "admin", null, "Beste1998.", 1 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1204), "admin", null, true, "admin", null, "Tişört", 1 },
                    { 2, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1207), "admin", null, true, "admin", null, "Sweat", 1 },
                    { 3, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1209), "admin", null, true, "admin", null, "Çanta", 1 }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1362), "admin", null, true, "admin", null, "Istanbul", 1 },
                    { 2, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1366), "admin", null, true, "admin", null, "Ankara", 1 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DateOfBirth", "DeletedBy", "DeletedDate", "Email", "FirstName", "IsActive", "LastName", "ModifiedBy", "ModifiedDate", "Password", "PhoneNumber", "Status" },
                values: new object[,]
                {
                    { 1, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1659), new DateTime(1998, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", null, "besteyasak@gmail.com", "Beste", true, "Yasak", "admin", null, "Beste1998.", "05362459825", 1 },
                    { 2, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1838), new DateTime(1997, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", null, "huseyingulerman.1997@gmail.com", "Hüseyin", true, "Gülerman", "admin", null, "Beste1998.", "05325841236", 1 }
                });

            migrationBuilder.InsertData(
                table: "Counties",
                columns: new[] { "Id", "CityId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, 1, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1558), "admin", null, true, "admin", null, "Fatih", 1 },
                    { 2, 1, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1561), "admin", null, true, "admin", null, "Üsküdar", 1 },
                    { 3, 2, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1562), "admin", null, true, "admin", null, "Kızılay", 1 },
                    { 4, 2, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1563), "admin", null, true, "admin", null, "Çankaya", 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "Price", "Status", "Stock" },
                values: new object[,]
                {
                    { 1, 1, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(2198), "admin", null, true, "admin", null, "Tişört", 200m, 1, 20 },
                    { 2, 1, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(2203), "admin", null, true, "admin", null, "Kısa Kollu Tişört", 150m, 1, 20 },
                    { 3, 1, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(2204), "admin", null, true, "admin", null, " Uzun Kollu Tişört", 300m, 1, 20 },
                    { 4, 3, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(2206), "admin", null, true, "admin", null, "Çanta", 400m, 1, 20 },
                    { 5, 2, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(2207), "admin", null, true, "admin", null, "Sweat", 500m, 1, 20 }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "CityId", "CountyId", "CreatedBy", "CreatedDate", "CustomerId", "DeletedBy", "DeletedDate", "Description", "IsActive", "ModifiedBy", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, 1, 1, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(744), 1, "admin", null, "Üsküdar metrobüse yakın", true, "admin", null, 1 },
                    { 2, 1, 1, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(755), 2, "admin", null, "Acıbadem metroya yakın", true, "admin", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "DeletedBy", "DeletedDate", "Description", "IsActive", "Mark", "ModifiedBy", "ModifiedDate", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1460), 1, "admin", null, "Çok güzel ürünler", true, 5, "admin", null, 1, 1 },
                    { 2, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1462), 1, "admin", null, "Çok güzel ürünler", true, 4, "admin", null, 2, 1 },
                    { 3, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1464), 2, "admin", null, "Çok güzel ürünler", true, 5, "admin", null, 1, 1 },
                    { 4, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1465), 2, "admin", null, "Çok güzel ürünler", true, 5, "admin", null, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "DeletedBy", "DeletedDate", "IsActive", "ModifiedBy", "ModifiedDate", "OrderStatus", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1939), 1, "admin", null, true, "admin", null, 1, 1, 1 },
                    { 2, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1941), 1, "admin", null, true, "admin", null, 4, 2, 1 },
                    { 3, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1943), 1, "admin", null, true, "admin", null, 3, 3, 1 },
                    { 4, "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(1944), 2, "admin", null, true, "admin", null, 2, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "Color", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "Description", "IsActive", "ModifiedBy", "ModifiedDate", "ProductId", "Size", "Status" },
                values: new object[,]
                {
                    { 1, "Sarı", "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(2034), "admin", null, "30 derecede yıkayınız", true, "admin", null, 1, 4, 1 },
                    { 2, "Mavi", "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(2036), "admin", null, "30 derecede yıkayınız", true, "admin", null, 2, 2, 1 },
                    { 3, "Beyaz", "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(2099), "admin", null, "30 derecede yıkayınız", true, "admin", null, 3, 5, 1 },
                    { 4, "Beyaz", "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(2101), "admin", null, "30 derecede yıkayınız", true, "admin", null, 4, 5, 1 },
                    { 5, "Beyaz", "admin", new DateTime(2023, 10, 5, 17, 4, 1, 106, DateTimeKind.Local).AddTicks(2102), "admin", null, "30 derecede yıkayınız", true, "admin", null, 5, 5, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CountyId",
                table: "Addresses",
                column: "CountyId");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CustomerId",
                table: "Addresses",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CustomerId",
                table: "Comments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Counties_CityId",
                table: "Counties",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductId",
                table: "Orders",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductId",
                table: "ProductFeatures",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "Counties");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
