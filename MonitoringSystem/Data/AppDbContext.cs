using Microsoft.EntityFrameworkCore;
using MonitoringSystem.Model;

namespace MonitoringSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users => Set<User>();
        public DbSet<Roles> Roles => Set<Roles>();

    }
}
