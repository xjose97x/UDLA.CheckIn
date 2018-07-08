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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Faculty>().HasData(
                new Faculty(1, "Escuela de hospitalidad y turismo"),
                new Faculty(2, "Escuela de gastronomía"),
                new Faculty(3, "Facultad de odontología"),
                new Faculty(4, "Escuela de música"),
                new Faculty(5, "Facultad de arquitectura y diseño"),
                new Faculty(6, "Facultad de derecho y ciencias sociales"),
                new Faculty(7, "Facultad de salud"),
                new Faculty(8, "Facultad de comunicación y artes audiovisuales"),
                new Faculty(9, "Facultad de ciencias económicas y administrativas"),
                new Faculty(10, "Facultad de ingeniería y ciencias aplicadas"),
                new Faculty(11, "Escuela de psicología"));
            modelBuilder.Entity<Professor>().HasData(
                new Professor(1, "marco.galarza@udla.edu.ec", "099999999", 10),
                new Professor(2, "anita.yanez@udla.edu.ec", "099999999", 10),
                new Professor(3, "pedro.nogales@udla.edu.ec", "099999999", 10),
                new Professor(4, "pablo.escobar@udla.edu.ec", "099999999", 9),
                new Professor(5, "tom.cruise@udla.edu.ec", "099999999", 8),
                new Professor(6, "arnold.schwarzenegger@udla.edu.ec", "099999999", 8)
                );
            //https://github.com/aspnet/EntityFrameworkCore/issues/12004#issuecomment-389715911
            modelBuilder.Entity<Professor>().OwnsOne(e => e.Name).HasData(
               new { ProfessorId = 1, GivenName = "Marco", LastName = "Galarza"},
               new { ProfessorId = 2, GivenName = "Anita", LastName = "Yánez"},
               new { ProfessorId = 3, GivenName = "Pedro", LastName = "Nogales" },
               new { ProfessorId = 4, GivenName = "Pablo", LastName = "Escobar" },
               new { ProfessorId = 5, GivenName = "Tom", LastName = "Cruise" },
               new { ProfessorId = 6, GivenName = "Arnold", LastName = "Schwarzenegger" }
            );
        }
    }
}
