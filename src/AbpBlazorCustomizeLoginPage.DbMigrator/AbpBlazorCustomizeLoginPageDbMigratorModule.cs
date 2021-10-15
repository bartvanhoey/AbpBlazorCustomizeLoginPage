using AbpBlazorCustomizeLoginPage.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpBlazorCustomizeLoginPage.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpBlazorCustomizeLoginPageEntityFrameworkCoreModule),
        typeof(AbpBlazorCustomizeLoginPageApplicationContractsModule)
        )]
    public class AbpBlazorCustomizeLoginPageDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
