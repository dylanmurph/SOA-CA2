using Microsoft.EntityFrameworkCore;

namespace SOA_CA2.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Game> Games { get; set; } = null!;
    }
}