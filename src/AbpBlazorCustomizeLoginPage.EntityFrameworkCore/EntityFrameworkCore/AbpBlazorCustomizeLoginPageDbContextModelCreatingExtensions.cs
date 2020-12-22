using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AbpBlazorCustomizeLoginPage.EntityFrameworkCore
{
    public static class AbpBlazorCustomizeLoginPageDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpBlazorCustomizeLoginPage(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpBlazorCustomizeLoginPageConsts.DbTablePrefix + "YourEntities", AbpBlazorCustomizeLoginPageConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}