using System;
using UDLA.CheckIn.Data;
using Microsoft.EntityFrameworkCore;

namespace UDLA.Checkin.Repository.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EntryRecord> EntryRecords { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(
                new Employee(1, "José", "Escudero"), 
                new Employee(2, "Donald", "Trump"),
                new Employee(3, "Barack", "Obama"));
            modelBuilder.Entity<EntryRecord>().HasData(
                new EntryRecord(1, new DateTimeOffset(DateTime.Now), 1),
                new EntryRecord(2, new DateTimeOffset(DateTime.Now.AddDays(-1)), 1),
                new EntryRecord(3, new DateTimeOffset(DateTime.Now), 2),
                new EntryRecord(4, new DateTimeOffset(DateTime.Now.AddDays(-1)), 2));
        }
    }
}
