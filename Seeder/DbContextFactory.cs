using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using TP5_Identity.Data;

namespace Seeder
{
    public static class DbContextFactory
    {
        public static ApplicationDbContext CreateDbContext()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile(@Directory.GetCurrentDirectory() + "/appsettings.json")
              .Build();

            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var connectionString = configuration.GetConnectionString("DbContext_MSSQL");
            builder.UseSqlServer(connectionString);

            return new ApplicationDbContext(builder.Options);
        }
    }

}