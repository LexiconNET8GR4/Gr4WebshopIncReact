using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gr4WebshopIncReact.Migrations
{
    public partial class Checkoutdebugging : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ef5210d-dfc0-46e3-b952-8bc9cf616a48");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d00580fa-ffea-4e0b-9b4a-b34247dfe8f1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8ece3f24-a414-45e6-962a-dca797f82823", "518c68c0-6521-4e52-a45d-a0408a47fe73" });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("521c4225-aa1f-468e-8dc3-2bc362dc7a6f"), new Guid("f74f3021-b961-4d28-9c8e-63ac2e7272d1") });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("521c4225-aa1f-468e-8dc3-2bc362dc7a6f"), new Guid("ff8eb28e-764c-4233-8a07-a26484143bce") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "518c68c0-6521-4e52-a45d-a0408a47fe73");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ece3f24-a414-45e6-962a-dca797f82823");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f74f3021-b961-4d28-9c8e-63ac2e7272d1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ff8eb28e-764c-4233-8a07-a26484143bce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("521c4225-aa1f-468e-8dc3-2bc362dc7a6f"));

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: new Guid("f3515a74-02a6-48c5-b067-7ad548caf2a3"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f1a1b3a9-147f-44d6-8cd0-ef794a73611c", "6a84aa5e-28bc-478a-8f59-dc0d3899ac91", "Admin", "ADMIN" },
                    { "6fe07bd8-698a-46cc-b60c-3fa2c0769837", "a6174e78-b62c-40b1-8e1f-09f5d43b63a5", "User", "USER" },
                    { "80bcfc66-96a8-4b89-8a17-57411e45ea2a", "cbdc818c-f136-48e3-884b-62c648404139", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "06efb813-da21-4ebe-b823-ddb69002f0e5", 0, "AdminTown 1A", "868b1137-e455-4fad-b7f8-376b0cffda8d", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENRo8AMV2U/pSzLkdMNpgRK2LoOFnY/jKUrCyfFBBawMXtyjl2aTuY2PNWZyRG2BoQ==", null, false, "bf63487e-7322-4f53-9f46-df6231182acc", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "Name", "isMainCateGory" },
                values: new object[,]
                {
                    { new Guid("0d7b1f89-9416-43ae-9667-4811033bef92"), null, "Kitchen", true },
                    { new Guid("9dab9552-cdf9-4186-86cf-04604f1e5c32"), null, "Chairs", false }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "Data", "ProductKey" },
                values: new object[] { new Guid("f7713ab3-c2ca-4b2e-a626-12d0abcdc912"), "Height: 1.3m, Width: 0.7m, Depth: 0.7m", new Guid("afef4359-5889-4282-bdce-e9293a5304c0") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "06efb813-da21-4ebe-b823-ddb69002f0e5", "f1a1b3a9-147f-44d6-8cd0-ef794a73611c" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CoverImageDestination", "DateStocked", "Description", "DetailsKey", "Name", "Price", "SaleAmount", "SalePercentage", "Stock" },
                values: new object[] { new Guid("afef4359-5889-4282-bdce-e9293a5304c0"), "GR4Inc", "/404.png", new DateTime(2022, 8, 17, 0, 0, 0, 0, DateTimeKind.Local), "Low hanging fruit chair.", new Guid("f7713ab3-c2ca-4b2e-a626-12d0abcdc912"), "Stolencius", 500.0, 50.0, 10.0, 38.0 });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("afef4359-5889-4282-bdce-e9293a5304c0"), new Guid("9dab9552-cdf9-4186-86cf-04604f1e5c32") });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("afef4359-5889-4282-bdce-e9293a5304c0"), new Guid("0d7b1f89-9416-43ae-9667-4811033bef92") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6fe07bd8-698a-46cc-b60c-3fa2c0769837");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80bcfc66-96a8-4b89-8a17-57411e45ea2a");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "06efb813-da21-4ebe-b823-ddb69002f0e5", "f1a1b3a9-147f-44d6-8cd0-ef794a73611c" });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("afef4359-5889-4282-bdce-e9293a5304c0"), new Guid("0d7b1f89-9416-43ae-9667-4811033bef92") });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("afef4359-5889-4282-bdce-e9293a5304c0"), new Guid("9dab9552-cdf9-4186-86cf-04604f1e5c32") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1a1b3a9-147f-44d6-8cd0-ef794a73611c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06efb813-da21-4ebe-b823-ddb69002f0e5");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d7b1f89-9416-43ae-9667-4811033bef92"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9dab9552-cdf9-4186-86cf-04604f1e5c32"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("afef4359-5889-4282-bdce-e9293a5304c0"));

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: new Guid("f7713ab3-c2ca-4b2e-a626-12d0abcdc912"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "518c68c0-6521-4e52-a45d-a0408a47fe73", "d10fbd0a-505b-4993-8a78-df0c7fbd09f1", "Admin", "ADMIN" },
                    { "d00580fa-ffea-4e0b-9b4a-b34247dfe8f1", "5c0db50c-aba6-4229-b87a-4eb8edb549ab", "User", "USER" },
                    { "7ef5210d-dfc0-46e3-b952-8bc9cf616a48", "0a5edf54-6ee9-4958-9de3-a131d1f5c19b", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8ece3f24-a414-45e6-962a-dca797f82823", 0, "AdminTown 1A", "afe9359a-c729-4077-904b-e68417ff7dfb", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAELsejYz6ZkZmeL3qf42ZMN90mlkkiyhi2r8hrAETTTqutCXnsYAMq9AuJkeGGLckHw==", null, false, "153a7193-ebc7-44f2-9700-2a4777915a50", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "Name", "isMainCateGory" },
                values: new object[,]
                {
                    { new Guid("f74f3021-b961-4d28-9c8e-63ac2e7272d1"), null, "Kitchen", true },
                    { new Guid("ff8eb28e-764c-4233-8a07-a26484143bce"), null, "Chairs", false }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "Data", "ProductKey" },
                values: new object[] { new Guid("f3515a74-02a6-48c5-b067-7ad548caf2a3"), "Height: 1.3m, Width: 0.7m, Depth: 0.7m", new Guid("521c4225-aa1f-468e-8dc3-2bc362dc7a6f") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "8ece3f24-a414-45e6-962a-dca797f82823", "518c68c0-6521-4e52-a45d-a0408a47fe73" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CoverImageDestination", "DateStocked", "Description", "DetailsKey", "Name", "Price", "SaleAmount", "SalePercentage", "Stock" },
                values: new object[] { new Guid("521c4225-aa1f-468e-8dc3-2bc362dc7a6f"), "GR4Inc", "/404.png", new DateTime(2022, 8, 9, 0, 0, 0, 0, DateTimeKind.Local), "Low hanging fruit chair.", new Guid("f3515a74-02a6-48c5-b067-7ad548caf2a3"), "Stolencius", 500.0, 50.0, 10.0, 38.0 });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("521c4225-aa1f-468e-8dc3-2bc362dc7a6f"), new Guid("ff8eb28e-764c-4233-8a07-a26484143bce") });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("521c4225-aa1f-468e-8dc3-2bc362dc7a6f"), new Guid("f74f3021-b961-4d28-9c8e-63ac2e7272d1") });
        }
    }
}
