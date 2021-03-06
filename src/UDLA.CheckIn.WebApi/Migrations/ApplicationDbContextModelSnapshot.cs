﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UDLA.Checkin.Repository.Context;

namespace UDLA.CheckIn.WebApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UDLA.CheckIn.Data.Entities.EntryRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("DateCreated");

                    b.Property<int>("EmployeeId");

                    b.Property<DateTime>("LastModified");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EntryRecords");
                });

            modelBuilder.Entity("UDLA.CheckIn.Data.Entities.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Faculties");

                    b.HasData(
                        new { Id = 1, Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Escuela de hospitalidad y turismo" },
                        new { Id = 2, Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Escuela de gastronomía" },
                        new { Id = 3, Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Facultad de odontología" },
                        new { Id = 4, Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Escuela de música" },
                        new { Id = 5, Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Facultad de arquitectura y diseño" },
                        new { Id = 6, Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Facultad de derecho y ciencias sociales" },
                        new { Id = 7, Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Facultad de salud" },
                        new { Id = 8, Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Facultad de comunicación y artes audiovisuales" },
                        new { Id = 9, Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Facultad de ciencias económicas y administrativas" },
                        new { Id = 10, Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Facultad de ingeniería y ciencias aplicadas" },
                        new { Id = 11, Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Name = "Escuela de psicología" }
                    );
                });

            modelBuilder.Entity("UDLA.CheckIn.Data.Entities.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<string>("Email");

                    b.Property<int>("FacultyId");

                    b.Property<DateTime>("LastModified");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.ToTable("Professors");

                    b.HasData(
                        new { Id = 1, Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Email = "marco.galarza@udla.edu.ec", FacultyId = 10, LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PhoneNumber = "099999999" },
                        new { Id = 2, Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Email = "anita.yanez@udla.edu.ec", FacultyId = 10, LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PhoneNumber = "099999999" },
                        new { Id = 3, Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Email = "pedro.nogales@udla.edu.ec", FacultyId = 10, LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PhoneNumber = "099999999" },
                        new { Id = 4, Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Email = "pablo.escobar@udla.edu.ec", FacultyId = 9, LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PhoneNumber = "099999999" },
                        new { Id = 5, Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Email = "tom.cruise@udla.edu.ec", FacultyId = 8, LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PhoneNumber = "099999999" },
                        new { Id = 6, Created = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), Email = "arnold.schwarzenegger@udla.edu.ec", FacultyId = 8, LastModified = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), PhoneNumber = "099999999" }
                    );
                });

            modelBuilder.Entity("UDLA.CheckIn.Data.Entities.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastModified");

                    b.Property<DateTime>("PeriodEnd");

                    b.Property<DateTime>("PeriodStart");

                    b.Property<int>("ProfessorId");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("UDLA.CheckIn.Data.Entities.ScheduleDay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<int>("DayOfWeek");

                    b.Property<DateTime>("LastModified");

                    b.Property<int>("ScheduleId");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId");

                    b.ToTable("ScheduleDays");
                });

            modelBuilder.Entity("UDLA.CheckIn.Data.Entities.ScheduleHour", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("End");

                    b.Property<DateTime>("LastModified");

                    b.Property<int>("ScheduleDayId");

                    b.Property<DateTime>("Start");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleDayId");

                    b.ToTable("ScheduleHours");
                });

            modelBuilder.Entity("UDLA.CheckIn.Data.Entities.EntryRecord", b =>
                {
                    b.HasOne("UDLA.CheckIn.Data.Entities.Professor", "Employee")
                        .WithMany("EntryRecords")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UDLA.CheckIn.Data.Entities.Professor", b =>
                {
                    b.HasOne("UDLA.CheckIn.Data.Entities.Faculty", "Faculty")
                        .WithMany("Employees")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.OwnsOne("UDLA.CheckIn.Data.Models.Name", "Name", b1 =>
                        {
                            b1.Property<int>("ProfessorId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("GivenName");

                            b1.Property<string>("LastName");

                            b1.ToTable("Professors");

                            b1.HasOne("UDLA.CheckIn.Data.Entities.Professor")
                                .WithOne("Name")
                                .HasForeignKey("UDLA.CheckIn.Data.Models.Name", "ProfessorId")
                                .OnDelete(DeleteBehavior.Cascade);

                            b1.HasData(
                                new { ProfessorId = 1, GivenName = "Marco", LastName = "Galarza" },
                                new { ProfessorId = 2, GivenName = "Anita", LastName = "Yánez" },
                                new { ProfessorId = 3, GivenName = "Pedro", LastName = "Nogales" },
                                new { ProfessorId = 4, GivenName = "Pablo", LastName = "Escobar" },
                                new { ProfessorId = 5, GivenName = "Tom", LastName = "Cruise" },
                                new { ProfessorId = 6, GivenName = "Arnold", LastName = "Schwarzenegger" }
                            );
                        });
                });

            modelBuilder.Entity("UDLA.CheckIn.Data.Entities.Schedule", b =>
                {
                    b.HasOne("UDLA.CheckIn.Data.Entities.Professor", "Professor")
                        .WithMany("Schedules")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UDLA.CheckIn.Data.Entities.ScheduleDay", b =>
                {
                    b.HasOne("UDLA.CheckIn.Data.Entities.Schedule", "Schedule")
                        .WithMany("ScheduleDays")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UDLA.CheckIn.Data.Entities.ScheduleHour", b =>
                {
                    b.HasOne("UDLA.CheckIn.Data.Entities.ScheduleDay", "ScheduleDay")
                        .WithMany("ScheduleHours")
                        .HasForeignKey("ScheduleDayId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
