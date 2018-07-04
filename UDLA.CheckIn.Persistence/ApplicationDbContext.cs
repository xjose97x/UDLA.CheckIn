﻿using System;
using UDLA.CheckIn.Data.Entities;
using Microsoft.EntityFrameworkCore;
using UDLA.CheckIn.Data.Models;

namespace UDLA.CheckIn.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EntryRecord> EntryRecords { get; set; }
        public DbSet<Faculty> Faculties { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().OwnsOne(e => e.Name).HasData(
                new Employee(1, new Name("José", "Escudero"), 1),
                new Employee(2, new Name("Donald", "Trump"), 3),
                new Employee(3, new Name("Barack", "Obama")));
            modelBuilder.Entity<EntryRecord>().HasData(
                new EntryRecord(1, new DateTimeOffset(DateTime.Now), 1),
                new EntryRecord(2, new DateTimeOffset(DateTime.Now.AddDays(-1)), 1),
                new EntryRecord(3, new DateTimeOffset(DateTime.Now), 2),
                new EntryRecord(4, new DateTimeOffset(DateTime.Now.AddDays(-1)), 2));
            modelBuilder.Entity<Faculty>().HasData(
                new Faculty(1, "Facultad de Ingenieria y Ciencias Agropecuarias"),
                new Faculty(2, "Facultad de Odontologia"),
                new Faculty(3, "Escuela de Hospitalidad y Turismo"));
        }
    }
}
