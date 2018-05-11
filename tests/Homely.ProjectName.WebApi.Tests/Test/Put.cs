using System.Net;
using System.Threading.Tasks;
using Homely.ProjectName.WebApi.Models;
using Homely.ProjectName.WebApi.Tests.Extensions;
using Shouldly;
using Xunit;

namespace Homely.ProjectName.WebApi.Tests.Test
{
    public class Put : ControllerTest
    {
        [Fact]
        public async Task GivenAValidCommand_ReturnsHttp200()
        {
            // Arrange.
            var command = new AddOrUpdateTestCommand
            {
                Name = "Test"
            };

            // Act.
            var response = await Client.PutJsonAsync("/test", command);

            // Assert.
            response.IsSuccessStatusCode.ShouldBeTrue();
            response.StatusCode.ShouldBe(HttpStatusCode.OK);
        }

        [Fact]
        public async Task GivenAnInvalidCommand_ReturnsHttp400()
        {
            // Arrange.
            var command = new AddOrUpdateTestCommand
            {
                Name = ""
            };

            // Act.
            var response = await Client.PutJsonAsync("/test", command);

            // Assert.
            response.IsSuccessStatusCode.ShouldBeFalse();
            response.StatusCode.ShouldBe(HttpStatusCode.BadRequest);
        }
    }
}