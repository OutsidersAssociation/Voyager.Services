using Voyager.Services.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Voyager.Services.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ServicesEntityFrameworkCoreDbMigrationsModule),
        typeof(ServicesApplicationContractsModule)
        )]
    public class ServicesDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
