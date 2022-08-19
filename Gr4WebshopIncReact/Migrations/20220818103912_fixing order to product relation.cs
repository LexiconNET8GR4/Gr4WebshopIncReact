using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gr4WebshopIncReact.Migrations
{
    public partial class fixingordertoproductrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderedProducts_Orders_OrderId",
                table: "OrderedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderedProducts_Products_ProductId",
                table: "OrderedProducts");

            migrationBuilder.DropIndex(
                name: "IX_OrderedProducts_OrderId",
                table: "OrderedProducts");

            migrationBuilder.DropIndex(
                name: "IX_OrderedProducts_ProductId",
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

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "OrderedProducts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f59b61be-1d31-4d70-be9d-7a761b43359f", "8cc03364-c838-475d-87f9-9705478cf3a0", "Admin", "ADMIN" },
                    { "4fc47828-e3f3-47f7-9916-270d5c27d8c2", "71523599-5871-4cf8-975c-fc5b211186ff", "User", "USER" },
                    { "4df5b0df-498a-4664-a626-c9f1bece44ad", "802a885f-cf17-4fe6-a3f6-6624b1ec0fa0", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e53a12b5-0545-46ee-86fb-4e54be7c396c", 0, "AdminTown 1A", "1a431d57-0eac-45b4-9714-9dca54165d59", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEIQKmRJkrkRK36un6IZBLGycYC3HKlZe9nXvypG3d4YN1b16moiH6WLyQML4L5IFpw==", null, false, "7ba644a8-7097-417a-83f0-5bc3305589e9", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "Name", "isMainCateGory" },
                values: new object[,]
                {
                    { new Guid("09f3f4e6-8aa2-4a36-8b5b-9e2d7bcecc09"), null, "Kitchen", true },
                    { new Guid("529de14b-7a97-472e-a7d3-156a3ce7e729"), null, "Chairs", false }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "Data", "ProductKey" },
                values: new object[] { new Guid("84c56eb9-36f5-49f8-bf5e-a32618b96dce"), "Height: 1.3m, Width: 0.7m, Depth: 0.7m", new Guid("4d592d39-ab69-4ba9-b85f-dbf09bad611d") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "e53a12b5-0545-46ee-86fb-4e54be7c396c", "f59b61be-1d31-4d70-be9d-7a761b43359f" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CoverImageDestination", "DateStocked", "Description", "DetailsKey", "Name", "Price", "SaleAmount", "SalePercentage", "Stock" },
                values: new object[] { new Guid("4d592d39-ab69-4ba9-b85f-dbf09bad611d"), "GR4Inc", "/404.png", new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Low hanging fruit chair.", new Guid("84c56eb9-36f5-49f8-bf5e-a32618b96dce"), "Stolencius", 500.0, 50.0, 10.0, 38.0 });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("4d592d39-ab69-4ba9-b85f-dbf09bad611d"), new Guid("529de14b-7a97-472e-a7d3-156a3ce7e729") });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("4d592d39-ab69-4ba9-b85f-dbf09bad611d"), new Guid("09f3f4e6-8aa2-4a36-8b5b-9e2d7bcecc09") });

            migrationBuilder.CreateIndex(
                name: "IX_OrderedProducts_ProductKey",
                table: "OrderedProducts",
                column: "ProductKey");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderedProducts_Products_OrderKey",
                table: "OrderedProducts",
                column: "OrderKey",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderedProducts_Orders_ProductKey",
                table: "OrderedProducts",
                column: "ProductKey",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderedProducts_Products_OrderKey",
                table: "OrderedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderedProducts_Orders_ProductKey",
                table: "OrderedProducts");

            migrationBuilder.DropIndex(
                name: "IX_OrderedProducts_ProductKey",
                table: "OrderedProducts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4df5b0df-498a-4664-a626-c9f1bece44ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fc47828-e3f3-47f7-9916-270d5c27d8c2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e53a12b5-0545-46ee-86fb-4e54be7c396c", "f59b61be-1d31-4d70-be9d-7a761b43359f" });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("4d592d39-ab69-4ba9-b85f-dbf09bad611d"), new Guid("09f3f4e6-8aa2-4a36-8b5b-9e2d7bcecc09") });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("4d592d39-ab69-4ba9-b85f-dbf09bad611d"), new Guid("529de14b-7a97-472e-a7d3-156a3ce7e729") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f59b61be-1d31-4d70-be9d-7a761b43359f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e53a12b5-0545-46ee-86fb-4e54be7c396c");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("09f3f4e6-8aa2-4a36-8b5b-9e2d7bcecc09"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("529de14b-7a97-472e-a7d3-156a3ce7e729"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4d592d39-ab69-4ba9-b85f-dbf09bad611d"));

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: new Guid("84c56eb9-36f5-49f8-bf5e-a32618b96dce"));

            migrationBuilder.AddColumn<Guid>(
                name: "OrderId",
                table: "OrderedProducts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "OrderedProducts",
                type: "uniqueidentifier",
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

            migrationBuilder.CreateIndex(
                name: "IX_OrderedProducts_ProductId",
                table: "OrderedProducts",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderedProducts_Orders_OrderId",
                table: "OrderedProducts",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderedProducts_Products_ProductId",
                table: "OrderedProducts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
