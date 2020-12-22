using Volo.Abp.Modularity;

namespace AbpBlazorCustomizeLoginPage
{
    [DependsOn(
        typeof(AbpBlazorCustomizeLoginPageApplicationModule),
        typeof(AbpBlazorCustomizeLoginPageDomainTestModule)
        )]
    public class AbpBlazorCustomizeLoginPageApplicationTestModule : AbpModule
    {

    }
}