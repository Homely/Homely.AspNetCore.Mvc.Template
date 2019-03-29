using Hellang.Middleware.ProblemDetails;
using Homely.AspNetCore.Mvc.Helpers.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Homely.AspNetCore.WebApi.Template
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _hostingEnvironment;

        public Startup(IConfiguration configuration,
                       IHostingEnvironment hostingEnvironment)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _hostingEnvironment = hostingEnvironment ?? throw new ArgumentNullException(nameof(hostingEnvironment));
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            services.AddMvcCore(options =>
            {
                options.WithGlobalCancelledRequestHandler(); // Handle a user-cancelled request.
            })
                    .AddAHomeController(services, typeof(Startup), "*** Your WebApi Banner ***")
                    .AddACommonJsonFormatter()
                    .AddApiExplorer()
                    .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddProblemDetails(options => options.IncludeExceptionDetails = _ => _hostingEnvironment.IsDevelopment())
                    .AddCustomSwagger("swagger-title", "swagger-version");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseProblemDetails()
               .UseMvc()
               .UseCustomSwagger("swagger-routeprefix", "swagger-title", "swagger-version");
        }
    }
}
