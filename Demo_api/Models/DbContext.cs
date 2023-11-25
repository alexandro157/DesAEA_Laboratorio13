using Microsoft.EntityFrameworkCore;
using Demo_api.Models;

namespace Demo_api.Models
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }

        public DbSet<Demo_api.Models.Customer>? Customer { get; set; }

    }
}
