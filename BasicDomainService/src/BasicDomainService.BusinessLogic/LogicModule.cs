using Autofac;
using BasicDomainService.ExternalService;

namespace BasicDomainService.BusinessLogic
{
    public class LogicModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly).AsImplementedInterfaces();
            builder.RegisterModule<ExternalModule>();
            base.Load(builder);
        }
    }
}