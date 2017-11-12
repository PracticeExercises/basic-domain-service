using System.Threading.Tasks;
using System.Web.Http;
using BasicDomainService.Directors.Abstraction;

namespace BasicDomainService.Api.Controllers
{
    [RoutePrefix("api")]
    public class CurrencyController : ApiController
    {
        private readonly ICurrencyDirector _currencyDirector;

        public CurrencyController(ICurrencyDirector currencyDirector)
        {
            _currencyDirector = currencyDirector;
        }

        [Route("rates/{currencyNameIsoAlphabetic:alpha}")]
        public async Task<IHttpActionResult> GetRatesAsync(string currencyNameIsoAlphabetic)
        {
            var models = await _currencyDirector.GetRateViewAsync(currencyNameIsoAlphabetic);
            return models == null ? (IHttpActionResult) NotFound() : Ok(models);
        }
    }
}