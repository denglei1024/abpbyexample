using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AbpByExample.Web;

[Dependency(ReplaceServices = true)]
public class AbpByExampleBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpByExample";
}
