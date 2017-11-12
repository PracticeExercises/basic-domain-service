using System;
using BasicDomainService.BusinessLogic.Abstraction;
using BasicDomainService.BusinessLogic.Services;
using BasicDomainService.Directors.Abstraction;
using BasicDomainService.Directors.Models;

namespace BasicDomainService.Directors.Time
{
    public class TimeDirector : ITimeDirector
    {
        private readonly ITimeService _timeService;

        public TimeDirector(ITimeService timeService)
        {
            _timeService = timeService;
        }

        public TimeViewModel GetLocalTimeView()
        {
            var localTime = _timeService.GetLocalTime();
            var vmodel = new TimeViewModel
            {
                FormattedTime = $"{localTime.TimeStamp:HHmm}",
                FormattedDate = $"{localTime.TimeStamp:yyyyMMdd}",
                Week = localTime.WeekOfYear
            };
            return vmodel;
        }
    }
}