using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpBlazorCustomizeLoginPage.Data
{
    /* This is used if database provider does't define
     * IAbpBlazorCustomizeLoginPageDbSchemaMigrator implementation.
     */
    public class NullAbpBlazorCustomizeLoginPageDbSchemaMigrator : IAbpBlazorCustomizeLoginPageDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}