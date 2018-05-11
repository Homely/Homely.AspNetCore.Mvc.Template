using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace Homely.ProjectName.WebApi.Tests
{
    public abstract class ControllerTest
    {
        protected readonly HttpClient Client;

        protected ControllerTest()
        {
            var server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = server.CreateClient();
        }
    }
}