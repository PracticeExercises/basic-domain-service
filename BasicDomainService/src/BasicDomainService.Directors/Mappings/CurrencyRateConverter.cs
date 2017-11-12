using System.Collections.Generic;
using System.Collections.ObjectModel;
using AutoMapper;
using BasicDomainService.BusinessLogic.Models;
using BasicDomainService.Directors.Models;

namespace BasicDomainService.Directors.Mappings
{
    public class CurrencyRateConverter : ITypeConverter<IEnumerable<CurrencyRateModel>, IEnumerable<CurrencyRateViewModel>>
    {
        public IEnumerable<CurrencyRateViewModel> Convert(IEnumerable<CurrencyRateModel> source, IEnumerable<CurrencyRateViewModel> destination, ResolutionContext context)
        {
            if (context == null)
                return new CurrencyRateViewModel[0];

            if (source == null)
                return new CurrencyRateViewModel[0];

            var rates = new Collection<CurrencyRateViewModel>();

            foreach (var rateModel in source)
            {
                var model = new CurrencyRateViewModel
                {
                    Base = rateModel.Base.ToString().ToUpperInvariant(),
                    Target = rateModel.Target.ToString().ToUpperInvariant(),
                    Rate = rateModel.Rate
                };

                rates.Add(model);
            }
            return rates;
        }
    }
}