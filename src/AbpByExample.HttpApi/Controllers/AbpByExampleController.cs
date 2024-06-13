using AbpByExample.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpByExample.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpByExampleController : AbpControllerBase
{
    protected AbpByExampleController()
    {
        LocalizationResource = typeof(AbpByExampleResource);
    }
}
