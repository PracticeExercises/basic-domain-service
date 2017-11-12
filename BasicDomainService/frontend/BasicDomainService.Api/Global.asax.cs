using System.Web;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using BasicDomainService.Directors;

namespace BasicDomainService.Api
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            var builder = new ContainerBuilder();
            var assembly = typeof(WebApiConfig).Assembly;
            builder.RegisterApiControllers(assembly);
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces();
            builder.RegisterModule<DirectorsModule>();
            var container = builder.Build();

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}