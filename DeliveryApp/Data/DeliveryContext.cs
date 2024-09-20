using Microsoft.EntityFrameworkCore;
using DeliveryApp.Models;

namespace DeliveryApp.Data
{
    public class DeliveryContext : DbContext
    {
        public DeliveryContext(DbContextOptions<DeliveryContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
