using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gr4WebshopIncReact.Migrations
{
    public partial class Checkoutandproductcontrollerchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24f29987-840b-40aa-abc6-cbe39cc52c62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2fd735b-b238-40d1-abdb-ffd3b9741228");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0f05cbd8-6206-47ef-8948-a3a71f64bf6c", "5f37b4bb-4b95-43f4-9a9c-058d3f8dbf7d" });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("203388e9-d057-4932-85c3-8c2092bfc579"), new Guid("7467ddde-b270-432e-84f4-f97cfcba1da3") });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("203388e9-d057-4932-85c3-8c2092bfc579"), new Guid("75ea34d0-8632-4172-95df-a6dace4024c5") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f37b4bb-4b95-43f4-9a9c-058d3f8dbf7d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f05cbd8-6206-47ef-8948-a3a71f64bf6c");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7467ddde-b270-432e-84f4-f97cfcba1da3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("75ea34d0-8632-4172-95df-a6dace4024c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("203388e9-d057-4932-85c3-8c2092bfc579"));

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: new Guid("5a7b9a91-f61a-4c46-ab39-1482ee5bfb5b"));

            migrationBuilder.DropColumn(
                name: "TotalCost",
                table: "Orders");

            migrationBuilder.AddColumn<double>(
                name: "Amount",
                table: "OrderedProducts",
                nullable: false,
                defaultValue: 0.0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "OrderedProducts");

            migrationBuilder.AddColumn<double>(
                name: "TotalCost",
                table: "Orders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5f37b4bb-4b95-43f4-9a9c-058d3f8dbf7d", "5d9ffe17-0200-4a54-8d3e-303f6e2f6cf4", "Admin", "ADMIN" },
                    { "24f29987-840b-40aa-abc6-cbe39cc52c62", "a078c1b3-930c-4823-9bd8-0b636c679281", "User", "USER" },
                    { "f2fd735b-b238-40d1-abdb-ffd3b9741228", "95c63f7b-7079-4287-8d2a-fcbd28739a0a", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0f05cbd8-6206-47ef-8948-a3a71f64bf6c", 0, "AdminTown 1A", "200bc7ca-36d6-4905-82b9-b61a8522a913", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEIIxRHEn/zIlKmGOxPZHJs8OsfkOyy7p/2EC8EPhG4/TTXHFCBUrgr9oti+R/94Bew==", null, false, "f71d208c-625e-4bf9-a50b-928b54b94c3d", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryId", "Name", "isMainCateGory" },
                values: new object[,]
                {
                    { new Guid("75ea34d0-8632-4172-95df-a6dace4024c5"), null, "Kitchen", true },
                    { new Guid("7467ddde-b270-432e-84f4-f97cfcba1da3"), null, "Chairs", false }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "Data", "ProductKey" },
                values: new object[] { new Guid("5a7b9a91-f61a-4c46-ab39-1482ee5bfb5b"), "Height: 1.3m, Width: 0.7m, Depth: 0.7m", new Guid("203388e9-d057-4932-85c3-8c2092bfc579") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "0f05cbd8-6206-47ef-8948-a3a71f64bf6c", "5f37b4bb-4b95-43f4-9a9c-058d3f8dbf7d" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CoverImageDestination", "DateStocked", "Description", "DetailsKey", "Name", "Price", "SaleAmount", "SalePercentage", "Stock" },
                values: new object[] { new Guid("203388e9-d057-4932-85c3-8c2092bfc579"), "GR4Inc", "/404.png", new DateTime(2022, 7, 14, 0, 0, 0, 0, DateTimeKind.Local), "Low hanging fruit chair.", new Guid("5a7b9a91-f61a-4c46-ab39-1482ee5bfb5b"), "Stolencius", 500.0, 50.0, 10.0, 38.0 });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("203388e9-d057-4932-85c3-8c2092bfc579"), new Guid("7467ddde-b270-432e-84f4-f97cfcba1da3") });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("203388e9-d057-4932-85c3-8c2092bfc579"), new Guid("75ea34d0-8632-4172-95df-a6dace4024c5") });
        }
    }
}
