using BasicDomainService.BusinessLogic.Abstraction;
using BasicDomainService.BusinessLogic.Models;
using BasicDomainService.BusinessLogic.Time;

namespace BasicDomainService.BusinessLogic.Services
{
    public class TimeService : ITimeService
    {
        private readonly ISystemTime _time;
        private readonly IWeekOfYear _woy;

        public TimeService(ISystemTime time, IWeekOfYear woy)
        {
            _time = time;
            _woy = woy;
        }

        public TimeModel GetLocalTime()
        {
            return new TimeModel {WeekOfYear = _woy.GetIso8601WeekOfYear(_time.Now), TimeStamp = _time.Now};
        }
    }
}