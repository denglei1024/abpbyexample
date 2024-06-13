using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpByExample.Data;

/* This is used if database provider does't define
 * IAbpByExampleDbSchemaMigrator implementation.
 */
public class NullAbpByExampleDbSchemaMigrator : IAbpByExampleDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
