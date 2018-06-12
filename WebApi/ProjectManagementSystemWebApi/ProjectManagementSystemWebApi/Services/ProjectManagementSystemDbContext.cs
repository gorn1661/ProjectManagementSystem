using Microsoft.EntityFrameworkCore;
using ProjectManagementSystemWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementSystemWebApi.Services
{
    public class ProjectManagementSystemDbContext : DbContext
    {
        public ProjectManagementSystemDbContext(DbContextOptions o) : base(o)
        {

        }

        public DbSet<Project> Project { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<EmployeeProject> EmployeeProject { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            
            mb.Entity<Project>().HasOne(c => c.Customer).WithMany(p => p.Project);
            mb.Entity<EmployeeProject>().HasOne(e => e.Employee).WithMany(p => p.EmployeeProject);
            mb.Entity<EmployeeProject>().HasOne(p => p.Project).WithMany(e => e.EmployeeProject);
        }
    }
}
