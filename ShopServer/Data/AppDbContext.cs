using Microsoft.EntityFrameworkCore;
using PhoneShopShatedLibrary.Models;

namespace ShopServer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; } = default!;
    }
}
