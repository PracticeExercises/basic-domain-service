using System.Threading.Tasks;
using System.Web.Http;
using BasicDomainService.Directors.Abstraction;

namespace BasicDomainService.Api.Controllers
{
    [RoutePrefix("api")]
    // ReSharper disable once HollowTypeName
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
            return Ok(await _currencyDirector.GetRateViewAsync(currencyNameIsoAlphabetic));
        }
    }
}