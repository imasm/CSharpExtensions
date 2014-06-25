
using System;
using System.Linq;

namespace CSharpEx
{
    /// <summary>
    /// String Extensions
    /// </summary>
    public static class StringEx
    {
        #region SafeSubstring

        /// <summary>
        /// Safe Substring. Substring with range checking.
        /// </summary>
        /// <param name="startIndex">The zero-based starting character position of a substring in this instance.</param>
        /// <returns>A string that is equivalent to the substring of length length that begins at startIndex in this instance, or Empty if startIndex is equal to the length of this instance and length is zero.</returns>
        public static string SafeSubstring(this string s, int startIndex)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            if (startIndex >= s.Length)
                return string.Empty;

            return s.Substring(startIndex);
        }

        /// <summary>
        /// Safe Substring. Substring with range checking.
        /// </summary>
        /// <param name="startIndex">The zero-based starting character position of a substring in this instance.</param>
        /// <param name="length">The number of characters in the substring.</param>
        /// <returns>A string that is equivalent to the substring of length length that begins at startIndex in this instance, or Empty if startIndex is equal to the length of this instance and length is zero.</returns>
        public static string SafeSubstring(this string s, int startIndex, int length)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            if (startIndex >= s.Length)
                return string.Empty;

            if ((startIndex + length) > s.Length)
            {
                return s.Substring(startIndex);
            }

            return s.Substring(startIndex, length);
        }
        #endregion

        #region Left

        /// <summary>
        /// Returns a string containing a specified number of characters from the left side of a string.
        /// </summary>
        /// <param name="s">String expression from which the leftmost characters are returned.</param>
        /// <param name="length">Numeric expression indicating how many characters to return.</param>
        /// <returns>Returns a string containing a specified number of characters from the left side of a string.</returns>
        public static string Left(this string s, int length)
        {
            if (length <= 0)
                return string.Empty;

            if (length >= s.Length)
                return s;

            return s.Substring(0, length);
        }

        #endregion

        #region Right

        /// <summary>
        /// Returns a string containing a specified number of characters from the right side of a string.
        /// </summary>
        /// <param name="s">String expression from which the rightmost characters are returned. </param>
        /// <param name="length">Numeric expression indicating how many characters to return.</param>
        /// <returns>Returns a string containing a specified number of characters from the right side of a string.</returns>
        public static string Right(this string s, int length)
        {
            if (length <= 0)
                return string.Empty;

            int len = s.Length;
            if (length >= len)
                return s;

            return s.Substring(len - length);
        }

        #endregion

        #region SplitAndTrim

        /// <summary>
        /// Split string into array and Trim() each one
        /// </summary>
        /// <param name="separator">An array of Unicode characters that delimit the substrings in this instance, an empty array that contains no delimiters, or null.</param>
        /// <returns>An array whose elements contain the substrings in this string that are delimited by one or more characters in separator.</returns>
        public static string[] SplitAndTrim(this string s, char[] separator)
        {
            return s.Split(separator).Select(p => p.Trim()).ToArray();
        }

        /// <summary>
        /// Split string into array and Trim() each one
        /// </summary>
        /// <param name="separator">An array of Unicode characters that delimit the substrings in this instance, an empty array that contains no delimiters, or null.</param>
        /// <param name="options">RemoveEmptyEntries to omit empty array elements from the array returned; or None to include empty array elements in the array returned.</param>
        /// <returns>An array whose elements contain the substrings in this string that are delimited by one or more characters in separator.</returns>
        public static string[] SplitAndTrim(this string s, char[] separator, StringSplitOptions options)
        {
            return s.Split(separator, options).Select(p => p.Trim()).ToArray();
        }

        #endregion


        /// <summary>
        /// Format string. Is equivalent to string.Format()
        /// </summary>
        public static string Format(this string format, params object[] args)
        {
            return string.Format(format, args);
        }
    }
}
