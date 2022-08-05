using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpBlazorCustomizeLoginPage.Blazor;

[Dependency(ReplaceServices = true)]
public class AbpBlazorCustomizeLoginPageBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpBlazorCustomizeLoginPage";
}
