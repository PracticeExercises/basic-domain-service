using System;

namespace BasicDomainService.BusinessLogic.Time
{
    public class SystemTime : ISystemTime
    {
        public DateTime Now => GetLocalTime();

        private static DateTime GetLocalTime()
        {
            var timeUtc = DateTime.UtcNow;
            var cstZone = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
            return TimeZoneInfo.ConvertTimeFromUtc(timeUtc, cstZone);
        }
    }
}