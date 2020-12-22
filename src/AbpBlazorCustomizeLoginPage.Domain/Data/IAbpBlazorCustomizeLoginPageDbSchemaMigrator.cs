using System.Threading.Tasks;

namespace AbpBlazorCustomizeLoginPage.Data
{
    public interface IAbpBlazorCustomizeLoginPageDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
