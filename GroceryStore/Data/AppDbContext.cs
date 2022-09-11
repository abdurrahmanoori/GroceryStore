using GroceryStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStore.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ItemStoreKeeper> itemStoreKeeper { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<ItemDetail> ItemDetail { get; set; }
        public DbSet<Chart> Chart { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Item>()
                .HasIndex(u => u.ItemStoreKepeerId)
                .IsUnique();

            builder.Entity<Category>().HasData(
                new Category { Name="Eeating",Id=10}
                );

            builder.Entity<Category>().HasData(
                new Category { Name="Washing",Id=1}
                );
        }

       

    }
}
