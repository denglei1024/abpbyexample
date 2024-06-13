using Microsoft.AspNetCore.Builder;
using AbpByExample;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<AbpByExampleWebTestModule>();

public partial class Program
{
}
