using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Entity;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{
    public class HomeContext : DbContext
    {
        public HomeContext(DbContextOptions<HomeContext> options) : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders {get; set;}

        public DbSet<Seller> Sellers {get;set;}
 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(pr => pr.ProductID);
            modelBuilder.Entity<Product>().Property(pr => pr.ProductID).IsRequired();
            modelBuilder.Entity<Product>().Property(pr => pr.ProductName).IsRequired();
            modelBuilder.Entity<Product>().Property(pr => pr.ProductPrice).IsRequired();

            modelBuilder.Entity<Order>().HasKey(ord => ord.OrderID);
            modelBuilder.Entity<Order>().Property(ord => ord.OrderID).IsRequired();
            modelBuilder.Entity<Order>().Property(ord => ord.Products).IsRequired();
            modelBuilder.Entity<Order>().Property(ord => ord.OrderDate).IsRequired();



            modelBuilder.Entity<Order>()
                .HasMany(ord => ord.OrderProducts)
                .WithOne(pr => pr.orders);

            modelBuilder.Entity<Product>()
            .HasData(new Product
            {
                ProductID = 1,
                ProductName = "Polo",
                ProductPrice = 5
            });
            modelBuilder.Entity<Product>()
            .HasData(new Product
            {
                ProductID = 2,
                ProductName = "CalvinKlein",
                ProductPrice = 25
            });
            modelBuilder.Entity<Product>()
            .HasData(new Product
            {
                ProductID = 3,
                ProductName = "Gucci",
                ProductPrice = 50
            });

            modelBuilder.Entity<Order>()
            .HasData(new Order
            {
                OrderID = 1,
                Products = 1,
               
            });
            modelBuilder.Entity<Order>()
            .HasData(new Order
            {
                OrderID = 2,
                Products = 2,
               
            });
            modelBuilder.Entity<Order>()
            .HasData(new Order
            {
                OrderID = 3,
                Products = 1,
               
            });




        }



    }
}
