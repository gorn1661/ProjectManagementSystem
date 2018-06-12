﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ProjectManagementSystemWebApi.Services;
using System;

namespace ProjectManagementSystemWebApi.Migrations
{
    [DbContext(typeof(ProjectManagementSystemDbContext))]
    [Migration("20180612105720_CustomerEmployeeInit")]
    partial class CustomerEmployeeInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectManagementSystemWebApi.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyName");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("NIP");

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.HasKey("CustomerID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("ProjectManagementSystemWebApi.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("NIP");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<int?>("ProjectID");

                    b.HasKey("EmployeeID");

                    b.HasIndex("ProjectID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("ProjectManagementSystemWebApi.Models.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CustomerID");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("StartDate");

                    b.HasKey("ProjectID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("ProjectManagementSystemWebApi.Models.Employee", b =>
                {
                    b.HasOne("ProjectManagementSystemWebApi.Models.Project", "Project")
                        .WithMany("Employee")
                        .HasForeignKey("ProjectID");
                });

            modelBuilder.Entity("ProjectManagementSystemWebApi.Models.Project", b =>
                {
                    b.HasOne("ProjectManagementSystemWebApi.Models.Customer", "Customer")
                        .WithMany("Project")
                        .HasForeignKey("CustomerID");
                });
#pragma warning restore 612, 618
        }
    }
}