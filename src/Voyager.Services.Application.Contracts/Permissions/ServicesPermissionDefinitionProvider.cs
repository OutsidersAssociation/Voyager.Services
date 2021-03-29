using Voyager.Services.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Voyager.Services.Permissions
{
    public class ServicesPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ServicesPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ServicesPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ServicesResource>(name);
        }
    }
}
