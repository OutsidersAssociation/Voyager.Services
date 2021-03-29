using System;
using System.Collections.Generic;
using System.Text;
using Voyager.Services.Localization;
using Volo.Abp.Application.Services;

namespace Voyager.Services
{
    /* Inherit your application services from this class.
     */
    public abstract class ServicesAppService : ApplicationService
    {
        protected ServicesAppService()
        {
            LocalizationResource = typeof(ServicesResource);
        }
    }
}
