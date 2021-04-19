using CoffeeShopWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShopWebAPI.Data
{
    public class CoffeeShopDBContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        string connectionString = @"Server=LAPTOP-3UCJ7LDS;Database=CoffeeShop;Trusted_Connection=True";
        public CoffeeShopDBContext(DbContextOptions<CoffeeShopDBContext> options) :base(options)
        {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
