using AbpBlazorCustomizeLoginPage.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpBlazorCustomizeLoginPage.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpBlazorCustomizeLoginPageController : AbpController
    {
        protected AbpBlazorCustomizeLoginPageController()
        {
            LocalizationResource = typeof(AbpBlazorCustomizeLoginPageResource);
        }
    }
}