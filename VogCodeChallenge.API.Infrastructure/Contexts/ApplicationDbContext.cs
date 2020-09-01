using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using VogCodeChallenge.API.Domain.Entities;
namespace VogCodeChallenge.API.Infrastructure.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        {
        }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}
