using Autofac;
using AutoMapper;
using BasicDomainService.BusinessLogic;
using BasicDomainService.BusinessLogic.Mappings;
using BasicDomainService.Directors.Mappings;

namespace BasicDomainService.Directors
{
    public class DirectorsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(ThisAssembly).AsImplementedInterfaces();
            builder.RegisterModule<LogicModule>();

            var config = new MapperConfiguration(x =>
            {
                x.AddProfile<CurrencyProfile>();
                x.AddProfile<CurrencyRateProfile>();
            });
            builder.Register(c => new Mapper(config)).As<IMapper>().SingleInstance();

            base.Load(builder);
        }
    }
}