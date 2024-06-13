using AbpByExample.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpByExample.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class AbpByExamplePageModel : AbpPageModel
{
    protected AbpByExamplePageModel()
    {
        LocalizationResourceType = typeof(AbpByExampleResource);
    }
}
