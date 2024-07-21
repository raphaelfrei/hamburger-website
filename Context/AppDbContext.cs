using Microsoft.EntityFrameworkCore;
using Restaurante.Models;

namespace Restaurante.Context {

    public class AppDbContext:DbContext {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Hamburger> Hamburgers { get; set; }
        public DbSet<CartShopItem> CartShopItems { get; set; }

    }
}
