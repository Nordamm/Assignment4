using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace LiveCode4
{
    class NorthwindContex : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders {get; set;}
        public DbSet<OrderDetails> orderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql(
                "server=localhost;database=Northwind;uid=root;pwd=merle");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .Property(x => x.Name).HasColumnName("categoryname");

			modelBuilder.Entity<Order>()
			   .Property(x => x.Id).HasColumnName("orderId");

            modelBuilder.Entity<OrderDetails>()
			   .Property(x => x.OrderId).HasColumnName("orderId");
        }
    }
}
