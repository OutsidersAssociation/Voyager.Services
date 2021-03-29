using Voyager.Services.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Voyager.Services.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ServicesPageModel : AbpPageModel
    {
        protected ServicesPageModel()
        {
            LocalizationResourceType = typeof(ServicesResource);
        }
    }
}