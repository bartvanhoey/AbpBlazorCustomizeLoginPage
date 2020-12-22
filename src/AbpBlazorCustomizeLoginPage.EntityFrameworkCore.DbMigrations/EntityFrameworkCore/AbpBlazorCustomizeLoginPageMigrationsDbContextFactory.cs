using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpBlazorCustomizeLoginPage.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class AbpBlazorCustomizeLoginPageMigrationsDbContextFactory : IDesignTimeDbContextFactory<AbpBlazorCustomizeLoginPageMigrationsDbContext>
    {
        public AbpBlazorCustomizeLoginPageMigrationsDbContext CreateDbContext(string[] args)
        {
            AbpBlazorCustomizeLoginPageEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AbpBlazorCustomizeLoginPageMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new AbpBlazorCustomizeLoginPageMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AbpBlazorCustomizeLoginPage.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
