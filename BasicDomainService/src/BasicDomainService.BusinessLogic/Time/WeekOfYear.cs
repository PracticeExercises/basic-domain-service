using System;
using System.Globalization;

namespace BasicDomainService.BusinessLogic.Time
{
    public class WeekOfYear : IWeekOfYear
    {
        public int GetIso8601WeekOfYear(DateTime time)
        {
            var day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);

            if (day >= DayOfWeek.Monday)
                if (day <= DayOfWeek.Wednesday)
                    time = time.AddDays(3);

            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time,
                CalendarWeekRule.FirstFourDayWeek,
                DayOfWeek.Monday);
        }
    }
}