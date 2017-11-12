using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BasicDomainService.BusinessLogic.Abstraction;
using BasicDomainService.Directors.Abstraction;
using BasicDomainService.Directors.Models;

namespace BasicDomainService.Directors.Currency
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

        public async Task<IEnumerable<CurrencyRateViewModel>> GetRateViewAsync(string currencyIsoName)
        {
            var rates = await _currencyService.GetRatesAsync(currencyIsoName);
            return _mapper.Map<IEnumerable<CurrencyRateViewModel>>(rates).OrderBy(a => a.TargetIso);
        }
    }
}