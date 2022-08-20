using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gr4WebshopIncReact.Migrations
{
    public partial class customerorderrelationupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Orders_OrderKey",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_OrderKey",
                table: "Customers");

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

            migrationBuilder.DropColumn(
                name: "OrderKey",
                table: "Customers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e4c053b1-b7de-4ffe-a733-161eca334762", "3853342b-62f4-4832-8e14-f5c6458befcc", "Admin", "ADMIN" },
                    { "278b986f-3e6d-4152-b8cb-a3c54cc5fa08", "74321ed8-96b4-49ee-ab46-dc8d9ad9d493", "User", "USER" },
                    { "39333a81-fa0d-42e6-ad12-25f893da7fa7", "baa4fc12-4680-4526-8468-1e632ae269f1", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "49fd8bdd-14f1-49c0-96d7-fb0a79a39d71", 0, "AdminTown 1A", "6bbcd8ec-0f0d-4168-8b83-28717dfd43a7", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEP4aAkmqYXbj9zKseUgXa30jzLReHtV6Ibz5GrKOHkUQiilxekw1Mtz6iCoIG6Ck1w==", null, false, "67feaa7a-351e-4ccf-931b-afa4617ef813", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "Name", "isMainCateGory" },
                values: new object[,]
                {
                    { new Guid("e902fefa-580f-4898-90ed-a464127b5087"), null, "Kitchen", true },
                    { new Guid("43d4d9d7-69db-4ec9-8972-d6abf5883735"), null, "Chairs", false }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "Data", "ProductKey" },
                values: new object[] { new Guid("89d57e93-d8be-404d-be33-959a4392ab04"), "Height: 1.3m, Width: 0.7m, Depth: 0.7m", new Guid("9bae93a3-ec08-4b4a-b1db-55541396e87e") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "49fd8bdd-14f1-49c0-96d7-fb0a79a39d71", "e4c053b1-b7de-4ffe-a733-161eca334762" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CoverImageDestination", "DateStocked", "Description", "DetailsKey", "Name", "Price", "SaleAmount", "SalePercentage", "Stock" },
                values: new object[] { new Guid("9bae93a3-ec08-4b4a-b1db-55541396e87e"), "GR4Inc", "/404.png", new DateTime(2022, 8, 18, 0, 0, 0, 0, DateTimeKind.Local), "Low hanging fruit chair.", new Guid("89d57e93-d8be-404d-be33-959a4392ab04"), "Stolencius", 500.0, 50.0, 10.0, 38.0 });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("9bae93a3-ec08-4b4a-b1db-55541396e87e"), new Guid("43d4d9d7-69db-4ec9-8972-d6abf5883735") });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("9bae93a3-ec08-4b4a-b1db-55541396e87e"), new Guid("e902fefa-580f-4898-90ed-a464127b5087") });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerKey",
                table: "Orders",
                column: "CustomerKey");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerKey",
                table: "Orders",
                column: "CustomerKey",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerKey",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_CustomerKey",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "278b986f-3e6d-4152-b8cb-a3c54cc5fa08");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "39333a81-fa0d-42e6-ad12-25f893da7fa7");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "49fd8bdd-14f1-49c0-96d7-fb0a79a39d71", "e4c053b1-b7de-4ffe-a733-161eca334762" });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("9bae93a3-ec08-4b4a-b1db-55541396e87e"), new Guid("43d4d9d7-69db-4ec9-8972-d6abf5883735") });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("9bae93a3-ec08-4b4a-b1db-55541396e87e"), new Guid("e902fefa-580f-4898-90ed-a464127b5087") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4c053b1-b7de-4ffe-a733-161eca334762");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "49fd8bdd-14f1-49c0-96d7-fb0a79a39d71");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43d4d9d7-69db-4ec9-8972-d6abf5883735"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e902fefa-580f-4898-90ed-a464127b5087"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9bae93a3-ec08-4b4a-b1db-55541396e87e"));

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: new Guid("89d57e93-d8be-404d-be33-959a4392ab04"));

            migrationBuilder.AddColumn<Guid>(
                name: "OrderKey",
                table: "Customers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.CreateIndex(
                name: "IX_Customers_OrderKey",
                table: "Customers",
                column: "OrderKey",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Orders_OrderKey",
                table: "Customers",
                column: "OrderKey",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
