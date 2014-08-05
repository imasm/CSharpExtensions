using System;

namespace CSharpEx
{
    /// <summary>
    /// String conversions
    /// </summary>
    public static class StringConversions
    {
        #region ParseToInt

        /// <summary>
        /// Converts the string representation of a number to its 32-bit signed integer equivalent.
        /// </summary>
        public static int ParseToInt(this string str)
        {
            return int.Parse(str);
        }

        /// <summary>
        /// Converts the string representation of a number to its 32-bit signed integer equivalent.
        /// </summary>
        public static int ParseToIntOrDefault(this string str, int defaultValue = default (int))
        {
            try
            {
                if (!string.IsNullOrEmpty(str))
                    return int.Parse(str);

                return defaultValue;
            }
            catch
            {
                return defaultValue;
            }
        }

        #endregion

        #region ParseToInt16 (Char)

        /// <summary>
        /// Converts the specified numeric Unicode character to a short number.
        /// </summary>
        /// <returns>The numeric value of c if that character represents a number; otherwise, -1</returns>
        public static short ParseToShort(this char ch)
        {
            return (short) Char.GetNumericValue(ch);
        }

        /// <summary>
        /// Converts the specified numeric Unicode character to a short number.
        /// </summary>
        /// <returns>The numeric value of c if that character represents a number; otherwise, defaultValue</returns>
        public static short ParseToShortOrDefault(this char ch, Int16 defaultValue = default (short))
        {
            short result = ParseToShort(ch);
            return result >= 0 ? result : defaultValue;
        }

        #endregion

        #region ParseToLong

        /// <summary>
        /// Converts the string representation of a number to its 64-bit signed integer equivalent.
        /// </summary>
        public static long ParseToLong(this string str)
        {
            return long.Parse(str);
        }

        /// <summary>
        /// Converts the string representation of a number to its 64-bit signed integer equivalent.
        /// </summary>
        public static long ParseToLongOrDefault(this string str, long defaultValue = default (long))
        {
            try
            {
                if (!string.IsNullOrEmpty(str))
                    return long.Parse(str);

                return defaultValue;
            }
            catch
            {
                return defaultValue;
            }
        }

        #endregion

        #region ParseToDecimal

        /// <summary>
        /// Converts the string representation of a number to its Decimal equivalent.
        /// </summary>
        public static decimal ParseToDecimal(this string str)
        {
            return decimal.Parse(str);
        }

        /// <summary>
        /// Converts the string representation of a number to its Decimal equivalent.
        /// </summary>
        public static decimal ParseToDecimalOrDefault(this string str, decimal defaultValue = default (decimal))
        {
            try
            {
                if (!string.IsNullOrEmpty(str))
                    return decimal.Parse(str);
                return defaultValue;
            }
            catch
            {
                return defaultValue;
            }
        }

        #endregion

        #region ParseToDouble

        /// <summary>
        /// Converts the string representation of a number to its Double equivalent.
        /// </summary>
        public static double ParseToDouble(this string str)
        {
            return double.Parse(str);
        }

        /// <summary>
        /// Converts the string representation of a number to its Double equivalent.
        /// </summary>
        public static double ParseToDoubleOrDefault(this string str, double defaultValue = default (double))
        {
            try
            {
                if (!string.IsNullOrEmpty(str))
                    return double.Parse(str);

                return defaultValue;
            }
            catch
            {
                return defaultValue;
            }
        }

        #endregion
    }
}