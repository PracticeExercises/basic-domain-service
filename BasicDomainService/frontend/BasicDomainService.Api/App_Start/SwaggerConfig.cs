using System.Web.Http;
using WebActivatorEx;
using BasicDomainService.Api;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]
namespace BasicDomainService.Api
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "Basic Domain Service API");
                    })
                .EnableSwaggerUi(c =>
                    {
                        c.DocumentTitle("Basic Domain Service");
                        c.DisableValidator();
                    });
        }
    }
}
