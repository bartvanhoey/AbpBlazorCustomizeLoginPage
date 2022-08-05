using AbpBlazorCustomizeLoginPage.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpBlazorCustomizeLoginPage.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpBlazorCustomizeLoginPageController : AbpControllerBase
{
    protected AbpBlazorCustomizeLoginPageController()
    {
        LocalizationResource = typeof(AbpBlazorCustomizeLoginPageResource);
    }
}
