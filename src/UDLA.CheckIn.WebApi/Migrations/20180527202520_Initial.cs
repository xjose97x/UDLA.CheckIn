using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UDLA.CheckIn.WebApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    FacultyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Faculties_FacultyId",
                        column: x => x.FacultyId,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EntryRecords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateCreated = table.Column<DateTimeOffset>(nullable: false),
                    EmployeeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntryRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntryRecords_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FacultyId", "LastName", "Name" },
                values: new object[] { 3, null, "Obama", "Barack" });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Facultad de Ingenieria y Ciencias Agropecuarias" },
                    { 2, "Facultad de Odontologia" },
                    { 3, "Escuela de Hospitalidad y Turismo" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FacultyId", "LastName", "Name" },
                values: new object[] { 1, 1, "Escudero", "José" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "FacultyId", "LastName", "Name" },
                values: new object[] { 2, 3, "Trump", "Donald" });

            migrationBuilder.InsertData(
                table: "EntryRecords",
                columns: new[] { "Id", "DateCreated", "EmployeeId" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2018, 5, 27, 15, 25, 19, 826, DateTimeKind.Unspecified), new TimeSpan(0, -5, 0, 0, 0)), 1 },
                    { 2, new DateTimeOffset(new DateTime(2018, 5, 26, 15, 25, 19, 826, DateTimeKind.Unspecified), new TimeSpan(0, -5, 0, 0, 0)), 1 },
                    { 3, new DateTimeOffset(new DateTime(2018, 5, 27, 15, 25, 19, 826, DateTimeKind.Unspecified), new TimeSpan(0, -5, 0, 0, 0)), 2 },
                    { 4, new DateTimeOffset(new DateTime(2018, 5, 26, 15, 25, 19, 826, DateTimeKind.Unspecified), new TimeSpan(0, -5, 0, 0, 0)), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_FacultyId",
                table: "Employees",
                column: "FacultyId");

            migrationBuilder.CreateIndex(
                name: "IX_EntryRecords_EmployeeId",
                table: "EntryRecords",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntryRecords");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Faculties");
        }
    }
}
