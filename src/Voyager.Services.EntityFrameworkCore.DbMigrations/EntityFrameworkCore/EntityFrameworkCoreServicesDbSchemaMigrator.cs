using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Voyager.Services.Data;
using Volo.Abp.DependencyInjection;

namespace Voyager.Services.EntityFrameworkCore
{
    public class EntityFrameworkCoreServicesDbSchemaMigrator
        : IServicesDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreServicesDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the ServicesMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<ServicesMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}