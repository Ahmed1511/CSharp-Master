using System;

namespace CAExtentionMethod
{
    public static class DateTimeHelper
    {
        public static bool IsWeekEnd(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Friday)
            {
                return true;
            }
            return false;
        }

        public static bool IsWeekDay(DateTime date)
        {
            return !IsWeekEnd(date);
        }
    }
}
