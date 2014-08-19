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
        public static string SafeSubstring(this string thisString, int startIndex)
        {
            if (string.IsNullOrEmpty(thisString))
                return string.Empty;

            if (startIndex >= thisString.Length)
                return string.Empty;

            return thisString.Substring(startIndex);
        }

        /// <summary>
        /// Safe Substring. Substring with range checking.
        /// </summary>
        /// <param name="startIndex">The zero-based starting character position of a substring in this instance.</param>
        /// <param name="length">The number of characters in the substring.</param>
        /// <returns>A string that is equivalent to the substring of length length that begins at startIndex in this instance, or Empty if startIndex is equal to the length of this instance and length is zero.</returns>
        public static string SafeSubstring(this string thisString, int startIndex, int length)
        {
            if (string.IsNullOrEmpty(thisString))
                return string.Empty;

            if (startIndex >= thisString.Length)
                return string.Empty;

            if ((startIndex + length) > thisString.Length)
            {
                return thisString.Substring(startIndex);
            }

            return thisString.Substring(startIndex, length);
        }

        #endregion

        #region Left

        /// <summary>
        /// Returns a string containing a specified number of characters from the left side of a string.
        /// </summary>
        /// <param name="thisString">String expression from which the leftmost characters are returned.</param>
        /// <param name="length">Numeric expression indicating how many characters to return.</param>
        /// <returns>Returns a string containing a specified number of characters from the left side of a string.</returns>
        public static string Left(this string thisString, int length)
        {
            if (length <= 0)
                return string.Empty;

            if (length >= thisString.Length)
                return thisString;

            return thisString.Substring(0, length);
        }

        #endregion

        #region Right

        /// <summary>
        /// Returns a string containing a specified number of characters from the right side of a string.
        /// </summary>
        /// <param name="thisString">String expression from which the rightmost characters are returned. </param>
        /// <param name="length">Numeric expression indicating how many characters to return.</param>
        /// <returns>Returns a string containing a specified number of characters from the right side of a string.</returns>
        public static string Right(this string thisString, int length)
        {
            if (length <= 0)
                return string.Empty;

            int len = thisString.Length;
            if (length >= len)
                return thisString;

            return thisString.Substring(len - length);
        }

        #endregion

        #region SplitAndTrim

        /// <summary>
        /// Split string into array and Trim() each one
        /// </summary>
        /// <param name="separator">An array of Unicode characters that delimit the substrings in this instance, an empty array that contains no delimiters, or null.</param>
        /// <returns>An array whose elements contain the substrings in this string that are delimited by one or more characters in separator.</returns>
        public static string[] SplitAndTrim(this string thisString, char[] separator)
        {
            return thisString.Split(separator).Select(p => p.Trim()).ToArray();
        }

        /// <summary>
        /// Split string into array and Trim() each one
        /// </summary>
        /// <param name="separator">An array of Unicode characters that delimit the substrings in this instance, an empty array that contains no delimiters, or null.</param>
        /// <param name="options">RemoveEmptyEntries to omit empty array elements from the array returned; or None to include empty array elements in the array returned.</param>
        /// <returns>An array whose elements contain the substrings in this string that are delimited by one or more characters in separator.</returns>
        public static string[] SplitAndTrim(this string thisString, char[] separator, StringSplitOptions options)
        {
            return thisString.Split(separator, options)
                .Select(p => p.Trim())
                .Where(p => !(options == StringSplitOptions.RemoveEmptyEntries && p.IsNullOrEmpty()))
                .ToArray();
        }

        #endregion

        #region Format
        /// <summary>
        /// Format string. Is equivalent to string.Format()
        /// </summary>
        public static string Format(this string thisFormat, params object[] args)
        {
            return string.Format(thisFormat, args);
        }
        #endregion

        #region IsNull
        /// <summary>
        /// Indicates whether the specified string is null or an Empty string.
        /// </summary>
        public static bool IsNullOrEmpty(this string thisString)
        {
            return string.IsNullOrEmpty(thisString);
        }

        /// <summary>
        /// Indicates whether a specified string is null, empty, or consists only of white-space characters.
        /// </summary>
        public static bool IsNullOrWhiteSpace(this string thisString)
        {
            return (thisString == null) || (thisString.Trim() == String.Empty);
        }
        #endregion

        #region Equals

        /// <summary>
        /// Determines whether this instance and another specified String object have the same value or both are null. 
        /// </summary>
        public static bool EqualsNullSafe(this string thisString, string other)
        {
            if (thisString == null)
                return other == null;

            return thisString.Equals(other);
        }

        /// <summary>
        /// Determines whether this instance and another specified String object have the same value or both are null. 
        /// </summary>
        public static bool EqualsNullSafe(this string thisString, string other, StringComparison stringComparison)
        {
            if (thisString == null)
                return other == null;

            return thisString.Equals(other, stringComparison);
        }

        /// <summary>
        /// Determines whether this instance and another specified String object have the same value or both are null. 
        /// Uses StringComparison.InvariantCulture in the comparison.
        /// </summary>
        public static bool EqualsInv(this string thisString, string other)
        {
            return EqualsNullSafe(thisString, other, StringComparison.InvariantCulture);
        }

        /// <summary>
        /// Determines whether this instance and another specified String object have the same value or both are null. 
        /// Uses StringComparison.InvariantCultureIgnoreCase in the comparison.
        /// </summary>
        public static bool EqualsInvIC(this string thisString, string other)
        {
            return EqualsNullSafe(thisString, other, StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// Determines whether this instance and another specified String object have the same value or both are null. 
        /// Uses StringComparison.Ordinal in the comparison.
        /// </summary>
        public static bool EqualsOrd(this string thisString, string other)
        {
            return EqualsNullSafe(thisString, other, StringComparison.Ordinal);
        }

        /// <summary>
        /// Determines whether this instance and another specified String object have the same value or both are null. 
        /// Uses StringComparison.OrdinalIgnoreCase in the comparison.
        /// </summary>
        public static bool EqualsOrdIC(this string thisString, string other)
        {
            return EqualsNullSafe(thisString, other, StringComparison.OrdinalIgnoreCase);
        }

        #endregion
    }
}