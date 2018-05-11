using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace UDLA.CheckIn.WebApi.Migrations
{
    public partial class InitialCreate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegisterEntries_Employees_EmployeeId",
                table: "RegisterEntries");

            migrationBuilder.DropColumn(
                name: "EmplyoeeId",
                table: "RegisterEntries");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "RegisterEntries",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RegisterEntries_Employees_EmployeeId",
                table: "RegisterEntries",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegisterEntries_Employees_EmployeeId",
                table: "RegisterEntries");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "RegisterEntries",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "EmplyoeeId",
                table: "RegisterEntries",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_RegisterEntries_Employees_EmployeeId",
                table: "RegisterEntries",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
