using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AutoMapper;
using BasicDomainService.BusinessLogic.Models;
using BasicDomainService.ExternalService.Models;

namespace BasicDomainService.BusinessLogic.Mappings
{
    public class CurrencyConverter : ITypeConverter<CurrencyModel, IEnumerable<CurrencyRateModel>>
    {
        public IEnumerable<CurrencyRateModel> Convert(
            CurrencyModel source,
            IEnumerable<CurrencyRateModel> destination,
            ResolutionContext context)
        {
            if (context == null)
                return null;

            if (source == null)
                return null;

            var baseCurrencyName = source.Name;
            Currencies baseCurrency;

            return !Enum.TryParse(baseCurrencyName, true, out baseCurrency)
                ? null
                : ConvertCurrencies(source, baseCurrency);
        }

        private static IEnumerable<CurrencyRateModel> ConvertCurrencies(CurrencyModel source, Currencies baseCurrency)
        {
            var currencies = new Collection<CurrencyRateModel>();

            var currencyNames = Enum.GetNames(typeof(Currencies));
            foreach (var name in currencyNames)
            {
                var upperName = name.ToUpperInvariant();
                if (source.Rates.ContainsKey(upperName))
                {
                    var rate = source.Rates[upperName];
                    var convertedModel = new CurrencyRateModel
                    {
                        Base = baseCurrency,
                        Rate = rate,
                        Target = (Currencies) Enum.Parse(typeof(Currencies), name)
                    };
                    currencies.Add(convertedModel);
                }
            }

            return currencies;
        }
    }
}