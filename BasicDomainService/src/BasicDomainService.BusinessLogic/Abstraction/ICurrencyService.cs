using System.Collections.Generic;
using System.Threading.Tasks;
using BasicDomainService.BusinessLogic.Models;

namespace BasicDomainService.BusinessLogic.Abstraction
{
    public interface ICurrencyService
    {
        Task<IEnumerable<CurrencyRateModel>> GetRatesAsync(string currencyIsoName);
    }
}