using Microsoft.EntityFrameworkCore;
using OnlineShop.Entitiy.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop.Persistence.Context
{
   public class OnlineShopContext : DbContext
    {
        public OnlineShopContext(DbContextOptions<OnlineShopContext> options) : base(options)
        {
        }

        public DbSet<ProductCategory> ProductCategory { get; set; }

        public DbSet<Product> Product { get; set; }
    
    }
}
