using Volo.Abp.Modularity;

namespace Voyager.Services
{
    [DependsOn(
        typeof(ServicesApplicationModule),
        typeof(ServicesDomainTestModule)
        )]
    public class ServicesApplicationTestModule : AbpModule
    {

    }
}