using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ProjectManagementSystemWebApi.Migrations
{
    public partial class changes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProject_Employee_EmployeeID",
                table: "EmployeeProject");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProject_Project_ProjectID",
                table: "EmployeeProject");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_Customer_CustomerID",
                table: "Project");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Project",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ProjectID",
                table: "EmployeeProject",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "EmployeeProject",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProject_Employee_EmployeeID",
                table: "EmployeeProject",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProject_Project_ProjectID",
                table: "EmployeeProject",
                column: "ProjectID",
                principalTable: "Project",
                principalColumn: "ProjectID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Customer_CustomerID",
                table: "Project",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProject_Employee_EmployeeID",
                table: "EmployeeProject");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeProject_Project_ProjectID",
                table: "EmployeeProject");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_Customer_CustomerID",
                table: "Project");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerID",
                table: "Project",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProjectID",
                table: "EmployeeProject",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeID",
                table: "EmployeeProject",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProject_Employee_EmployeeID",
                table: "EmployeeProject",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeProject_Project_ProjectID",
                table: "EmployeeProject",
                column: "ProjectID",
                principalTable: "Project",
                principalColumn: "ProjectID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Customer_CustomerID",
                table: "Project",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "CustomerID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
