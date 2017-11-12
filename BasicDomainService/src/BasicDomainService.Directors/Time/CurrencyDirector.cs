using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BasicDomainService.BusinessLogic.Abstraction;
using BasicDomainService.Directors.Abstraction;
using BasicDomainService.Directors.Models;

namespace BasicDomainService.Directors.Time
{
    public class CurrencyDirector : ICurrencyDirector
    {
        private readonly ICurrencyService _currencyService;
        private readonly IMapper _mapper;

        public CurrencyDirector(ICurrencyService currencyService, IMapper mapper)
        {
            _currencyService = currencyService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CurrencyRateViewModel>> GetRateViewAsync()
        {
            var rates = await _currencyService.GetRatesAsync();
            return _mapper.Map<IEnumerable<CurrencyRateViewModel>>(rates);
        }
    }
}