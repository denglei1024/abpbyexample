using Volo.Abp.Modularity;

namespace AbpByExample;

[DependsOn(
    typeof(AbpByExampleDomainModule),
    typeof(AbpByExampleTestBaseModule)
)]
public class AbpByExampleDomainTestModule : AbpModule
{

}
