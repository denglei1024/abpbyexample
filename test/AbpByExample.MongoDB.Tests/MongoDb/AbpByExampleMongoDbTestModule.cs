using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace AbpByExample.MongoDB;

[DependsOn(
    typeof(AbpByExampleApplicationTestModule),
    typeof(AbpByExampleMongoDbModule)
)]
public class AbpByExampleMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = AbpByExampleMongoDbFixture.GetRandomConnectionString();
        });
    }
}
