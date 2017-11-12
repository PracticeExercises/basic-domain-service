using System;

namespace BasicDomainService.BusinessLogic.Time
{
    public interface IWeekOfYear
    {
        int GetIso8601WeekOfYear(DateTime time);
    }
}