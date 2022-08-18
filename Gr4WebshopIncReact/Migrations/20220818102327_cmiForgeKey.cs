using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gr4WebshopIncReact.Migrations
{
    public partial class cmiForgeKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderedProducts_Orders_ProductKey",
                table: "OrderedProducts");

            migrationBuilder.DropIndex(
                name: "IX_OrderedProducts_ProductKey",
                table: "OrderedProducts");

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

            migrationBuilder.AddColumn<Guid>(
                name: "OrderId",
                table: "OrderedProducts",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14376e56-2d28-4afa-bce2-b3c6c6d2fe0e", "009d3e32-34c2-4721-a343-cb13ea630df5", "Admin", "ADMIN" },
                    { "ba91b470-fe87-476b-b854-cf643e9fd99e", "9ab28fae-8cfa-4039-a19d-d4f56da5ac7f", "User", "USER" },
                    { "2376f2f1-3405-46db-9f49-52c03a1a6d3f", "ee1a1fe1-c65a-4834-9fc2-7d20fc1d86be", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d053aa6e-bc8d-4e1a-9cf5-55e161124d11", 0, "AdminTown 1A", "5988fcf3-9db6-411b-91dd-0f67c82ab416", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEI31zrPYxHlXZijfJLPxum+QAiPe+dsieZ9ppznjPVo0iMXpEyaqqEKO+igx7nj2+A==", null, false, "64f6cc32-155b-47ce-a020-85559de463cd", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "Name", "isMainCateGory" },
                values: new object[,]
                {
                    { new Guid("59f5e9c6-3cdf-42a5-80a4-75b9b43d460e"), null, "Kitchen", true },
                    { new Guid("c3b3a377-69f2-4fad-98a4-f0c94ffce808"), null, "Chairs", false }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "Data", "ProductKey" },
                values: new object[] { new Guid("296a028e-78ed-41b9-b04d-73d7fe333663"), "Height: 1.3m, Width: 0.7m, Depth: 0.7m", new Guid("09f1b826-166f-45b2-a82a-b2a211acd80e") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "d053aa6e-bc8d-4e1a-9cf5-55e161124d11", "14376e56-2d28-4afa-bce2-b3c6c6d2fe0e" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CoverImageDestination", "DateStocked", "Description", "DetailsKey", "Name", "Price", "SaleAmount", "SalePercentage", "Stock" },
                values: new object[] { new Guid("09f1b826-166f-45b2-a82a-b2a211acd80e"), "GR4Inc", "/404.png", new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Low hanging fruit chair.", new Guid("296a028e-78ed-41b9-b04d-73d7fe333663"), "Stolencius", 500.0, 50.0, 10.0, 38.0 });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("09f1b826-166f-45b2-a82a-b2a211acd80e"), new Guid("c3b3a377-69f2-4fad-98a4-f0c94ffce808") });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("09f1b826-166f-45b2-a82a-b2a211acd80e"), new Guid("59f5e9c6-3cdf-42a5-80a4-75b9b43d460e") });

            migrationBuilder.CreateIndex(
                name: "IX_OrderedProducts_OrderId",
                table: "OrderedProducts",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderedProducts_Orders_OrderId",
                table: "OrderedProducts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderedProducts_Orders_OrderId",
                table: "OrderedProducts");

            migrationBuilder.DropIndex(
                name: "IX_OrderedProducts_OrderId",
                table: "OrderedProducts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2376f2f1-3405-46db-9f49-52c03a1a6d3f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba91b470-fe87-476b-b854-cf643e9fd99e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d053aa6e-bc8d-4e1a-9cf5-55e161124d11", "14376e56-2d28-4afa-bce2-b3c6c6d2fe0e" });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("09f1b826-166f-45b2-a82a-b2a211acd80e"), new Guid("59f5e9c6-3cdf-42a5-80a4-75b9b43d460e") });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("09f1b826-166f-45b2-a82a-b2a211acd80e"), new Guid("c3b3a377-69f2-4fad-98a4-f0c94ffce808") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14376e56-2d28-4afa-bce2-b3c6c6d2fe0e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d053aa6e-bc8d-4e1a-9cf5-55e161124d11");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("59f5e9c6-3cdf-42a5-80a4-75b9b43d460e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c3b3a377-69f2-4fad-98a4-f0c94ffce808"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("09f1b826-166f-45b2-a82a-b2a211acd80e"));

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: new Guid("296a028e-78ed-41b9-b04d-73d7fe333663"));

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "OrderedProducts");

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

            migrationBuilder.CreateIndex(
                name: "IX_OrderedProducts_ProductKey",
                table: "OrderedProducts",
                column: "ProductKey");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderedProducts_Orders_ProductKey",
                table: "OrderedProducts",
                column: "ProductKey",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
