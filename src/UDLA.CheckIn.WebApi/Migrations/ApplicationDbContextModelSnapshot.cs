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
                .HasAnnotation("ProductVersion", "2.1.0-rc1-32029")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UDLA.CheckIn.Data.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new { Id = 1, LastName = "Escudero", Name = "José" },
                        new { Id = 2, LastName = "Trump", Name = "Donald" },
                        new { Id = 3, LastName = "Obama", Name = "Barack" }
                    );
                });

            modelBuilder.Entity("UDLA.CheckIn.Data.EntryRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("DateCreated");

                    b.Property<int>("EmployeeId");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EntryRecords");

                    b.HasData(
                        new { Id = 1, DateCreated = new DateTimeOffset(new DateTime(2018, 5, 27, 11, 42, 11, 708, DateTimeKind.Unspecified), new TimeSpan(0, -5, 0, 0, 0)), EmployeeId = 1 },
                        new { Id = 2, DateCreated = new DateTimeOffset(new DateTime(2018, 5, 26, 11, 42, 11, 709, DateTimeKind.Unspecified), new TimeSpan(0, -5, 0, 0, 0)), EmployeeId = 1 },
                        new { Id = 3, DateCreated = new DateTimeOffset(new DateTime(2018, 5, 27, 11, 42, 11, 709, DateTimeKind.Unspecified), new TimeSpan(0, -5, 0, 0, 0)), EmployeeId = 2 },
                        new { Id = 4, DateCreated = new DateTimeOffset(new DateTime(2018, 5, 26, 11, 42, 11, 709, DateTimeKind.Unspecified), new TimeSpan(0, -5, 0, 0, 0)), EmployeeId = 2 }
                    );
                });

            modelBuilder.Entity("UDLA.CheckIn.Data.EntryRecord", b =>
                {
                    b.HasOne("UDLA.CheckIn.Data.Employee", "Employee")
                        .WithMany("EntryRecords")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
