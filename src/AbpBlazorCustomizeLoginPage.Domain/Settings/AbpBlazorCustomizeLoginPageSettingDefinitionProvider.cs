using Volo.Abp.Settings;

namespace AbpBlazorCustomizeLoginPage.Settings;

public class AbpBlazorCustomizeLoginPageSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpBlazorCustomizeLoginPageSettings.MySetting1));
    }
}
