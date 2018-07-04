using UDLA.CheckIn.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace UDLA.Checkin.Repository.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Professor> Professors { get; set; }
        public DbSet<EntryRecord> EntryRecords { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<ScheduleDay> ScheduleDays { get; set; }
        public DbSet<ScheduleHour> ScheduleHours { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
