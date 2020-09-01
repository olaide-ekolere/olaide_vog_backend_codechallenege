using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VogCodeChallenge.API.Infrastructure.Contexts;
namespace VogCodeChallenge.API.Infrastructure
{
    public static class ServiceRegisteration
    {
        public static void AddPersistenceInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                               options.UseInMemoryDatabase("ApplicationDb"));
        }
    }
}
