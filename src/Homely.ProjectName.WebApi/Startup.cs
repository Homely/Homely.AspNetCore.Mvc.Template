using Homely.AspNetCore.Mvc.Helpers.Extensions;
using Homely.ProjectName.WebApi.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Homely.ProjectName.WebApi
{
    public class Startup
    {
        private IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCustomSwagger()
                    .AddMvcCore()
                    .AddACommonJsonFormatter()
                    .AddCustomFluentValidation(typeof(Startup))
                    .AddApiExplorer();
        }

        public void Configure(IApplicationBuilder app,
                              IHostingEnvironment env)
        {
            app.UseStaticFiles()
               .UseStatusCodePages()
               .UseJsonExceptionPages()
               .UseCustomizedSwagger()
               .UseMvc();
        }
    }
}