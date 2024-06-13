using AbpByExample.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpByExample.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpByExampleMongoDbModule),
    typeof(AbpByExampleApplicationContractsModule)
    )]
public class AbpByExampleDbMigratorModule : AbpModule
{
}
