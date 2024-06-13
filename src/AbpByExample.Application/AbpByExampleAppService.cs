using System;
using System.Collections.Generic;
using System.Text;
using AbpByExample.Localization;
using Volo.Abp.Application.Services;

namespace AbpByExample;

/* Inherit your application services from this class.
 */
public abstract class AbpByExampleAppService : ApplicationService
{
    protected AbpByExampleAppService()
    {
        LocalizationResource = typeof(AbpByExampleResource);
    }
}
