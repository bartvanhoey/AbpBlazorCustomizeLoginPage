using System;
using System.Collections.Generic;
using System.Text;
using AbpBlazorCustomizeLoginPage.Localization;
using Volo.Abp.Application.Services;

namespace AbpBlazorCustomizeLoginPage;

/* Inherit your application services from this class.
 */
public abstract class AbpBlazorCustomizeLoginPageAppService : ApplicationService
{
    protected AbpBlazorCustomizeLoginPageAppService()
    {
        LocalizationResource = typeof(AbpBlazorCustomizeLoginPageResource);
    }
}
