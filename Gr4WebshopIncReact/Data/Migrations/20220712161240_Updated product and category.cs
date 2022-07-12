using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gr4WebshopIncReact.Data.Migrations
{
    public partial class Updatedproductandcategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Storage",
                table: "Products");

            migrationBuilder.AddColumn<double>(
                name: "Stock",
                table: "Products",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57ecbfab-1b2d-458c-99bf-b0bf6fe3ad92", "6cbb7c84-1b5f-4243-aaae-1687e10029b8", "Admin", "ADMIN" },
                    { "76d584a5-1270-452f-9638-85129f26e399", "034eb6d5-e2df-4c93-b983-3ff68ee79004", "User", "USER" },
                    { "a79a5cd2-149e-4efd-bfa5-323fbe7a6e4e", "93387246-e745-417c-98d5-c9637b9fda0a", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "09bd0032-327f-4270-b503-78c628677472", 0, "AdminTown 1A", "291e3658-9f89-4792-9082-ec75105003d0", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEJ1ldrHVXBoISGPLROjiALbOsmq8pvyBMl/uuCXjfwKz7FZ9Q1GQvGUqBa5N3IcimQ==", null, false, "3e539415-d292-49f6-9c13-de3e2766bfcb", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "isMainCateGory" },
                values: new object[,]
                {
                    { new Guid("b81e8110-c34a-4e7b-b29c-71125f046b9b"), "Kitchen", true },
                    { new Guid("6c0ab6b0-69a1-413e-bf43-ac62c1f7f7ab"), "Chairs", false }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "Data", "ProductKey" },
                values: new object[] { new Guid("04e966f9-a62f-4004-9b05-6f405a0e4e72"), "Height: 1.3m, Width: 0.7m, Depth: 0.7m", new Guid("41dd6853-231c-464a-97e6-0d6d341efc23") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "09bd0032-327f-4270-b503-78c628677472", "57ecbfab-1b2d-458c-99bf-b0bf6fe3ad92" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CoverImageDestination", "DateStocked", "Description", "DetailsKey", "Name", "Price", "SaleAmount", "SalePercentage", "Stock" },
                values: new object[] { new Guid("41dd6853-231c-464a-97e6-0d6d341efc23"), "GR4Inc", "/404.png", new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Local), "Low hanging fruit chair.", new Guid("04e966f9-a62f-4004-9b05-6f405a0e4e72"), "Stolencius", 500.0, 50.0, 10.0, 38.0 });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "MainKey", "SubKey", "SubCatId" },
                values: new object[] { new Guid("b81e8110-c34a-4e7b-b29c-71125f046b9b"), new Guid("6c0ab6b0-69a1-413e-bf43-ac62c1f7f7ab"), null });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("41dd6853-231c-464a-97e6-0d6d341efc23"), new Guid("6c0ab6b0-69a1-413e-bf43-ac62c1f7f7ab") });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("41dd6853-231c-464a-97e6-0d6d341efc23"), new Guid("b81e8110-c34a-4e7b-b29c-71125f046b9b") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "76d584a5-1270-452f-9638-85129f26e399");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a79a5cd2-149e-4efd-bfa5-323fbe7a6e4e");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "09bd0032-327f-4270-b503-78c628677472", "57ecbfab-1b2d-458c-99bf-b0bf6fe3ad92" });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("41dd6853-231c-464a-97e6-0d6d341efc23"), new Guid("6c0ab6b0-69a1-413e-bf43-ac62c1f7f7ab") });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("41dd6853-231c-464a-97e6-0d6d341efc23"), new Guid("b81e8110-c34a-4e7b-b29c-71125f046b9b") });

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumns: new[] { "MainKey", "SubKey" },
                keyValues: new object[] { new Guid("b81e8110-c34a-4e7b-b29c-71125f046b9b"), new Guid("6c0ab6b0-69a1-413e-bf43-ac62c1f7f7ab") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57ecbfab-1b2d-458c-99bf-b0bf6fe3ad92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09bd0032-327f-4270-b503-78c628677472");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6c0ab6b0-69a1-413e-bf43-ac62c1f7f7ab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b81e8110-c34a-4e7b-b29c-71125f046b9b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41dd6853-231c-464a-97e6-0d6d341efc23"));

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: new Guid("04e966f9-a62f-4004-9b05-6f405a0e4e72"));

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Storage",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }
    }
}
