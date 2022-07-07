using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gr4WebshopIncReact.Data.Migrations
{
    public partial class ChangedHowCurrentPriceIsAccessed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71e05030-1a3c-44c1-84dc-69f529e7987b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c5af705-5e01-42c1-b2e8-309837df186c");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b449b8fb-ffe1-49c1-9179-218e15615b70", "921c88df-ac0e-42e3-8718-34ba3539b91d" });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("9802dd12-7c8d-4410-89b2-7a606c1f0783"), new Guid("0d1cf3ff-fc78-4a49-a9de-18125206e2d8") });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("9802dd12-7c8d-4410-89b2-7a606c1f0783"), new Guid("dd4a27de-8737-4370-9b4d-ae6c96691250") });

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumns: new[] { "MainKey", "SubKey" },
                keyValues: new object[] { new Guid("0d1cf3ff-fc78-4a49-a9de-18125206e2d8"), new Guid("dd4a27de-8737-4370-9b4d-ae6c96691250") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "921c88df-ac0e-42e3-8718-34ba3539b91d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b449b8fb-ffe1-49c1-9179-218e15615b70");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d1cf3ff-fc78-4a49-a9de-18125206e2d8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dd4a27de-8737-4370-9b4d-ae6c96691250"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9802dd12-7c8d-4410-89b2-7a606c1f0783"));

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: new Guid("77f3e56e-48b2-4ff8-bd8c-9c2b28abb42c"));

            migrationBuilder.DropColumn(
                name: "CurrentPrice",
                table: "Products");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<double>(
                name: "CurrentPrice",
                table: "Products",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "921c88df-ac0e-42e3-8718-34ba3539b91d", "803df038-36cc-4000-b44a-e651f48c896c", "Admin", "ADMIN" },
                    { "71e05030-1a3c-44c1-84dc-69f529e7987b", "9776ed1a-f2ed-45ad-87cd-5d0d48bd4d91", "User", "USER" },
                    { "7c5af705-5e01-42c1-b2e8-309837df186c", "79041663-7532-4b2e-8027-f99d2078cf17", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b449b8fb-ffe1-49c1-9179-218e15615b70", 0, "AdminTown 1A", "81dd0d6d-96cf-43d1-aed5-abe1ce170202", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEFxo/jT1hxFvzYUrYdFzqwKxk+/nJnSqnbqIn1P37SeOOgNnocDe3W3+S84EYYY9CA==", null, false, "de492584-cb3b-412d-8a96-ec016c7258cc", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "isMainCateGory" },
                values: new object[,]
                {
                    { new Guid("0d1cf3ff-fc78-4a49-a9de-18125206e2d8"), "Kitchen", true },
                    { new Guid("dd4a27de-8737-4370-9b4d-ae6c96691250"), "Chairs", false }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "Data", "ProductKey" },
                values: new object[] { new Guid("77f3e56e-48b2-4ff8-bd8c-9c2b28abb42c"), "Height: 1.3m, Width: 0.7m, Depth: 0.7m", new Guid("9802dd12-7c8d-4410-89b2-7a606c1f0783") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "b449b8fb-ffe1-49c1-9179-218e15615b70", "921c88df-ac0e-42e3-8718-34ba3539b91d" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CoverImageDestination", "CurrentPrice", "DateStocked", "Description", "DetailsKey", "Name", "Price", "SaleAmount", "SalePercentage", "Storage" },
                values: new object[] { new Guid("9802dd12-7c8d-4410-89b2-7a606c1f0783"), "GR4Inc", "/404.png", 450.0, new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Local), "Low hanging fruit chair.", new Guid("77f3e56e-48b2-4ff8-bd8c-9c2b28abb42c"), "Stolencius", 500.0, 50.0, 10.0, 38 });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "MainKey", "SubKey", "SubCatId" },
                values: new object[] { new Guid("0d1cf3ff-fc78-4a49-a9de-18125206e2d8"), new Guid("dd4a27de-8737-4370-9b4d-ae6c96691250"), null });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("9802dd12-7c8d-4410-89b2-7a606c1f0783"), new Guid("dd4a27de-8737-4370-9b4d-ae6c96691250") });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("9802dd12-7c8d-4410-89b2-7a606c1f0783"), new Guid("0d1cf3ff-fc78-4a49-a9de-18125206e2d8") });
        }
    }
}
