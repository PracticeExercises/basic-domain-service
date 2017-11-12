using System.Collections.Generic;
using AutoMapper;
using BasicDomainService.BusinessLogic.Models;
using BasicDomainService.Directors.Models;

namespace BasicDomainService.Directors.Mappings
{
    public class CurrencyRateProfile : Profile
    {
        public CurrencyRateProfile()
        {
            CreateMap<IEnumerable<CurrencyRateModel>, IEnumerable<CurrencyRateViewModel>>()
                .ConvertUsing<CurrencyRateConverter>();
        }
    }
}