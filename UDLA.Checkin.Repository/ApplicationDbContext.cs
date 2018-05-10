using Microsoft.EntityFrameworkCore;
using UDLA.CheckIn.Data;

namespace UDLA.Checkin.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<RegisterEntry> RegisterEntries { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
