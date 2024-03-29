﻿// <auto-generated />
using System;
using Gr4WebshopIncReact.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gr4WebshopIncReact.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220714121023_Category database fixes 2")]
    partial class Categorydatabasefixes2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gr4WebshopIncReact.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "2e5b6011-dd77-4fe9-bbdd-79b54b4cbbbc",
                            AccessFailedCount = 0,
                            Adress = "AdminTown 1A",
                            ConcurrencyStamp = "6ab98b3f-6c04-453e-bc6c-f0c07715dee1",
                            Email = "admin@admin.com",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Adminsson",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ADMIN.COM",
                            NormalizedUserName = "ADMIN@ADMIN.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHWz7hpch9KwRu8NV0hmuP/xdBxCJLmZjVBtJ0wcPDaAryRiXzdPiPIHSlPIsshnKw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "a5cf2385-191a-47b4-b616-50434a33566b",
                            TwoFactorEnabled = false,
                            UserName = "admin@admin.com"
                        });
                });

            modelBuilder.Entity("Gr4WebshopIncReact.Models.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isMainCateGory")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("75645f42-ea05-4977-a269-883e330b39b4"),
                            Name = "Kitchen",
                            isMainCateGory = true
                        },
                        new
                        {
                            Id = new Guid("d370b7fe-d201-4938-a07e-fc58a8fe0eff"),
                            Name = "Chairs",
                            isMainCateGory = false
                        });
                });

            modelBuilder.Entity("Gr4WebshopIncReact.Models.Coupon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Coupon");
                });

            modelBuilder.Entity("Gr4WebshopIncReact.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OrderKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("UserKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("OrderKey")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Gr4WebshopIncReact.Models.Details", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Details");

                    b.HasData(
                        new
                        {
                            Id = new Guid("efbc79a2-dc5a-4eaa-80d2-99f59cbe2f89"),
                            Data = "Height: 1.3m, Width: 0.7m, Depth: 0.7m",
                            ProductKey = new Guid("d1514aea-bdb4-4927-a38e-fcc763282f50")
                        });
                });

            modelBuilder.Entity("Gr4WebshopIncReact.Models.ImageDestination", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Path")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProductKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductKey");

                    b.ToTable("ImageDestination");
                });

            modelBuilder.Entity("Gr4WebshopIncReact.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CouponId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PaymentKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ShipmentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ShippingAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ShippingMethodId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalCost")
                        .HasColumnType("float");

                    b.Property<string>("UserKey")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CouponId");

                    b.HasIndex("PaymentKey")
                        .IsUnique();

                    b.HasIndex("ShippingMethodId");

                    b.HasIndex("UserKey");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Gr4WebshopIncReact.Models.OrderedProducts", b =>
                {
                    b.Property<Guid>("OrderKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("OrderKey", "ProductKey");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductKey");

                    b.ToTable("OrderedProducts");
                });

            modelBuilder.Entity("Gr4WebshopIncReact.Models.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("MethodId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MethodKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MethodId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Gr4WebshopIncReact.Models.PaymentMethod", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PaymentMethods");
                });

            modelBuilder.Entity("Gr4WebshopIncReact.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverImageDestination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateStocked")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("DetailsKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("SaleAmount")
                        .HasColumnType("float");

                    b.Property<double>("SalePercentage")
                        .HasColumnType("float");

                    b.Property<double>("Stock")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DetailsKey")
                        .IsUnique();

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d1514aea-bdb4-4927-a38e-fcc763282f50"),
                            Brand = "GR4Inc",
                            CoverImageDestination = "/404.png",
                            DateStocked = new DateTime(2022, 7, 14, 0, 0, 0, 0, DateTimeKind.Local),
                            Description = "Low hanging fruit chair.",
                            DetailsKey = new Guid("efbc79a2-dc5a-4eaa-80d2-99f59cbe2f89"),
                            Name = "Stolencius",
                            Price = 500.0,
                            SaleAmount = 50.0,
                            SalePercentage = 10.0,
                            Stock = 38.0
                        });
                });

            modelBuilder.Entity("Gr4WebshopIncReact.Models.ProductCategory", b =>
                {
                    b.Property<Guid>("ProductKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductKey", "CategoryKey");

                    b.HasIndex("CategoryKey");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            ProductKey = new Guid("d1514aea-bdb4-4927-a38e-fcc763282f50"),
                            CategoryKey = new Guid("d370b7fe-d201-4938-a07e-fc58a8fe0eff")
                        },
                        new
                        {
                            ProductKey = new Guid("d1514aea-bdb4-4927-a38e-fcc763282f50"),
                            CategoryKey = new Guid("75645f42-ea05-4977-a269-883e330b39b4")
                        });
                });

            modelBuilder.Entity("Gr4WebshopIncReact.Models.ShippingMethod", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Provider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ShippingMethods");
                });

            modelBuilder.Entity("Gr4WebshopIncReact.Models.SubCategory", b =>
                {
                    b.Property<Guid>("MainKey")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SubCatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SubKey")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MainKey");

                    b.HasIndex("SubCatId");

                    b.ToTable("SubCategories");

                    b.HasData(
                        new
                        {
                            MainKey = new Guid("75645f42-ea05-4977-a269-883e330b39b4"),
                            SubKey = new Guid("d370b7fe-d201-4938-a07e-fc58a8fe0eff")
                        });
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes");
                });

            modelBuilder.Entity("IdentityServer4.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasMaxLength(50000);

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<string>("SubjectId")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Key");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.ToTable("PersistedGrants");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "314f7969-2b09-45a9-b9f1-2cbaba66f06e",
                            ConcurrencyStamp = "26baad99-d6f7-4161-80b5-fd04ae6340c0",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "5d8fc0e7-2c7a-4d8b-8479-a3ec2af7904e",
                            ConcurrencyStamp = "700d0e04-8e35-4a1c-b66e-bbaa792338c9",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "5cd77df9-e1c0-4f1e-a92a-60f40ab05502",
                            ConcurrencyStamp = "2e773e98-456f-4710-9c0e-a413b0a818e2",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "2e5b6011-dd77-4fe9-bbdd-79b54b4cbbbc",
                            RoleId = "314f7969-2b09-45a9-b9f1-2cbaba66f06e"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Gr4WebshopIncReact.Models.Customer", b =>
                {
                    b.HasOne("Gr4WebshopIncReact.Models.Order", "Order")
                        .WithOne("Customer")
                        .HasForeignKey("Gr4WebshopIncReact.Models.Customer", "OrderKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gr4WebshopIncReact.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Gr4WebshopIncReact.Models.ImageDestination", b =>
                {
                    b.HasOne("Gr4WebshopIncReact.Models.Product", "Product")
                        .WithMany("ImagesDestination")
                        .HasForeignKey("ProductKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gr4WebshopIncReact.Models.Order", b =>
                {
                    b.HasOne("Gr4WebshopIncReact.Models.Coupon", "Coupon")
                        .WithMany()
                        .HasForeignKey("CouponId");

                    b.HasOne("Gr4WebshopIncReact.Models.Payment", "Payment")
                        .WithOne("Order")
                        .HasForeignKey("Gr4WebshopIncReact.Models.Order", "PaymentKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gr4WebshopIncReact.Models.ShippingMethod", "ShippingMethod")
                        .WithMany()
                        .HasForeignKey("ShippingMethodId");

                    b.HasOne("Gr4WebshopIncReact.Models.ApplicationUser", "User")
                        .WithMany("OrderHistory")
                        .HasForeignKey("UserKey");
                });

            modelBuilder.Entity("Gr4WebshopIncReact.Models.OrderedProducts", b =>
                {
                    b.HasOne("Gr4WebshopIncReact.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("Gr4WebshopIncReact.Models.Order", "Order")
                        .WithMany("Products")
                        .HasForeignKey("ProductKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gr4WebshopIncReact.Models.Payment", b =>
                {
                    b.HasOne("Gr4WebshopIncReact.Models.PaymentMethod", "Method")
                        .WithMany()
                        .HasForeignKey("MethodId");
                });

            modelBuilder.Entity("Gr4WebshopIncReact.Models.Product", b =>
                {
                    b.HasOne("Gr4WebshopIncReact.Models.Details", "Details")
                        .WithOne("Product")
                        .HasForeignKey("Gr4WebshopIncReact.Models.Product", "DetailsKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gr4WebshopIncReact.Models.ProductCategory", b =>
                {
                    b.HasOne("Gr4WebshopIncReact.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gr4WebshopIncReact.Models.Product", "Product")
                        .WithMany("Categories")
                        .HasForeignKey("ProductKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gr4WebshopIncReact.Models.SubCategory", b =>
                {
                    b.HasOne("Gr4WebshopIncReact.Models.Category", "MainCat")
                        .WithMany("SubCategories")
                        .HasForeignKey("MainKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gr4WebshopIncReact.Models.Category", "SubCat")
                        .WithMany()
                        .HasForeignKey("SubCatId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Gr4WebshopIncReact.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Gr4WebshopIncReact.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gr4WebshopIncReact.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Gr4WebshopIncReact.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
