using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class Init090124 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 1, 9, 13, 28, 16, 355, DateTimeKind.Local).AddTicks(8120)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 1, 9, 13, 28, 16, 355, DateTimeKind.Local).AddTicks(8458)),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PersonelDataProtection = table.Column<bool>(type: "bit", nullable: true),
                    MembershipAgreement = table.Column<bool>(type: "bit", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HomeSlider",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Subtitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeSlider", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeSlider_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
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
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Photos_Products_ProductId",
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
                    Description = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Stocks = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stocks_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stocks_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    ZIP = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CountyId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderStatus = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ShipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductOrder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductOrder_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductOrder_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "DisplayName", "IsActive", "ModifiedDate", "Name", "NormalizedName", "Status" },
                values: new object[,]
                {
                    { 1, "cb32556e-d001-4f09-a928-da6cb70902e5", new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9846), null, "Yönetici", true, null, "admin", "ADMIN", 1 },
                    { 2, "b11d9df7-a576-4018-8531-07e22cf9f911", new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9852), null, "Müşteri", true, null, "customer", "CUSTOMER", 1 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDate", "DateOfBirth", "DeletedDate", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "MembershipAgreement", "ModifiedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PersonelDataProtection", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "e98e201c-1b67-4303-931e-24ff81686009", new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8911), new DateTime(1998, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "besteyasak@gmail.com", false, "Beste", true, "Yasak", false, null, null, null, null, null, "Beste1998.", null, "05362459825", false, null, 1, false, "d8ec1599-bcb1-470c-9523-2db3c08251a4" },
                    { 2, 0, "f591e50a-0a57-49d1-b3a9-20b970380de9", new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8968), new DateTime(1997, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "huseyingulerman.1997@gmail.com", false, "Hüseyin", true, "Gülerman", false, null, null, null, null, null, "Beste1998.", null, "05325841236", false, null, 1, false, "7a7ed1e2-4350-4668-82b9-419252debe4e" },
                    { 3, 0, "12275daf-fa10-4004-8b9e-a956b636d3bb", new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8988), new DateTime(1997, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "orangepressstore@gmail.com", false, "Ayşe", true, "Tabak", false, null, null, null, null, null, "Beste1998.", null, "05325841236", false, null, 1, false, "df82068f-00b6-4cfd-9c42-b9fc5de77a2c" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8313), null, true, null, "Tişört Regular", 1 },
                    { 2, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8316), null, true, null, "Tişört Oversize", 1 },
                    { 3, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8317), null, true, null, "Hoodie", 1 },
                    { 4, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8318), null, true, null, "Sweatshirt", 1 },
                    { 5, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8319), null, true, null, "Kol Çantası", 1 },
                    { 6, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8320), null, true, null, "Cüzdan", 1 },
                    { 7, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8321), null, true, null, "Baf", 1 }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8403), null, true, null, "Istanbul", 1 },
                    { 2, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8407), null, true, null, "Ankara", 1 }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8629), null, true, null, "Black", 0 },
                    { 2, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8634), null, true, null, "Blue", 0 },
                    { 3, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8636), null, true, null, "Yellow", 0 },
                    { 4, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8637), null, true, null, "Somon", 0 },
                    { 5, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8639), null, true, null, "Gray", 0 },
                    { 6, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8641), null, true, null, "Green", 0 },
                    { 7, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8643), null, true, null, "Beige", 0 },
                    { 8, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8645), null, true, null, "White", 0 },
                    { 9, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8646), null, true, null, "Orange", 0 }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "Email", "IsActive", "ModifiedDate", "Name", "Status", "Subject" },
                values: new object[] { 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9175), null, "Fiziksel bir mağazanız bulunuyor mu acaba?", "beyasak@hotmail.com", true, null, "Beste", 0, "Bilgi Alma" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 9, 13, 28, 16, 357, DateTimeKind.Local).AddTicks(67), null, true, null, "Small", 0 },
                    { 2, new DateTime(2024, 1, 9, 13, 28, 16, 357, DateTimeKind.Local).AddTicks(70), null, true, null, "Medium", 0 },
                    { 3, new DateTime(2024, 1, 9, 13, 28, 16, 357, DateTimeKind.Local).AddTicks(72), null, true, null, "Large", 0 }
                });

            migrationBuilder.InsertData(
                table: "Counties",
                columns: new[] { "Id", "CityId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8838), null, true, null, "Fatih", 1 },
                    { 2, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8841), null, true, null, "Üsküdar", 1 },
                    { 3, 2, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8842), null, true, null, "Kızılay", 1 },
                    { 4, 2, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8843), null, true, null, "Çankaya", 1 }
                });

            migrationBuilder.InsertData(
                table: "HomeSlider",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "PhotoUrl", "Status", "Subtitle", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9064), null, true, null, "img/bg-img/bg-1.jpg", 1, "Eşsiz Bahar Koleksiyonumuza Bir Göz Gezdirin.", "Bahar Koleksiyonu" },
                    { 2, 2, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9066), null, true, null, "img/bg-img/bg-2.jpg", 1, "29 Ekime Özel Kargo Bedava.", "Kargo Bedava" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "Price", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9679), null, true, null, "Tişört", 200m, 1, null },
                    { 2, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9686), null, true, null, "Tişört", 150m, 1, null },
                    { 3, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9687), null, true, null, "Tişört", 300m, 1, null },
                    { 4, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9717), null, true, null, "Tişört", 300m, 1, null },
                    { 5, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9719), null, true, null, "Tişört", 300m, 1, null },
                    { 6, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9720), null, true, null, "Tişört", 400m, 1, null },
                    { 7, 3, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9721), null, true, null, "Hoodie", 400m, 1, null },
                    { 8, 3, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9722), null, true, null, "Hoodie", 500m, 1, null },
                    { 9, 3, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9724), null, true, null, "Hoodie", 250m, 1, null },
                    { 10, 3, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9725), null, true, null, "Hoodie", 350m, 1, null },
                    { 11, 3, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9726), null, true, null, "Hoodie", 450m, 1, null },
                    { 12, 3, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9727), null, true, null, "Hoodie", 1050m, 1, null },
                    { 13, 4, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9729), null, true, null, "Sweat", 1050m, 1, null },
                    { 14, 4, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9730), null, true, null, "Sweat", 1050m, 1, null },
                    { 15, 4, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9731), null, true, null, "Sweat", 1050m, 1, null },
                    { 16, 4, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9732), null, true, null, "Sweat", 1050m, 1, null },
                    { 17, 4, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9733), null, true, null, "Sweat", 1050m, 1, null },
                    { 18, 4, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9735), null, true, null, "Sweat", 1050m, 1, null },
                    { 19, 7, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9736), null, true, null, "Baf", 400m, 1, null },
                    { 20, 5, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9737), null, true, null, "Çanta", 400m, 1, null },
                    { 21, 6, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9765), null, true, null, "Cüzdan", 400m, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "CityId", "CountyId", "CreatedDate", "CustomerId", "DeletedDate", "Description", "FirstName", "IsActive", "LastName", "ModifiedDate", "PhoneNumber", "Status", "ZIP" },
                values: new object[,]
                {
                    { 1, 2, 3, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8124), 1, null, "Üsküdar metrobüse yakın", "Beste", true, "Yasak", null, "05360249093", 1, "34700" },
                    { 2, 1, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8130), 2, null, "Acıbadem metroya yakın", "Hüseyin", true, "Gülerman", null, "05360249093", 1, "34700" }
                });

            migrationBuilder.InsertData(
                table: "ColorProduct",
                columns: new[] { "Id", "ColorId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8488), null, true, null, 1, 0 },
                    { 2, 2, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8494), null, true, null, 2, 0 },
                    { 3, 6, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8496), null, true, null, 3, 0 },
                    { 4, 7, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8497), null, true, null, 4, 0 },
                    { 5, 5, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8499), null, true, null, 5, 0 },
                    { 6, 7, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8531), null, true, null, 6, 0 },
                    { 7, 6, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8533), null, true, null, 7, 0 },
                    { 8, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8535), null, true, null, 8, 0 },
                    { 9, 6, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8536), null, true, null, 9, 0 },
                    { 10, 7, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8539), null, true, null, 10, 0 },
                    { 11, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8541), null, true, null, 11, 0 },
                    { 12, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8542), null, true, null, 12, 0 },
                    { 13, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8544), null, true, null, 13, 0 },
                    { 14, 8, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8545), null, true, null, 14, 0 },
                    { 15, 7, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8546), null, true, null, 15, 0 },
                    { 16, 6, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8548), null, true, null, 16, 0 },
                    { 17, 9, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8549), null, true, null, 17, 0 },
                    { 18, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8551), null, true, null, 18, 0 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "DeletedDate", "Description", "IsActive", "Mark", "ModifiedDate", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8757), 1, null, "Çok güzel ürünler", true, 5, null, 1, 1 },
                    { 2, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8759), 1, null, "Çok güzel ürünler", true, 4, null, 2, 1 },
                    { 3, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8760), 2, null, "Çok güzel ürünler", true, 5, null, 1, 1 },
                    { 4, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8761), 2, null, "Çok güzel ürünler", true, 5, null, 2, 1 },
                    { 5, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8762), 1, null, "Çok demode", true, 1, null, 1, 1 },
                    { 6, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8762), 2, null, "Kibar duruyor ama pahalı", true, 2, null, 1, 1 },
                    { 7, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8763), 1, null, "Ehhhhh fena sayılmaz. Birdaha almam ama. :)", true, 3, null, 1, 1 },
                    { 8, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8764), 2, null, "Çok güzel ürünler. Baya beğendim. Alınır", true, 4, null, 1, 1 },
                    { 9, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8765), 1, null, "Çok güzel ürünler.Bayıldım. Herkese tavsiye ederim.", true, 5, null, 1, 1 },
                    { 10, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8766), 1, null, "Çok güzel ürünler.Bayıldım. Herkese tavsiye ederim.", true, 2, null, 1, 1 },
                    { 11, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8766), 1, null, "Çok güzel ürünler.Bayıldım. Herkese tavsiye ederim.", true, 5, null, 1, 1 },
                    { 12, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8767), 1, null, "Çok güzel ürünler.Bayıldım. Herkese tavsiye ederim.", true, 1, null, 1, 1 },
                    { 13, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(8768), 1, null, "Çok güzel ürünler.Bayıldım. Herkese tavsiye ederim.", true, 2, null, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "ColorId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "PhotoUrl", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9341), null, true, null, "tişört1.jpeg", 1, 0 },
                    { 2, 2, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9346), null, true, null, "tişört2.jpeg", 2, 0 },
                    { 3, 6, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9347), null, true, null, "tişört3.jpeg", 3, 0 },
                    { 4, 7, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9349), null, true, null, "tişört4.jpeg", 4, 0 },
                    { 5, 5, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9351), null, true, null, "tişört5.jpeg", 5, 0 },
                    { 6, 7, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9353), null, true, null, "tişört6.jpeg", 6, 0 },
                    { 7, 6, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9355), null, true, null, "hoodie1.jpeg", 7, 0 },
                    { 8, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9357), null, true, null, "hoodie2.jpeg", 8, 0 },
                    { 9, 6, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9358), null, true, null, "hoodie3.jpeg", 9, 0 }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "ColorId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "PhotoUrl", "ProductId", "Status" },
                values: new object[,]
                {
                    { 10, 7, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9360), null, true, null, "hoodie4.jpeg", 10, 0 },
                    { 11, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9362), null, true, null, "hoodie5.jpeg", 11, 0 },
                    { 12, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9363), null, true, null, "hoodie6.jpeg", 12, 0 },
                    { 13, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9365), null, true, null, "sweat1.jpeg", 13, 0 },
                    { 14, 8, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9366), null, true, null, "sweat2.jpeg", 14, 0 },
                    { 15, 7, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9368), null, true, null, "sweat3.jpeg", 15, 0 },
                    { 16, 6, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9369), null, true, null, "sweat4.jpeg", 16, 0 },
                    { 17, 9, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9370), null, true, null, "sweat5.jpeg", 17, 0 },
                    { 18, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9373), null, true, null, "sweat6.jpeg", 18, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "IsActive", "ModifiedDate", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9488), null, "30 derecede yıkayınız", true, null, 1, 1 },
                    { 2, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9489), null, "30 derecede yıkayınız", true, null, 2, 1 },
                    { 3, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9490), null, "30 derecede yıkayınız", true, null, 3, 1 },
                    { 4, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9491), null, "30 derecede yıkayınız", true, null, 4, 1 },
                    { 5, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9492), null, "30 derecede yıkayınız", true, null, 5, 1 },
                    { 6, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9492), null, "30 derecede yıkayınız", true, null, 6, 1 },
                    { 7, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9493), null, "30 derecede yıkayınız", true, null, 7, 1 },
                    { 8, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9494), null, "30 derecede yıkayınız", true, null, 8, 1 },
                    { 9, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9494), null, "30 derecede yıkayınız", true, null, 9, 1 },
                    { 10, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9495), null, "30 derecede yıkayınız", true, null, 10, 1 },
                    { 11, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9496), null, "30 derecede yıkayınız", true, null, 11, 1 },
                    { 12, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9497), null, "30 derecede yıkayınız", true, null, 12, 1 },
                    { 13, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9497), null, "30 derecede yıkayınız", true, null, 13, 1 },
                    { 14, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9498), null, "30 derecede yıkayınız", true, null, 14, 1 },
                    { 15, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9499), null, "30 derecede yıkayınız", true, null, 15, 1 },
                    { 16, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9499), null, "30 derecede yıkayınız", true, null, 16, 1 },
                    { 17, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9500), null, "30 derecede yıkayınız", true, null, 17, 1 },
                    { 18, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9501), null, "30 derecede yıkayınız", true, null, 18, 1 },
                    { 19, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9502), null, "30 derecede yıkayınız", true, null, 19, 1 },
                    { 20, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9502), null, "30 derecede yıkayınız", true, null, 20, 1 },
                    { 21, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9503), null, "30 derecede yıkayınız", true, null, 21, 1 }
                });

            migrationBuilder.InsertData(
                table: "SizeProduct",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "ProductId", "SizeId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9923), null, true, null, 1, 1, 0 },
                    { 2, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9926), null, true, null, 1, 2, 0 },
                    { 3, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9928), null, true, null, 1, 3, 0 },
                    { 4, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9929), null, true, null, 2, 1, 0 },
                    { 5, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9931), null, true, null, 2, 2, 0 },
                    { 6, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9933), null, true, null, 2, 3, 0 },
                    { 7, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9935), null, true, null, 3, 1, 0 },
                    { 8, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9936), null, true, null, 3, 2, 0 },
                    { 9, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9938), null, true, null, 3, 3, 0 },
                    { 10, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9940), null, true, null, 4, 1, 0 },
                    { 11, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9941), null, true, null, 4, 3, 0 },
                    { 12, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9943), null, true, null, 5, 1, 0 }
                });

            migrationBuilder.InsertData(
                table: "SizeProduct",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "ProductId", "SizeId", "Status" },
                values: new object[,]
                {
                    { 13, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9944), null, true, null, 5, 2, 0 },
                    { 14, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9945), null, true, null, 6, 1, 0 },
                    { 15, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9947), null, true, null, 6, 2, 0 },
                    { 16, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9948), null, true, null, 6, 3, 0 },
                    { 17, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9949), null, true, null, 7, 1, 0 },
                    { 18, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9951), null, true, null, 8, 2, 0 },
                    { 19, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9953), null, true, null, 9, 2, 0 },
                    { 20, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9954), null, true, null, 10, 1, 0 },
                    { 21, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9983), null, true, null, 10, 2, 0 },
                    { 22, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9985), null, true, null, 10, 3, 0 },
                    { 23, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9987), null, true, null, 11, 2, 0 },
                    { 24, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9988), null, true, null, 11, 3, 0 },
                    { 25, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9989), null, true, null, 12, 3, 0 },
                    { 26, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9991), null, true, null, 13, 3, 0 },
                    { 27, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9992), null, true, null, 14, 1, 0 },
                    { 28, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9994), null, true, null, 15, 1, 0 },
                    { 29, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9995), null, true, null, 15, 3, 0 },
                    { 30, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9997), null, true, null, 16, 1, 0 },
                    { 31, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9998), null, true, null, 17, 2, 0 },
                    { 32, new DateTime(2024, 1, 9, 13, 28, 16, 357, DateTimeKind.Local), null, true, null, 18, 3, 0 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "ColorId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "ProductId", "SizeId", "Status", "Stocks" },
                values: new object[,]
                {
                    { 30, 6, new DateTime(2024, 1, 9, 13, 28, 16, 357, DateTimeKind.Local).AddTicks(224), null, true, null, 16, 1, 0, 20 },
                    { 31, 9, new DateTime(2024, 1, 9, 13, 28, 16, 357, DateTimeKind.Local).AddTicks(226), null, true, null, 17, 2, 0, 20 },
                    { 32, 1, new DateTime(2024, 1, 9, 13, 28, 16, 357, DateTimeKind.Local).AddTicks(227), null, true, null, 18, 3, 0, 20 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "CreatedDate", "CustomerId", "DeletedDate", "IsActive", "ModifiedDate", "OrderStatus", "ShipCode", "Status", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9256), 1, null, true, null, 1, null, 1, 0m },
                    { 2, 2, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9258), 1, null, true, null, 4, null, 1, 0m },
                    { 3, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9259), 1, null, true, null, 3, null, 1, 0m },
                    { 4, 2, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9260), 2, null, true, null, 2, null, 1, 0m }
                });

            migrationBuilder.InsertData(
                table: "ProductOrder",
                columns: new[] { "Id", "Amount", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "OrderId", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9597), null, true, null, 1, 1, 0 },
                    { 2, 2, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9599), null, true, null, 1, 2, 0 },
                    { 3, 1, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9600), null, true, null, 2, 3, 0 },
                    { 4, 2, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9601), null, true, null, 2, 2, 0 },
                    { 5, 2, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9602), null, true, null, 3, 4, 0 },
                    { 6, 2, new DateTime(2024, 1, 9, 13, 28, 16, 356, DateTimeKind.Local).AddTicks(9602), null, true, null, 4, 5, 0 }
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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ColorProduct_ColorId",
                table: "ColorProduct",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_ColorProduct_ProductId",
                table: "ColorProduct",
                column: "ProductId");

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
                name: "IX_HomeSlider_CategoryId",
                table: "HomeSlider",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressId",
                table: "Orders",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ColorId",
                table: "Photos",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ProductId",
                table: "Photos",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductId",
                table: "ProductFeatures",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrder_OrderId",
                table: "ProductOrder",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductOrder_ProductId",
                table: "ProductOrder",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SizeProduct_ProductId",
                table: "SizeProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SizeProduct_SizeId",
                table: "SizeProduct",
                column: "SizeId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ColorProduct");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "HomeSlider");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "ProductOrder");

            migrationBuilder.DropTable(
                name: "SizeProduct");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Counties");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
