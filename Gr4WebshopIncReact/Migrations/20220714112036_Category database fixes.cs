using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gr4WebshopIncReact.Migrations
{
    public partial class Categorydatabasefixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Categories_SubKey",
                table: "SubCategories");

            migrationBuilder.DropIndex(
                name: "IX_SubCategories_SubKey",
                table: "SubCategories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1479fa98-aeae-4699-ac48-4b662f7c54d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d4a3420-f142-4497-b343-8561f07eccba");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5698dfba-52e2-401a-855d-8f894635dc78", "95d73293-d25e-4ad0-be78-a96fbabfc773" });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("9f96a7b3-38fd-463a-a2f3-95a3a9aacabf"), new Guid("bfb5fa11-1d00-4e80-b998-ff5ae1cbc5b8") });

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumns: new[] { "ProductKey", "CategoryKey" },
                keyValues: new object[] { new Guid("9f96a7b3-38fd-463a-a2f3-95a3a9aacabf"), new Guid("e3893050-e5f2-410d-9292-f9a1933aa2b8") });

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumns: new[] { "MainKey", "SubKey" },
                keyValues: new object[] { new Guid("e3893050-e5f2-410d-9292-f9a1933aa2b8"), new Guid("bfb5fa11-1d00-4e80-b998-ff5ae1cbc5b8") });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "95d73293-d25e-4ad0-be78-a96fbabfc773");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5698dfba-52e2-401a-855d-8f894635dc78");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bfb5fa11-1d00-4e80-b998-ff5ae1cbc5b8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e3893050-e5f2-410d-9292-f9a1933aa2b8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9f96a7b3-38fd-463a-a2f3-95a3a9aacabf"));

            migrationBuilder.DeleteData(
                table: "Details",
                keyColumn: "Id",
                keyValue: new Guid("7fba2919-7ded-4e9e-96a8-88e8033c50ff"));

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

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Categories_MainKey",
                table: "SubCategories",
                column: "MainKey",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Categories_MainKey",
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "95d73293-d25e-4ad0-be78-a96fbabfc773", "f2fc8d68-de47-4b92-8f65-8ef4eb7f40ca", "Admin", "ADMIN" },
                    { "1479fa98-aeae-4699-ac48-4b662f7c54d7", "8d4bb84d-2ac2-401b-b547-fa6aed8b61cc", "User", "USER" },
                    { "5d4a3420-f142-4497-b343-8561f07eccba", "51f68e48-1cc5-4155-b1fd-e573eeff6367", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adress", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5698dfba-52e2-401a-855d-8f894635dc78", 0, "AdminTown 1A", "2d5aef28-9d79-4892-b2c4-231b63f8256d", "admin@admin.com", false, "Admin", "Adminsson", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENvk/U4hu9AkWCHtvA2uCgTDnItxSISQ+/4/Ias5Fq8hPcDVORbl88G33N2D74LMWg==", null, false, "1f9b66f8-666c-4d16-acab-dead16dc33fb", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "isMainCateGory" },
                values: new object[,]
                {
                    { new Guid("e3893050-e5f2-410d-9292-f9a1933aa2b8"), "Kitchen", true },
                    { new Guid("bfb5fa11-1d00-4e80-b998-ff5ae1cbc5b8"), "Chairs", false }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "Data", "ProductKey" },
                values: new object[] { new Guid("7fba2919-7ded-4e9e-96a8-88e8033c50ff"), "Height: 1.3m, Width: 0.7m, Depth: 0.7m", new Guid("9f96a7b3-38fd-463a-a2f3-95a3a9aacabf") });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "5698dfba-52e2-401a-855d-8f894635dc78", "95d73293-d25e-4ad0-be78-a96fbabfc773" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CoverImageDestination", "DateStocked", "Description", "DetailsKey", "Name", "Price", "SaleAmount", "SalePercentage", "Stock" },
                values: new object[] { new Guid("9f96a7b3-38fd-463a-a2f3-95a3a9aacabf"), "GR4Inc", "/404.png", new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Local), "Low hanging fruit chair.", new Guid("7fba2919-7ded-4e9e-96a8-88e8033c50ff"), "Stolencius", 500.0, 50.0, 10.0, 38.0 });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "MainKey", "SubKey", "SubCatId" },
                values: new object[] { new Guid("e3893050-e5f2-410d-9292-f9a1933aa2b8"), new Guid("bfb5fa11-1d00-4e80-b998-ff5ae1cbc5b8"), null });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("9f96a7b3-38fd-463a-a2f3-95a3a9aacabf"), new Guid("bfb5fa11-1d00-4e80-b998-ff5ae1cbc5b8") });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "ProductKey", "CategoryKey" },
                values: new object[] { new Guid("9f96a7b3-38fd-463a-a2f3-95a3a9aacabf"), new Guid("e3893050-e5f2-410d-9292-f9a1933aa2b8") });

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_SubKey",
                table: "SubCategories",
                column: "SubKey");

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Categories_SubKey",
                table: "SubCategories",
                column: "SubKey",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
