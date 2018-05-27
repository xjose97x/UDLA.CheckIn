using UDLA.CheckIn.Data;
using Microsoft.EntityFrameworkCore;

namespace UDLA.Checkin.Repository.Context
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
