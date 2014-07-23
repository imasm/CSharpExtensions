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

        #region Truncate
        /// <summary>
        /// Truncate DateTime
        /// </summary>
        public static DateTime TruncateTo(this DateTime dt, TimeSpan divisor)
        {
            return new DateTime((dt.Ticks / divisor.Ticks)  * divisor.Ticks);
        }
        
        /// <summary>
        /// Truncate DateTime to seconds
        /// </summary>
        public static DateTime TruncateToSecond(this DateTime dt)
        {
            return TruncateTo(dt, TimeSpan.FromSeconds(1));
        }

        /// <summary>
        /// Truncate DateTime to minutes
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime TruncateToMinute(this DateTime dt)
        {
            return TruncateTo(dt, TimeSpan.FromMinutes(1));
        }

        /// <summary>
        /// Truncate DateTime to hours
        /// </summary>
        public static DateTime TruncateToHours(this DateTime dt)
        {
            return TruncateTo(dt, TimeSpan.FromHours(1));
        }
        #endregion

        #region Round
        /// <summary>
        /// Round DateTime
        /// </summary>
        public static DateTime RoundTo(this DateTime dt, TimeSpan divisor)
        {
            int f = 0;
            double m = (double)(dt.Ticks % divisor.Ticks) / divisor.Ticks;
            if (m >= 0.5)
                f = 1;
            return new DateTime(((dt.Ticks / divisor.Ticks) + f) * divisor.Ticks);
        }

        /// <summary>
        /// Round DateTime to seconds
        /// </summary>
        public static DateTime RoundToSecond(this DateTime dt)
        {
            return RoundTo(dt, TimeSpan.FromSeconds(1));
        }

        /// <summary>
        /// Round DateTime to minutes
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime RoundToMinute(this DateTime dt)
        {
            return RoundTo(dt, TimeSpan.FromMinutes(1));
        }

        /// <summary>
        /// Round DateTime to hours
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static DateTime RoundToHours(this DateTime dt)
        {
            return RoundTo(dt, TimeSpan.FromHours(1));
        }
        #endregion
    }
}
