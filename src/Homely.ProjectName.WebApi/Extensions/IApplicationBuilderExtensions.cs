using System.Reflection;
using Microsoft.AspNetCore.Builder;

namespace Homely.ProjectName.WebApi.Extensions
{
    public static class IApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseCustomizedSwagger(this IApplicationBuilder app)
        {
            return app.UseSwagger()
                      .UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", $"{Assembly.GetExecutingAssembly().FullName} V1"); });
        }
    }
}