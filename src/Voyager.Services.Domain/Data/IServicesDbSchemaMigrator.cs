using System.Threading.Tasks;

namespace Voyager.Services.Data
{
    public interface IServicesDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
