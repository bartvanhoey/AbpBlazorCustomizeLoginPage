using AbpBlazorCustomizeLoginPage.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpBlazorCustomizeLoginPage;

[DependsOn(
    typeof(AbpBlazorCustomizeLoginPageEntityFrameworkCoreTestModule)
    )]
public class AbpBlazorCustomizeLoginPageDomainTestModule : AbpModule
{

}
