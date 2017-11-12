using System.Runtime.Serialization;

namespace BasicDomainService.Directors.Models
{
    [DataContract(Name = "currency")]
    public class CurrencyRateViewModel
    {
        [DataMember(Name = "base")]
        public string Base { get; set; }

        [DataMember(Name = "target")]
        public string Target { get; set; }

        [DataMember(Name = "rate")]
        public decimal Rate { get; set; }
    }
}