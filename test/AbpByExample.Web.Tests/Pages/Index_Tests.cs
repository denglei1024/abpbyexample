using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AbpByExample.Pages;

public class Index_Tests : AbpByExampleWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
