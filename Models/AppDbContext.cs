using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<SeedShoppingCartItem> SeedShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Seed> Seeds { get; set; }
       // public DbSet<SeedDetail> SeedDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Category One" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Category Two" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Category Three" });

            //seed products

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 1,
                Name = "Product One",
                Price = 12.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",      
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 2,
                Name = "Product Two",
                Price = 18.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 2,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 3,
                Name = "Product Three",
                Price = 18.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 2,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 4,
                Name = "Product Four",
                Price = 15.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 5,
                Name = "Product Five",
                Price = 13.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 3,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 6,
                Name = "Product Six",
                Price = 17.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 3,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 7,
                Name = "Product Seven",
                Price = 15.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = false,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 8,
                Name = "Product Eight",
                Price = 12.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 3,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
            });


            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 9,
                Name = "Product Nine",
                Price = 15.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = true,
                IsProductOfTheWeek = true,
                ImageThumbnailUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 10,
                Name = "Product Ten",
                Price = 15.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 1,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = true,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId = 11,
                Name = "Product Eleven",
                Price = 18.95M,
                ShortDescription = "Lorem Ipsum",
                LongDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                CategoryId = 2,
                ImageUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
                InStock = false,
                IsProductOfTheWeek = false,
                ImageThumbnailUrl = "https://knowpathology.com.au/app/uploads/2018/07/Happy-Test-Screen-01-825x510.png",
            });
        }
    }
}
