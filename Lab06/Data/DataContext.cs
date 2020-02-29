using Lab06.Models;
using Lab06.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab06.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryId = 1,
                    CategoryName = "Iphone"
                },
                new Category()
                {
                    CategoryId = 2,
                    CategoryName = "SamSung"
                });
            builder.Entity<Product>().HasData(
                new Product()
                {
                    ProductId = 1,
                    ProductName = "IphoneX",
                    ProductImage = "iphoneX.png",
                    Descriptions = "iphoneX 64GB - 256GB",
                    ProductQuantity = 100,
                    ProductPrice = 1000.00,
                    CreateDate = DateTime.Now,
                    CategoryId = 1

                },
                 new Product()
                 {
                     ProductId = 2,
                     ProductName = "IphoneX",
                     ProductImage = "iphoneX.png",
                     Descriptions = "iphoneX 64GB - 256GB",
                     ProductQuantity = 100,
                     ProductPrice = 1000.00,
                     CreateDate = DateTime.Now,
                     CategoryId = 1

                 },
                  new Product()
                  {
                      ProductId = 3,
                      ProductName = "IphoneX",
                      ProductImage = "iphoneX.png",
                      Descriptions = "iphoneX 64GB - 256GB",
                      ProductQuantity = 100,
                      ProductPrice = 1000.00,
                      CreateDate = DateTime.Now,
                      CategoryId = 1

                  },
                   new Product()
                   {
                       ProductId = 4,
                       ProductName = "SamSung",
                       ProductImage = "samsung.png",
                       Descriptions = "samsung 64GB - 256GB",
                       ProductQuantity = 100,
                       ProductPrice = 1000.00,
                       CreateDate = DateTime.Now,
                       CategoryId = 2

                   });
        }
    }
}   
