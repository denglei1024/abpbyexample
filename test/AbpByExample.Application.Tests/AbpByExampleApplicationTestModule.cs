using Volo.Abp.Modularity;

namespace AbpByExample;

[DependsOn(
    typeof(AbpByExampleApplicationModule),
    typeof(AbpByExampleDomainTestModule)
)]
public class AbpByExampleApplicationTestModule : AbpModule
{

}
