using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gr4WebshopIncReact.Data.Migrations
{
    public partial class Changedimagedestinationvariablenaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageDesitination");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a8e7701-8109-446e-b2eb-1721cb6282f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "992ebb90-3cfe-4215-b67e-d6971d230b79");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "06403ec9-f4e3-4855-ab78-4a441e031b43", "03962af2-82fd-4ea0-86f9-fc94b2097de2" });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("37e9d6f2-3b17-4bde-b64e-e0baec728504"), new Guid("752d7b13-d78f-4d0c-9c05-f3d678cc450b") });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("37e9d6f2-3b17-4bde-b64e-e0baec728504"), new Guid("9682d401-9410-4c90-baec-84885d8ef870") });

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumns: new[] { "MainKey", "SubKey" },
                keyValues: new object[] { new Guid("752d7b13-d78f-4d0c-9c05-f3d678cc450b"), new Guid("9682d401-9410-4c90-baec-84885d8ef870") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "03962af2-82fd-4ea0-86f9-fc94b2097de2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06403ec9-f4e3-4855-ab78-4a441e031b43");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("752d7b13-d78f-4d0c-9c05-f3d678cc450b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9682d401-9410-4c90-baec-84885d8ef870"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("37e9d6f2-3b17-4bde-b64e-e0baec728504"));

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: new Guid("a9831f8c-8527-4784-8b9f-15e2a3735b9b"));

            migrationBuilder.CreateTable(
                name: "ImageDestination",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Path = table.Column<string>(nullable: true),
                    ProductKey = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageDestination", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageDestination_Products_ProductKey",
                        column: x => x.ProductKey,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1df6b271-ce04-4523-8525-d889f008e9f6", "b2fe2e13-1c54-4fa6-bf53-99913843445e", "Admin", "ADMIN" },
                    { "0d9c2ba5-23c2-4c4e-a377-8ae56d8cb409", "4c3c7d8f-e00c-4288-b83e-d531df93f85a", "User", "USER" },
                    { "c4a6cbb9-3d80-4251-a892-818ae6de53c9", "0da76204-bc62-4559-8bd1-9f2dab5384b1", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "76c10141-8753-4e20-b617-3acc01e0aec2", 0, "AdminTown 1A", "a66629c9-2a9d-4100-a58c-5ae5dcebfef3", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEBVkpS8ePBHdKpBqWbowTW4Tw3WXJAB8RZIrP8MpnB9Pkfo9aZQu/YggrzQJazkXYQ==", null, false, "b88c120f-b1d6-4bdc-a1c2-58b61a13fb45", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "isMainCateGory" },
                values: new object[,]
                {
                    { new Guid("aae108dd-930e-478d-b929-97ff5b301ec2"), "Kitchen", true },
                    { new Guid("41355b91-3a64-4f77-82bd-8fafb0f4be3d"), "Chairs", false }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "Data", "ProductKey" },
                values: new object[] { new Guid("52f5be8a-f163-4e33-8287-7b4a70b5d2d0"), "Height: 1.3m, Width: 0.7m, Depth: 0.7m", new Guid("b32c8754-a351-4dce-b729-34b8aa7dd1a5") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "76c10141-8753-4e20-b617-3acc01e0aec2", "1df6b271-ce04-4523-8525-d889f008e9f6" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CoverImageDestination", "DateStocked", "Description", "DetailsKey", "Name", "Price", "SaleAmount", "SalePercentage", "Storage" },
                values: new object[] { new Guid("b32c8754-a351-4dce-b729-34b8aa7dd1a5"), "GR4Inc", "/404.png", new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "Low hanging fruit chair.", new Guid("52f5be8a-f163-4e33-8287-7b4a70b5d2d0"), "Stolencius", 500.0, 50.0, 10.0, 38 });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "MainKey", "SubKey", "SubCatId" },
                values: new object[] { new Guid("aae108dd-930e-478d-b929-97ff5b301ec2"), new Guid("41355b91-3a64-4f77-82bd-8fafb0f4be3d"), null });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("b32c8754-a351-4dce-b729-34b8aa7dd1a5"), new Guid("41355b91-3a64-4f77-82bd-8fafb0f4be3d") });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("b32c8754-a351-4dce-b729-34b8aa7dd1a5"), new Guid("aae108dd-930e-478d-b929-97ff5b301ec2") });

            migrationBuilder.CreateIndex(
                name: "IX_ImageDestination_ProductKey",
                table: "ImageDestination",
                column: "ProductKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageDestination");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d9c2ba5-23c2-4c4e-a377-8ae56d8cb409");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4a6cbb9-3d80-4251-a892-818ae6de53c9");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "76c10141-8753-4e20-b617-3acc01e0aec2", "1df6b271-ce04-4523-8525-d889f008e9f6" });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("b32c8754-a351-4dce-b729-34b8aa7dd1a5"), new Guid("41355b91-3a64-4f77-82bd-8fafb0f4be3d") });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("b32c8754-a351-4dce-b729-34b8aa7dd1a5"), new Guid("aae108dd-930e-478d-b929-97ff5b301ec2") });

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumns: new[] { "MainKey", "SubKey" },
                keyValues: new object[] { new Guid("aae108dd-930e-478d-b929-97ff5b301ec2"), new Guid("41355b91-3a64-4f77-82bd-8fafb0f4be3d") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1df6b271-ce04-4523-8525-d889f008e9f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76c10141-8753-4e20-b617-3acc01e0aec2");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("41355b91-3a64-4f77-82bd-8fafb0f4be3d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aae108dd-930e-478d-b929-97ff5b301ec2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b32c8754-a351-4dce-b729-34b8aa7dd1a5"));

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: new Guid("52f5be8a-f163-4e33-8287-7b4a70b5d2d0"));

            migrationBuilder.CreateTable(
                name: "ImageDesitination",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImageDestination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageDesitination", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageDesitination_Products_ProductKey",
                        column: x => x.ProductKey,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "03962af2-82fd-4ea0-86f9-fc94b2097de2", "56f24ea1-7cb0-4124-a50e-d7f08a56872a", "Admin", "ADMIN" },
                    { "992ebb90-3cfe-4215-b67e-d6971d230b79", "d4ef478b-07fd-4e0e-8107-d6526061fd57", "User", "USER" },
                    { "1a8e7701-8109-446e-b2eb-1721cb6282f6", "18d4f4e4-aa92-46f8-9b34-5a1f3c7797c1", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "06403ec9-f4e3-4855-ab78-4a441e031b43", 0, "AdminTown 1A", "c943e778-8c81-4fda-9ff7-1985b26074be", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEJ/e2cwCdyt8uezGDUGHXzUSu+FifVXWGPv1Nv2gNuXiHcoGinEXaab1v5RA/uPlbw==", null, false, "4adecc26-683b-4988-9137-aa96eb8b030b", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "isMainCateGory" },
                values: new object[,]
                {
                    { new Guid("752d7b13-d78f-4d0c-9c05-f3d678cc450b"), "Kitchen", true },
                    { new Guid("9682d401-9410-4c90-baec-84885d8ef870"), "Chairs", false }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "Data", "ProductKey" },
                values: new object[] { new Guid("a9831f8c-8527-4784-8b9f-15e2a3735b9b"), "Height: 1.3m, Width: 0.7m, Depth: 0.7m", new Guid("37e9d6f2-3b17-4bde-b64e-e0baec728504") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "06403ec9-f4e3-4855-ab78-4a441e031b43", "03962af2-82fd-4ea0-86f9-fc94b2097de2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CoverImageDestination", "DateStocked", "Description", "DetailsKey", "Name", "Price", "SaleAmount", "SalePercentage", "Storage" },
                values: new object[] { new Guid("37e9d6f2-3b17-4bde-b64e-e0baec728504"), "GR4Inc", "/404.png", new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "Low hanging fruit chair.", new Guid("a9831f8c-8527-4784-8b9f-15e2a3735b9b"), "Stolencius", 500.0, 50.0, 10.0, 38 });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "MainKey", "SubKey", "SubCatId" },
                values: new object[] { new Guid("752d7b13-d78f-4d0c-9c05-f3d678cc450b"), new Guid("9682d401-9410-4c90-baec-84885d8ef870"), null });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("37e9d6f2-3b17-4bde-b64e-e0baec728504"), new Guid("9682d401-9410-4c90-baec-84885d8ef870") });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("37e9d6f2-3b17-4bde-b64e-e0baec728504"), new Guid("752d7b13-d78f-4d0c-9c05-f3d678cc450b") });

            migrationBuilder.CreateIndex(
                name: "IX_ImageDesitination_ProductKey",
                table: "ImageDesitination",
                column: "ProductKey");
        }
    }
}
