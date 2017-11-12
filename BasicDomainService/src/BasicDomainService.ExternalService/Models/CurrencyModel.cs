using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BasicDomainService.ExternalService.Models
{
    [DataContract(Name = "currency")]
    public class CurrencyModel
    {
        [DataMember(Name = "base")]
        public string Name { get; set; }

        [DataMember(Name = "rates")]
        public Dictionary<string, decimal> Rates { get; set; } = new Dictionary<string, decimal>();
    }
}