using BasicDomainService.BusinessLogic.Models;

namespace BasicDomainService.BusinessLogic.Abstraction
{
    public interface ITimeService
    {
        TimeModel GetLocalTime();
    }
}