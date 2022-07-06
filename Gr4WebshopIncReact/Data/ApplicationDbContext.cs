using Gr4WebshopIncReact.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gr4WebshopIncReact.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Details> Details { get; set; }
        public DbSet<ShippingMethod> ShippingMethods { get; set; }

        // Composite tables
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<OrderedProducts> OrderedProducts { get; set; }


        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions) 
            : base(options, operationalStoreOptions){

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // --- --- Composite tables (Many to Many relations)

            #region Product Categories
            // --- Create a many-to-many relation between Products and Categories
            // --- Using a connector class named ProductCategory

            // Denote composite key
            modelBuilder.Entity<ProductCategory>()
                .HasKey(pc => new { pc.ProductKey, pc.CategoryKey });

            // Create one-to-many connection beteween connector and Product
            modelBuilder.Entity<ProductCategory>()
                .HasOne(c => c.Product)
                .WithMany(p => p.Categories)
                .HasForeignKey(pc => pc.CategoryKey);

            // Create one-to-many connection beteween connector and Category
            modelBuilder.Entity<ProductCategory>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(pc => pc.ProductKey);
            #endregion

            #region Subcategories
            // --- Create a selreferential many-to-many connection for categories
            // --- Using a connector class named SubCategory

            // Denote composite key
            modelBuilder.Entity<SubCategory>()
                .HasKey(sc => new { sc.MainKey, sc.SubKey });

            // Create one-to-many connection beteween connector and Category
            modelBuilder.Entity<SubCategory>()
                .HasOne(s => s.MainC)
                .WithMany(m => m.SubCategories)
                .HasForeignKey(sc => sc.SubKey);
            #endregion

            #region Ordered Products
            // --- Create a many-to-many connection perople Order and Product
            // --- Using a connector class named OrderedProducts

            // Denote composite key
            modelBuilder.Entity<OrderedProducts>()
                .HasKey(op => new { op.OrderKey, op.ProductKey });

            // Create one-to-many connection beteween connector and Product
            modelBuilder.Entity<OrderedProducts>()
                .HasOne(p => p.Order)
                .WithMany(o => o.Products)
                .HasForeignKey(op => op.ProductKey);
            #endregion

            //  --- --- One to One relations
            #region One to One Relations
            // Order - Customer
            modelBuilder.Entity<Customer>()
                .HasOne(c => c.Order)
                .WithOne(o => o.Customer)
                .HasForeignKey<Order>(o => o.CustomerKey);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithOne(c => c.Order)
                .HasForeignKey<Customer>(c => c.OrderKey);

            // Order - Payment
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Payment)
                .WithOne(p => p.Order)
                .HasForeignKey<Payment>(p => p.OrderKey);

            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Order)
                .WithOne(o => o.Payment)
                .HasForeignKey<Order>(o => o.PaymentKey);

            // Product - Details
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Details)
                .WithOne(d => d.Product)
                .HasForeignKey<Details>(d => d.ProductKey);

            modelBuilder.Entity<Details>()
                .HasOne(d => d.Product)
                .WithOne(p => p.Details)
                .HasForeignKey<Product>(p => p.DetailsKey);
            #endregion

            // --- --- One with Many relations

            // User with Orders
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.OrderHistory)
                .HasForeignKey(o => o.UserKey);

            // --- --- Seed Roles and an Admin user
            #region Roles and Admins
            string adminRoleID = Guid.NewGuid().ToString();
            string userRoleID = Guid.NewGuid().ToString();

            string adminUserID = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = adminRoleID,
                    Name = "Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Id = userRoleID,
                    Name = "User",
                    NormalizedName = "USER"
                },
                new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"
                });;

            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            modelBuilder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = adminUserID,
                    Email = "admin@admin.com",
                    NormalizedEmail = "ADMIN@ADMIN.COM",
                    UserName = "admin@admin.com",
                    NormalizedUserName = "ADMIN@ADMIN.COM",
                    FirstName = "Admin",
                    LastName = "Adminsson",
                    Adress = "AdminTown 1A",
                    PasswordHash = hasher.HashPassword(null, "password")
                });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleID,
                    UserId = adminUserID
                });
            #endregion

            // --- --- Seeding
            #region Seeding
            Guid detailsKey = Guid.NewGuid();

            modelBuilder.Entity<Product>().HasData(
                new Product{ 
                    Id = Guid.NewGuid(),
                    Name = "Stolencius",
                    Description = "Low hanging fruit chair.",
                    CoverImageDestination = "/404.png"//,
                    //DetailsKey = detailsKey,

                });

            #endregion
        }


    }
}
