using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Voyager.Services.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class ServicesMigrationsDbContextFactory : IDesignTimeDbContextFactory<ServicesMigrationsDbContext>
    {
        public ServicesMigrationsDbContext CreateDbContext(string[] args)
        {
            ServicesEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ServicesMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new ServicesMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Voyager.Services.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
