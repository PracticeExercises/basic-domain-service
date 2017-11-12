using System.Collections.Generic;
using System.Threading.Tasks;
using BasicDomainService.Directors.Models;

namespace BasicDomainService.Directors.Abstraction
{
    public interface ICurrencyDirector
    {
        Task<IEnumerable<CurrencyRateViewModel>> GetRateViewAsync(string currencyIsoName);
    }
}