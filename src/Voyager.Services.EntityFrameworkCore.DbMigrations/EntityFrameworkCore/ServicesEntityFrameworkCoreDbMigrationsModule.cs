using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Voyager.Services.EntityFrameworkCore
{
    [DependsOn(
        typeof(ServicesEntityFrameworkCoreModule)
        )]
    public class ServicesEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ServicesMigrationsDbContext>();
        }
    }
}
