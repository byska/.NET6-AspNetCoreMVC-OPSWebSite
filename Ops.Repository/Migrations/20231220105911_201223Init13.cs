﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ops.Repository.Migrations
{
    public partial class _201223Init13 : Migration
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 12, 20, 13, 59, 11, 569, DateTimeKind.Local).AddTicks(5714)),
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
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 12, 20, 13, 59, 11, 569, DateTimeKind.Local).AddTicks(5999)),
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
                    ZIP = table.Column<int>(type: "int", maxLength: 5, nullable: false),
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
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    ShipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductOrder",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductOrder_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3343), null, true, null, "Tişört Regular", 1 },
                    { 2, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3346), null, true, null, "Tişört Oversize", 1 },
                    { 3, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3347), null, true, null, "Hoodie", 1 },
                    { 4, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3347), null, true, null, "Sweatshirt", 1 },
                    { 5, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3348), null, true, null, "Kol Çantası", 1 },
                    { 6, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3349), null, true, null, "Cüzdan", 1 },
                    { 7, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3349), null, true, null, "Baf", 1 }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3417), null, true, null, "Istanbul", 1 },
                    { 2, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3419), null, true, null, "Ankara", 1 }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3538), null, true, null, "Black", 0 },
                    { 2, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3580), null, true, null, "Blue", 0 },
                    { 3, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3584), null, true, null, "Yellow", 0 }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "Email", "IsActive", "ModifiedDate", "Name", "Status", "Subject" },
                values: new object[] { 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3848), null, "Fiziksel bir mağazanız bulunuyor mu acaba?", "beyasak@hotmail.com", true, null, "Beste", 0, "Bilgi Alma" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "AddressId", "CreatedDate", "CustomerId", "DeletedDate", "IsActive", "ModifiedDate", "OrderStatus", "ShipCode", "Status", "TotalPrice" },
                values: new object[,]
                {
                    { 1, 0, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3932), 1, null, true, null, 1, null, 1, 0m },
                    { 2, 0, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3934), 1, null, true, null, 4, null, 1, 0m },
                    { 3, 0, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3935), 1, null, true, null, 3, null, 1, 0m },
                    { 4, 0, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3936), 2, null, true, null, 2, null, 1, 0m }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4324), null, true, null, "Small", 0 },
                    { 2, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4328), null, true, null, "Medium", 0 },
                    { 3, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4348), null, true, null, "Large", 0 }
                });

            migrationBuilder.InsertData(
                table: "Counties",
                columns: new[] { "Id", "CityId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3715), null, true, null, "Fatih", 1 },
                    { 2, 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3716), null, true, null, "Üsküdar", 1 },
                    { 3, 2, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3717), null, true, null, "Kızılay", 1 },
                    { 4, 2, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3718), null, true, null, "Çankaya", 1 }
                });

            migrationBuilder.InsertData(
                table: "HomeSlider",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "PhotoUrl", "Status", "Subtitle", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3783), null, true, null, "img/bg-img/bg-1.jpg", 1, "Eşsiz Bahar Koleksiyonumuza Bir Göz Gezdirin.", "Bahar Koleksiyonu" },
                    { 2, 2, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3784), null, true, null, "img/bg-img/bg-2.jpg", 1, "29 Ekime Özel Kargo Bedava.", "Kargo Bedava" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "Name", "Price", "Status", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4170), null, true, null, "Tişört", 200m, 1, null },
                    { 2, 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4175), null, true, null, "Kısa Kollu Tişört", 150m, 1, null },
                    { 3, 2, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4196), null, true, null, " Uzun Kollu Tişört", 300m, 1, null },
                    { 4, 5, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4197), null, true, null, "Çanta", 400m, 1, null },
                    { 5, 6, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4198), null, true, null, "Cüzdan", 400m, 1, null },
                    { 6, 3, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4199), null, true, null, "Hoodie", 400m, 1, null },
                    { 7, 7, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4200), null, true, null, "Baf", 400m, 1, null },
                    { 8, 4, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4201), null, true, null, "Sweat", 500m, 1, null },
                    { 9, 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4202), null, true, null, "Kısa Kollu Tişört", 250m, 1, null },
                    { 10, 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4203), null, true, null, "Kısa Kollu Tişört", 350m, 1, null },
                    { 11, 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4204), null, true, null, "Kısa Kollu Tişört", 450m, 1, null },
                    { 12, 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4205), null, true, null, "Kısa Kollu Tişört", 1050m, 1, null }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "CityId", "CountyId", "CreatedDate", "CustomerId", "DeletedDate", "Description", "FirstName", "IsActive", "LastName", "ModifiedDate", "PhoneNumber", "Status", "ZIP" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3217), 1, null, "Üsküdar metrobüse yakın", "Beste", true, "Yasak", null, "05360249093", 1, 34700 },
                    { 2, 1, 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3223), 2, null, "Acıbadem metroya yakın", "Hüseyin", true, "Gülerman", null, "05360249093", 1, 34700 }
                });

            migrationBuilder.InsertData(
                table: "ColorProduct",
                columns: new[] { "Id", "ColorId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3480), null, true, null, 1, 0 },
                    { 2, 2, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3484), null, true, null, 1, 0 },
                    { 3, 2, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3485), null, true, null, 2, 0 },
                    { 4, 2, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3487), null, true, null, 3, 0 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedDate", "CustomerId", "DeletedDate", "Description", "IsActive", "Mark", "ModifiedDate", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3642), 1, null, "Çok güzel ürünler", true, 5, null, 1, 1 },
                    { 2, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3643), 1, null, "Çok güzel ürünler", true, 4, null, 2, 1 },
                    { 3, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3644), 2, null, "Çok güzel ürünler", true, 5, null, 1, 1 },
                    { 4, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3645), 2, null, "Çok güzel ürünler", true, 5, null, 2, 1 },
                    { 5, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3646), 1, null, "Çok demode", true, 1, null, 1, 1 },
                    { 6, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3646), 2, null, "Kibar duruyor ama pahalı", true, 2, null, 1, 1 },
                    { 7, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3647), 1, null, "Ehhhhh fena sayılmaz. Birdaha almam ama. :)", true, 3, null, 1, 1 },
                    { 8, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3648), 2, null, "Çok güzel ürünler. Baya beğendim. Alınır", true, 4, null, 1, 1 },
                    { 9, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3648), 1, null, "Çok güzel ürünler.Bayıldım. Herkese tavsiye ederim.", true, 5, null, 1, 1 },
                    { 10, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3649), 1, null, "Çok güzel ürünler.Bayıldım. Herkese tavsiye ederim.", true, 2, null, 1, 1 },
                    { 11, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3650), 1, null, "Çok güzel ürünler.Bayıldım. Herkese tavsiye ederim.", true, 5, null, 1, 1 },
                    { 12, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3650), 1, null, "Çok güzel ürünler.Bayıldım. Herkese tavsiye ederim.", true, 1, null, 1, 1 },
                    { 13, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3651), 1, null, "Çok güzel ürünler.Bayıldım. Herkese tavsiye ederim.", true, 2, null, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "Id", "ColorId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "PhotoUrl", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3993), null, true, null, "tshirt-1.jpeg", 1, 0 },
                    { 2, 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3995), null, true, null, "tshirt-2.jpeg", 1, 0 },
                    { 3, 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3997), null, true, null, "tshirt-1.jpeg", 1, 0 },
                    { 4, 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3998), null, true, null, "tshirt-2.jpeg", 2, 0 },
                    { 5, 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(3999), null, true, null, "tshirt-1.jpeg", 3, 0 },
                    { 6, 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4001), null, true, null, "tshirt-2.jpeg", 4, 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Description", "IsActive", "ModifiedDate", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4053), null, "30 derecede yıkayınız", true, null, 1, 1 },
                    { 2, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4055), null, "30 derecede yıkayınız", true, null, 2, 1 },
                    { 3, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4056), null, "30 derecede yıkayınız", true, null, 3, 1 },
                    { 4, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4056), null, "30 derecede yıkayınız", true, null, 4, 1 },
                    { 5, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4057), null, "30 derecede yıkayınız", true, null, 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductOrder",
                columns: new[] { "Id", "Amount", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "OrderId", "ProductId", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4115), null, true, null, 1, 1, 0 },
                    { 2, 2, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4116), null, true, null, 1, 2, 0 },
                    { 3, 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4117), null, true, null, 2, 3, 0 },
                    { 4, 2, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4117), null, true, null, 2, 2, 0 },
                    { 5, 2, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4118), null, true, null, 3, 4, 0 },
                    { 6, 2, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4119), null, true, null, 4, 5, 0 }
                });

            migrationBuilder.InsertData(
                table: "SizeProduct",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "ProductId", "SizeId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4265), null, true, null, 1, 1, 0 },
                    { 2, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4268), null, true, null, 2, 2, 0 },
                    { 3, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4270), null, true, null, 3, 3, 0 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "ColorId", "CreatedDate", "DeletedDate", "IsActive", "ModifiedDate", "ProductId", "SizeId", "Status", "Stocks" },
                values: new object[] { 2, 1, new DateTime(2023, 12, 20, 13, 59, 11, 570, DateTimeKind.Local).AddTicks(4415), null, true, null, 2, 1, 0, 20 });

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
