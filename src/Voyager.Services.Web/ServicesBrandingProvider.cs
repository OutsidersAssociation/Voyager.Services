using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Voyager.Services.Web
{
    [Dependency(ReplaceServices = true)]
    public class ServicesBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Services";
    }
}
