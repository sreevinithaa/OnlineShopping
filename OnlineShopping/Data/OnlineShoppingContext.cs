using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineShopping.Models;

namespace OnlineShopping.Data
{
    public class OnlineShoppingContext : DbContext
    {
        public OnlineShoppingContext (DbContextOptions<OnlineShoppingContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineShopping.Models.User>? User { get; set; }

        public DbSet<OnlineShopping.Models.Product>? Product { get; set; }

        public DbSet<OnlineShopping.Models.Sales>? Sales { get; set; }
    }
}
