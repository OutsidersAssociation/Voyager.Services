using Voyager.Services.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Voyager.Services
{
    [DependsOn(
        typeof(ServicesEntityFrameworkCoreTestModule)
        )]
    public class ServicesDomainTestModule : AbpModule
    {

    }
}