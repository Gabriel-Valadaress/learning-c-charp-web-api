using APICatalog_FirstAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace APICatalog_FirstAPI.Context
{
    public class CatalogDbContext : DbContext
    {
        public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }
    }
}
