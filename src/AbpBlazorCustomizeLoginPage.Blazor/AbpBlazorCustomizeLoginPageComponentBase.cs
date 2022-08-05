using AbpBlazorCustomizeLoginPage.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpBlazorCustomizeLoginPage.Blazor;

public abstract class AbpBlazorCustomizeLoginPageComponentBase : AbpComponentBase
{
    protected AbpBlazorCustomizeLoginPageComponentBase()
    {
        LocalizationResource = typeof(AbpBlazorCustomizeLoginPageResource);
    }
}
