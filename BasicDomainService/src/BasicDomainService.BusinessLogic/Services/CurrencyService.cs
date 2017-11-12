using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BasicDomainService.BusinessLogic.Abstraction;
using BasicDomainService.BusinessLogic.Models;
using BasicDomainService.BusinessLogic.Time;
using BasicDomainService.ExternalService.Abstraction;

namespace BasicDomainService.BusinessLogic.Services
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrencyClient _currencyClient;
        private readonly IMapper _mapper;
        private readonly ISystemTime _time;

        public CurrencyService(
            ISystemTime time,
            ICurrencyClient currencyClient,
            IMapper mapper)
        {
            _time = time;
            _currencyClient = currencyClient;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CurrencyRateModel>> GetRatesAsync(string currencyIsoName)
        {
            var model = await _currencyClient.GetCurrencyAsync(currencyIsoName, _time.Now);
            return model != null ? _mapper.Map<IEnumerable<CurrencyRateModel>>(model) : null;
        }
    }
}