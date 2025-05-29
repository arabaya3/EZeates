using Microsoft.EntityFrameworkCore;
using EZeates.Models;


namespace EZeates.Data
{
    public class EZeatesDbContext : DbContext
    {
        public EZeatesDbContext(DbContextOptions<EZeatesDbContext> options)
            : base(options)
        {
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Item> OrderItems { get; set; }
        public DbSet<User> Customers { get; set; }
    }
}



