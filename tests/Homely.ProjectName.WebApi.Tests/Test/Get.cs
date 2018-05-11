using System.Net;
using System.Threading.Tasks;
using Homely.ProjectName.WebApi.Models;
using Newtonsoft.Json;
using Shouldly;
using Xunit;

namespace Homely.ProjectName.WebApi.Tests.Test
{
    public class Get : ControllerTest
    {
        [Fact]
        public async Task GivenAValidId_ReturnsHttp200()
        {
            // Arrange.
            const int id = 1;
            var expectedModel = new TestModel
            {
                Id = id,
                Name = $"Test #{id}"
            };

            // Act.
            var response = await Client.GetAsync($"/test/{id}");

            // Assert.
            response.IsSuccessStatusCode.ShouldBeTrue();
            var actualModel = JsonConvert.DeserializeObject<TestModel>(await response.Content.ReadAsStringAsync());
            actualModel.ShouldNotBeNull();
            actualModel.Id.ShouldBe(expectedModel.Id);
            actualModel.Name.ShouldBe(expectedModel.Name);
        }

        [Fact]
        public async Task GivenAnInvalidId_ReturnsHttp404()
        {
            // Arrange.
            const int id = 0;

            // Act.
            var response = await Client.GetAsync($"/test/{id}");

            // Assert.
            response.IsSuccessStatusCode.ShouldBeFalse();
            response.StatusCode.ShouldBe(HttpStatusCode.NotFound);
        }
    }
}