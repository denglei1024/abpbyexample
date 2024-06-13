using Volo.Abp.Modularity;

namespace AbpByExample;

public abstract class AbpByExampleApplicationTestBase<TStartupModule> : AbpByExampleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
