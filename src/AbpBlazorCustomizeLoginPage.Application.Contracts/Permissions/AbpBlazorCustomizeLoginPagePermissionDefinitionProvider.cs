using AbpBlazorCustomizeLoginPage.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpBlazorCustomizeLoginPage.Permissions
{
    public class AbpBlazorCustomizeLoginPagePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpBlazorCustomizeLoginPagePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpBlazorCustomizeLoginPagePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpBlazorCustomizeLoginPageResource>(name);
        }
    }
}
