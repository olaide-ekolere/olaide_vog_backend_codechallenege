using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using VogCodeChallenge.Domain.Entities;
namespace VogCodeChallenge.Infrastructure.Contexts
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
