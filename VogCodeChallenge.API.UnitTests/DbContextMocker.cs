using System;
using Microsoft.EntityFrameworkCore;
using VogCodeChallenge.API.Infrastructure.Contexts;
namespace VogCodeChallenge.API.UnitTests
{
    public static class DbContextMocker
    {
        public static ApplicationDbContext GetApplicationDbContext(string dbName, bool seed)
        {
            // Create options for DbContext instance
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;

            // Create instance of DbContext
            var dbContext = new ApplicationDbContext(options);

            // Add entities in memory
            if(seed)dbContext.Seed();

            return dbContext;
        }
    }
}
