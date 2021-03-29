using Volo.Abp.Settings;

namespace Voyager.Services.Settings
{
    public class ServicesSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ServicesSettings.MySetting1));
        }
    }
}
