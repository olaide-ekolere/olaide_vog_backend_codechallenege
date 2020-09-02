using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VogCodeChallenge.API.Infrastructure.Contexts;
using VogCodeChallenge.API.Application.Interfaces.Repositories;
using VogCodeChallenge.API.Infrastructure.Repositories;
namespace VogCodeChallenge.API.Infrastructure
{
    public static class ServiceRegisteration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                               options.UseInMemoryDatabase("ApplicationDbContext"));

            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
