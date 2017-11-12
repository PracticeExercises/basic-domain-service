using System.Web.Http;
using BasicDomainService.Directors.Abstraction;

namespace BasicDomainService.Api.Controllers
{
    [RoutePrefix("api/time")]
    // ReSharper disable once HollowTypeName
    public class TimeController : ApiController
    {
        private readonly ITimeDirector _timeDirector;

        public TimeController(ITimeDirector timeDirector)
        {
            _timeDirector = timeDirector;
        }

        [Route("now")]
        [HttpGet]
        public IHttpActionResult GetTime()
        {
            return Ok(_timeDirector.GetLocalTimeView());
        }
    }
}