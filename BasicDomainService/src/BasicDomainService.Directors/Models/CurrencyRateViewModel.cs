using System.Runtime.Serialization;

namespace BasicDomainService.Directors.Models
{
    [DataContract(Name = "currencyRate")]
    public class CurrencyRateViewModel
    {
        [DataMember(Name = "baseIsoAlphabetic")]
        public string Base { get; set; }

        [DataMember(Name = "baseIsoDigital")]
        public short BaseIso { get; set; }

        [DataMember(Name = "targetIsoAlphabetic")]
        public string Target { get; set; }

        [DataMember(Name = "targetIsoDigital")]
        public short TargetIso { get; set; }

        [DataMember(Name = "exchangeRate")]
        public decimal Rate { get; set; }
    }
}