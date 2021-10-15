using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpBlazorCustomizeLoginPage.Data;
using Volo.Abp.DependencyInjection;

namespace AbpBlazorCustomizeLoginPage.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpBlazorCustomizeLoginPageDbSchemaMigrator
        : IAbpBlazorCustomizeLoginPageDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpBlazorCustomizeLoginPageDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpBlazorCustomizeLoginPageDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpBlazorCustomizeLoginPageDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
