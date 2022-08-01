using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gr4WebshopIncReact.Migrations
{
    public partial class Subcategoryclassremovedasredundant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCategories");

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

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Categories",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryId",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_CategoryId",
                table: "Categories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_CategoryId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_CategoryId",
                table: "Categories");

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
                name: "CategoryId",
                table: "Categories");

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    MainKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubCatId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SubKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.MainKey);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_MainKey",
                        column: x => x.MainKey,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_SubCatId",
                        column: x => x.SubCatId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_SubCatId",
                table: "SubCategories",
                column: "SubCatId");
        }
    }
}
