using System.Threading.Tasks;

namespace AbpByExample.Data;

public interface IAbpByExampleDbSchemaMigrator
{
    Task MigrateAsync();
}
