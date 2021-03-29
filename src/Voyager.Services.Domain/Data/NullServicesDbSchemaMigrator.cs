using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Voyager.Services.Data
{
    /* This is used if database provider does't define
     * IServicesDbSchemaMigrator implementation.
     */
    public class NullServicesDbSchemaMigrator : IServicesDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}