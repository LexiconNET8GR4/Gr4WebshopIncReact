using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gr4WebshopIncReact.Migrations
{
    public partial class Categorydatabasefixes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategories",
                table: "SubCategories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1960be0b-21e6-4c1b-8652-5c10afd25d26");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "93a22c48-6657-4742-932d-91b9d54e92fe");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ab72e160-c2c2-44c4-be62-7933d925c5ff", "204862e5-9ee7-4ed0-82d2-36f8a6736429" });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("e097a12b-1c22-4741-8af6-ba14cc03e189"), new Guid("916c3245-671f-42aa-83b4-7aae10317c55") });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("e097a12b-1c22-4741-8af6-ba14cc03e189"), new Guid("e6e254dc-ad5f-4abc-920e-aa55ebca3ce9") });

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumns: new[] { "MainKey", "SubKey" },
                keyValues: new object[] { new Guid("916c3245-671f-42aa-83b4-7aae10317c55"), new Guid("e6e254dc-ad5f-4abc-920e-aa55ebca3ce9") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "204862e5-9ee7-4ed0-82d2-36f8a6736429");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab72e160-c2c2-44c4-be62-7933d925c5ff");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("916c3245-671f-42aa-83b4-7aae10317c55"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e6e254dc-ad5f-4abc-920e-aa55ebca3ce9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e097a12b-1c22-4741-8af6-ba14cc03e189"));

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: new Guid("4ddce795-1db3-431d-9fad-d45ea950f40a"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategories",
                table: "SubCategories",
                column: "MainKey");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "314f7969-2b09-45a9-b9f1-2cbaba66f06e", "26baad99-d6f7-4161-80b5-fd04ae6340c0", "Admin", "ADMIN" },
                    { "5d8fc0e7-2c7a-4d8b-8479-a3ec2af7904e", "700d0e04-8e35-4a1c-b66e-bbaa792338c9", "User", "USER" },
                    { "5cd77df9-e1c0-4f1e-a92a-60f40ab05502", "2e773e98-456f-4710-9c0e-a413b0a818e2", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2e5b6011-dd77-4fe9-bbdd-79b54b4cbbbc", 0, "AdminTown 1A", "6ab98b3f-6c04-453e-bc6c-f0c07715dee1", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEHWz7hpch9KwRu8NV0hmuP/xdBxCJLmZjVBtJ0wcPDaAryRiXzdPiPIHSlPIsshnKw==", null, false, "a5cf2385-191a-47b4-b616-50434a33566b", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "isMainCateGory" },
                values: new object[,]
                {
                    { new Guid("75645f42-ea05-4977-a269-883e330b39b4"), "Kitchen", true },
                    { new Guid("d370b7fe-d201-4938-a07e-fc58a8fe0eff"), "Chairs", false }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "Data", "ProductKey" },
                values: new object[] { new Guid("efbc79a2-dc5a-4eaa-80d2-99f59cbe2f89"), "Height: 1.3m, Width: 0.7m, Depth: 0.7m", new Guid("d1514aea-bdb4-4927-a38e-fcc763282f50") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "2e5b6011-dd77-4fe9-bbdd-79b54b4cbbbc", "314f7969-2b09-45a9-b9f1-2cbaba66f06e" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CoverImageDestination", "DateStocked", "Description", "DetailsKey", "Name", "Price", "SaleAmount", "SalePercentage", "Stock" },
                values: new object[] { new Guid("d1514aea-bdb4-4927-a38e-fcc763282f50"), "GR4Inc", "/404.png", new DateTime(2022, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "Low hanging fruit chair.", new Guid("efbc79a2-dc5a-4eaa-80d2-99f59cbe2f89"), "Stolencius", 500.0, 50.0, 10.0, 38.0 });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "MainKey", "SubCatId", "SubKey" },
                values: new object[] { new Guid("75645f42-ea05-4977-a269-883e330b39b4"), null, new Guid("d370b7fe-d201-4938-a07e-fc58a8fe0eff") });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("d1514aea-bdb4-4927-a38e-fcc763282f50"), new Guid("d370b7fe-d201-4938-a07e-fc58a8fe0eff") });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("d1514aea-bdb4-4927-a38e-fcc763282f50"), new Guid("75645f42-ea05-4977-a269-883e330b39b4") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SubCategories",
                table: "SubCategories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cd77df9-e1c0-4f1e-a92a-60f40ab05502");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d8fc0e7-2c7a-4d8b-8479-a3ec2af7904e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2e5b6011-dd77-4fe9-bbdd-79b54b4cbbbc", "314f7969-2b09-45a9-b9f1-2cbaba66f06e" });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("d1514aea-bdb4-4927-a38e-fcc763282f50"), new Guid("75645f42-ea05-4977-a269-883e330b39b4") });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("d1514aea-bdb4-4927-a38e-fcc763282f50"), new Guid("d370b7fe-d201-4938-a07e-fc58a8fe0eff") });

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "MainKey",
                keyValue: new Guid("75645f42-ea05-4977-a269-883e330b39b4"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "314f7969-2b09-45a9-b9f1-2cbaba66f06e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e5b6011-dd77-4fe9-bbdd-79b54b4cbbbc");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("75645f42-ea05-4977-a269-883e330b39b4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d370b7fe-d201-4938-a07e-fc58a8fe0eff"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d1514aea-bdb4-4927-a38e-fcc763282f50"));

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: new Guid("efbc79a2-dc5a-4eaa-80d2-99f59cbe2f89"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_SubCategories",
                table: "SubCategories",
                columns: new[] { "MainKey", "SubKey" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "204862e5-9ee7-4ed0-82d2-36f8a6736429", "b5aade90-1879-4677-aa82-feb7fb3e67a7", "Admin", "ADMIN" },
                    { "93a22c48-6657-4742-932d-91b9d54e92fe", "c9eb4080-27fd-4a50-9608-e50d1bcfb99f", "User", "USER" },
                    { "1960be0b-21e6-4c1b-8652-5c10afd25d26", "cef30c2a-bec2-4102-a644-6bc0f30633a8", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ab72e160-c2c2-44c4-be62-7933d925c5ff", 0, "AdminTown 1A", "99165abc-0fca-4b81-baeb-02aedfbd4ca6", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEBDoHL48RuMStJmiJi9vv90kWcxmLulalKlzYykE4QKkCr7VQCJ5QAKWJD4IO1wXXw==", null, false, "a59aeacc-76a6-4490-b6c0-29c0e46865df", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "isMainCateGory" },
                values: new object[,]
                {
                    { new Guid("916c3245-671f-42aa-83b4-7aae10317c55"), "Kitchen", true },
                    { new Guid("e6e254dc-ad5f-4abc-920e-aa55ebca3ce9"), "Chairs", false }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "Data", "ProductKey" },
                values: new object[] { new Guid("4ddce795-1db3-431d-9fad-d45ea950f40a"), "Height: 1.3m, Width: 0.7m, Depth: 0.7m", new Guid("e097a12b-1c22-4741-8af6-ba14cc03e189") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "ab72e160-c2c2-44c4-be62-7933d925c5ff", "204862e5-9ee7-4ed0-82d2-36f8a6736429" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CoverImageDestination", "DateStocked", "Description", "DetailsKey", "Name", "Price", "SaleAmount", "SalePercentage", "Stock" },
                values: new object[] { new Guid("e097a12b-1c22-4741-8af6-ba14cc03e189"), "GR4Inc", "/404.png", new DateTime(2022, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "Low hanging fruit chair.", new Guid("4ddce795-1db3-431d-9fad-d45ea950f40a"), "Stolencius", 500.0, 50.0, 10.0, 38.0 });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "MainKey", "SubKey", "SubCatId" },
                values: new object[] { new Guid("916c3245-671f-42aa-83b4-7aae10317c55"), new Guid("e6e254dc-ad5f-4abc-920e-aa55ebca3ce9"), null });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("e097a12b-1c22-4741-8af6-ba14cc03e189"), new Guid("e6e254dc-ad5f-4abc-920e-aa55ebca3ce9") });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("e097a12b-1c22-4741-8af6-ba14cc03e189"), new Guid("916c3245-671f-42aa-83b4-7aae10317c55") });
        }
    }
}
