using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using BasicDomainService.BusinessLogic.Abstraction;
using BasicDomainService.BusinessLogic.Models;
using BasicDomainService.BusinessLogic.Time;
using BasicDomainService.ExternalService.Abstraction;
using BasicDomainService.ExternalService.Clients;

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

        public async Task<IEnumerable<CurrencyRateModel>> GetRatesAsync()
        {
            var model = await _currencyClient.GetCurrencyAsync(_time.Now);
            return model != null ? _mapper.Map<IEnumerable<CurrencyRateModel>>(model) : null;
        }
    }
}