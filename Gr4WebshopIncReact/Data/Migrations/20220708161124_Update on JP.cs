using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gr4WebshopIncReact.Data.Migrations
{
    public partial class UpdateonJP : Migration
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a782484-85f7-483e-afd9-87b99385bfa2", "6091fd67-1077-47c5-bd5a-feea152018c0", "Admin", "ADMIN" },
                    { "c73b5d48-b758-48ad-a919-33dd3b306876", "dfeaa8dd-ff09-4ba7-930c-7fbd681f3616", "User", "USER" },
                    { "b7d63bc3-9680-484e-bc84-775745b356a1", "af57bfd6-a163-4fe0-aaf8-e9db461f8cf8", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "19d8fff9-a351-4454-bcc5-50336b0dfad6", 0, "AdminTown 1A", "c9c91728-3830-4c26-8fde-c5393341c6ed", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEB5+NSSo4dU+3Yxm4eO0KwUEBwJbgnTIqVKsB7own7DphxknJid9rhD16ml74urAiw==", null, false, "a0b9d9a9-72c4-4453-bed4-c2964733c31f", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "isMainCateGory" },
                values: new object[,]
                {
                    { new Guid("a64a494b-fd6e-426b-971e-38c498d67cde"), "Kitchen", true },
                    { new Guid("3cb195a3-390a-4fe1-a17f-befbcbdd237b"), "Chairs", false }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "Data", "ProductKey" },
                values: new object[] { new Guid("1fbcc934-fd4b-4352-bb62-6c2044339113"), "Height: 1.3m, Width: 0.7m, Depth: 0.7m", new Guid("41683993-8243-44cb-8c0b-a8eb64273549") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "19d8fff9-a351-4454-bcc5-50336b0dfad6", "1a782484-85f7-483e-afd9-87b99385bfa2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CoverImageDestination", "CurrentPrice", "DateStocked", "Description", "DetailsKey", "Name", "Price", "SaleAmount", "SalePercentage", "Storage" },
                values: new object[] { new Guid("41683993-8243-44cb-8c0b-a8eb64273549"), "GR4Inc", "/404.png", 450.0, new DateTime(2022, 7, 8, 0, 0, 0, 0, DateTimeKind.Local), "Low hanging fruit chair.", new Guid("1fbcc934-fd4b-4352-bb62-6c2044339113"), "Stolencius", 500.0, 50.0, 10.0, 38 });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "MainKey", "SubKey", "SubCatId" },
                values: new object[] { new Guid("a64a494b-fd6e-426b-971e-38c498d67cde"), new Guid("3cb195a3-390a-4fe1-a17f-befbcbdd237b"), null });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("41683993-8243-44cb-8c0b-a8eb64273549"), new Guid("3cb195a3-390a-4fe1-a17f-befbcbdd237b") });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("41683993-8243-44cb-8c0b-a8eb64273549"), new Guid("a64a494b-fd6e-426b-971e-38c498d67cde") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7d63bc3-9680-484e-bc84-775745b356a1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c73b5d48-b758-48ad-a919-33dd3b306876");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "19d8fff9-a351-4454-bcc5-50336b0dfad6", "1a782484-85f7-483e-afd9-87b99385bfa2" });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("41683993-8243-44cb-8c0b-a8eb64273549"), new Guid("3cb195a3-390a-4fe1-a17f-befbcbdd237b") });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("41683993-8243-44cb-8c0b-a8eb64273549"), new Guid("a64a494b-fd6e-426b-971e-38c498d67cde") });

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumns: new[] { "MainKey", "SubKey" },
                keyValues: new object[] { new Guid("a64a494b-fd6e-426b-971e-38c498d67cde"), new Guid("3cb195a3-390a-4fe1-a17f-befbcbdd237b") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a782484-85f7-483e-afd9-87b99385bfa2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "19d8fff9-a351-4454-bcc5-50336b0dfad6");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3cb195a3-390a-4fe1-a17f-befbcbdd237b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a64a494b-fd6e-426b-971e-38c498d67cde"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41683993-8243-44cb-8c0b-a8eb64273549"));

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: new Guid("1fbcc934-fd4b-4352-bb62-6c2044339113"));

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
