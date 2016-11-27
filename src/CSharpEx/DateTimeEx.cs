#region LICENSE

//    Copyright 2014 Ivan Masmità
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

#endregion

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
            return new DateTime((dt.Ticks / divisor.Ticks) * divisor.Ticks);
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
            double m = (double) (dt.Ticks % divisor.Ticks) / divisor.Ticks;
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