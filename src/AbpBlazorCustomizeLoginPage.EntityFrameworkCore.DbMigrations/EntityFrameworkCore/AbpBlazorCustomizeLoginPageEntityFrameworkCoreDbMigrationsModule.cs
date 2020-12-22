using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpBlazorCustomizeLoginPage.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpBlazorCustomizeLoginPageEntityFrameworkCoreModule)
        )]
    public class AbpBlazorCustomizeLoginPageEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpBlazorCustomizeLoginPageMigrationsDbContext>();
        }
    }
}
