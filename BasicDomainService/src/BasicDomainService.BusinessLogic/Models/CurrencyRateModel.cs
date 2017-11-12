namespace BasicDomainService.BusinessLogic.Models
{
    public class CurrencyRateModel
    {
        public Currencies Base { get; set; }
        public Currencies Target { get; set; }
        public decimal Rate { get; set; }
    }
}