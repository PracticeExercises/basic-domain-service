using System.Collections.Generic;
using AutoMapper;
using BasicDomainService.BusinessLogic.Models;
using BasicDomainService.ExternalService.Models;

namespace BasicDomainService.BusinessLogic.Mappings
{
    public class CurrencyProfile : Profile
    {
        public CurrencyProfile()
        {
            CreateMap<CurrencyModel, IEnumerable<CurrencyRateModel>>().ConvertUsing<CurrencyConverter>();
        }
    }
}