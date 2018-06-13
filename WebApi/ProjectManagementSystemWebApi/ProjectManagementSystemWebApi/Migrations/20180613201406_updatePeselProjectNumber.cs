using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjectManagementSystemWebApi.Migrations
{
    public partial class updatePeselProjectNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProjectNumber",
                table: "Project",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pesel",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Pesel",
                table: "Customer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectNumber",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "Pesel",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Pesel",
                table: "Customer");
        }
    }
}
