using Volo.Abp.Modularity;

namespace AbpByExample;

/* Inherit from this class for your domain layer tests. */
public abstract class AbpByExampleDomainTestBase<TStartupModule> : AbpByExampleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
