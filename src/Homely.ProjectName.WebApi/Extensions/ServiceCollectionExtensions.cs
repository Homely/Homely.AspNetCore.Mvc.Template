using System;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace Homely.ProjectName.WebApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomSwagger(this IServiceCollection services)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            return services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1",
                                   new Info
                                   {
                                       Title = Assembly.GetExecutingAssembly().FullName,
                                       Version = "v1"
                                   });
            });
        }
    }
}