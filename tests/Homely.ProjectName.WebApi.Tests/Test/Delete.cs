using System.Net;
using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Homely.ProjectName.WebApi.Tests.Test
{
    public class Delete : ControllerTest
    {
        [Fact]
        public async Task GivenAValidId_ReturnsHttp204()
        {
            // Arrange.
            const int id = 1;

            // Act.
            var response = await Client.DeleteAsync($"/test/{id}");

            // Assert.
            response.IsSuccessStatusCode.ShouldBeTrue();
            response.StatusCode.ShouldBe(HttpStatusCode.NoContent);
        }

        [Fact]
        public async Task GivenAnInvalidId_ReturnsHttp404()
        {
            // Arrange.
            const int id = 0;

            // Act.
            var response = await Client.DeleteAsync($"/test/{id}");

            // Assert.
            response.IsSuccessStatusCode.ShouldBeFalse();
            response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
        }
    }
}