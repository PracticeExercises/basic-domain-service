using System;
using System.Threading.Tasks;
using BasicDomainService.ExternalService.Models;

namespace BasicDomainService.ExternalService.Abstraction
{
    public interface ICurrencyClient
    {
        Task<CurrencyModel> GetCurrencyAsync(string currencyIsoName, DateTime dateTimeSnapshot);
    }
}