using System;

namespace CAExtentionMethod
{
    public static class DateTimeExtintions
    {
        public static bool IsWeekEnd(this DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Friday)
            {
                return true;
            }
            return false;
        }

        public static bool IsWeekDay(this DateTime date)
        {
            return !IsWeekEnd(date);
        }
    }
}
