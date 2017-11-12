using System.Configuration;

namespace BasicDomainService.ExternalService.Settings
{
    public class ApiConfig
    {
        public string CurrencyExchangeApiUri => ConfigurationManager.AppSettings[nameof(CurrencyExchangeApiUri)];
    }
}