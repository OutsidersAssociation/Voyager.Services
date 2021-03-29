using Voyager.Services.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Voyager.Services.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ServicesController : AbpController
    {
        protected ServicesController()
        {
            LocalizationResource = typeof(ServicesResource);
        }
    }
}