using Autofac;
using BasicDomainService.ExternalService.Serializers;
using BasicDomainService.ExternalService.Settings;
using RestSharp;

namespace BasicDomainService.ExternalService
{
    public class ExternalModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly).AsImplementedInterfaces();
            builder.RegisterType<ApiConfig>().AsSelf();
            builder.Register(context =>
            {
                var restClient = new RestClient(new ApiConfig().CurrencyExchangeApiUri);
                restClient.AddHandler("application/json", new NewtonsoftJsonSerializer());
                return restClient;
            }).As<IRestClient>();
            base.Load(builder);
        }
    }
}