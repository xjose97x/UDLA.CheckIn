﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UDLA.Checkin.Repository.Context;

namespace UDLA.CheckIn.WebApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180704013044_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
