using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace File.Uploading.Pages;

public class Index_Tests : UploadingWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
