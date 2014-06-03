
using System;
using System.Linq;

namespace CSharpEx
{
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
    }
}
