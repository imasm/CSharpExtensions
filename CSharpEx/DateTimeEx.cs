using System;
namespace CSharpEx
{
    /// <summary>
    /// DateTime Extensions
    /// </summary>
    public static class DateTimeEx
    {
        /// <summary>
        /// Gets the day of the week represented by this instance.
        /// According to the international standard ISO 8601, Monday shall be the 
        /// first day of the week ending with Sunday as the last day of the week
        /// </summary>
        public static int DayOfWeekEU(this DateTime dateTime)
        {
            int day = ((int) dateTime.DayOfWeek) - 1;
            if (day < 0)
                day = 6;
            return day;
        }
    }
}
