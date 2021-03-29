using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Voyager.Services.Pages
{
    public class Index_Tests : ServicesWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
