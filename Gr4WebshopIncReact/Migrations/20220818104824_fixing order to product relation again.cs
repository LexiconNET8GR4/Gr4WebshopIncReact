using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gr4WebshopIncReact.Migrations
{
    public partial class fixingordertoproductrelationagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderedProducts_Products_OrderKey",
                table: "OrderedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderedProducts_Orders_ProductKey",
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5751c529-82d3-4891-9489-8195e70a4bb4", "47835086-51b8-4432-abb6-0f16ff3ecfa2", "Admin", "ADMIN" },
                    { "445f7b0e-92c7-4d0c-890d-f6d6cea899ad", "a91ff0a4-c70f-4f44-9c6a-ef6407fee74e", "User", "USER" },
                    { "b4f829bd-f5a0-4e99-b17e-f235f84dce34", "998d9309-72fe-458e-b2bb-e7777f66b6ef", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d4eba4f7-6a12-4ede-9857-558336cacd28", 0, "AdminTown 1A", "5c07b92e-f0cb-4204-982e-94cbc99f7018", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEB56FHEHt2Mo7VVtUK5mwIOWn4PWwnO8Xe9bYVUPhGW/Z47igzu0f9HqUxPQkAEKKg==", null, false, "5eb71152-8d4f-40a7-822b-dfbb112c95f5", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "Name", "isMainCateGory" },
                values: new object[,]
                {
                    { new Guid("6e3dff3c-c459-44c2-b6f2-6d93501731be"), null, "Kitchen", true },
                    { new Guid("c2ebd677-7502-4e28-9b4d-a3b49b3f31f8"), null, "Chairs", false }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "Data", "ProductKey" },
                values: new object[] { new Guid("2547ca23-77d5-40f2-99d5-9ac476dbfe3c"), "Height: 1.3m, Width: 0.7m, Depth: 0.7m", new Guid("3a25db80-cbad-4169-be73-67a06a31efef") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "d4eba4f7-6a12-4ede-9857-558336cacd28", "5751c529-82d3-4891-9489-8195e70a4bb4" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CoverImageDestination", "DateStocked", "Description", "DetailsKey", "Name", "Price", "SaleAmount", "SalePercentage", "Stock" },
                values: new object[] { new Guid("3a25db80-cbad-4169-be73-67a06a31efef"), "GR4Inc", "/404.png", new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Low hanging fruit chair.", new Guid("2547ca23-77d5-40f2-99d5-9ac476dbfe3c"), "Stolencius", 500.0, 50.0, 10.0, 38.0 });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("3a25db80-cbad-4169-be73-67a06a31efef"), new Guid("c2ebd677-7502-4e28-9b4d-a3b49b3f31f8") });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("3a25db80-cbad-4169-be73-67a06a31efef"), new Guid("6e3dff3c-c459-44c2-b6f2-6d93501731be") });

            migrationBuilder.AddForeignKey(
                name: "FK_OrderedProducts_Orders_OrderKey",
                table: "OrderedProducts",
                column: "OrderKey",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderedProducts_Products_ProductKey",
                table: "OrderedProducts",
                column: "ProductKey",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderedProducts_Orders_OrderKey",
                table: "OrderedProducts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderedProducts_Products_ProductKey",
                table: "OrderedProducts");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "445f7b0e-92c7-4d0c-890d-f6d6cea899ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4f829bd-f5a0-4e99-b17e-f235f84dce34");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d4eba4f7-6a12-4ede-9857-558336cacd28", "5751c529-82d3-4891-9489-8195e70a4bb4" });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("3a25db80-cbad-4169-be73-67a06a31efef"), new Guid("6e3dff3c-c459-44c2-b6f2-6d93501731be") });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("3a25db80-cbad-4169-be73-67a06a31efef"), new Guid("c2ebd677-7502-4e28-9b4d-a3b49b3f31f8") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5751c529-82d3-4891-9489-8195e70a4bb4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4eba4f7-6a12-4ede-9857-558336cacd28");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6e3dff3c-c459-44c2-b6f2-6d93501731be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c2ebd677-7502-4e28-9b4d-a3b49b3f31f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3a25db80-cbad-4169-be73-67a06a31efef"));

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: new Guid("2547ca23-77d5-40f2-99d5-9ac476dbfe3c"));

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
    }
}
