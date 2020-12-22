using Volo.Abp.Bundling;

namespace AbpBlazorCustomizeLoginPage.Blazor
{
    public class AbpBlazorCustomizeLoginPageBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {
        }

        public void AddStyles(BundleContext context)
        {
            context.Add("main.css");
        }
    }
}
