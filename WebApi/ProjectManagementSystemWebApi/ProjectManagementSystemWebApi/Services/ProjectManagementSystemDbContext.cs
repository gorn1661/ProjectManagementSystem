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

        protected override void OnModelCreating(ModelBuilder mb)
        {

        }
    }
}
