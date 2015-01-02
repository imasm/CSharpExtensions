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
using System.Data.Common;

namespace CSharpEx.Data
{
    /// <summary>
    /// Useful extensions for DbDataReader
    /// </summary>
    public static class DbDataReaderExtensions
    {
        #region GetChar

        /// <summary>
        /// Gets the value of the specified column as an instance of char. 
        /// If value is DbNull returns the default value.
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static char GetCharOrDefault(this DbDataReader dr, int i, char defaultValue)
        {
            string s = dr.GetStringOrDefault(i);
            if (string.IsNullOrEmpty(s))
                return defaultValue;

            return s[0];
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of char. 
        /// If value is DbNull returns the default value.
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static char GetCharOrDefault(this DbDataReader dr, int i)
        {
            return GetCharOrDefault(dr, i, default(char));
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of char. 
        /// If value is DbNull returns the default value.
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static char GetCharOrDefault(this DbDataReader dr, string columnName, char defaultValue)
        {
            return GetCharOrDefault(dr, dr.GetOrdinal(columnName), defaultValue);
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of char. 
        /// If value is DbNull returns the default value.
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static char GetCharOrDefault(this DbDataReader dr, string columnName)
        {
            return GetCharOrDefault(dr, dr.GetOrdinal(columnName), default(char));
        }

        #endregion

        #region GetString

        /// <summary>
        /// Gets the value of the specified column as an instance of String. 
        /// If value is DbNull returns the default value.
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static string GetStringOrDefault(this DbDataReader dr, int i, string defaultValue)
        {
            if (dr.IsDBNull(i))
                return defaultValue;

            return dr.GetString(i);
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of String. 
        /// If value is DbNull returns the default value.
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static string GetStringOrDefault(this DbDataReader dr, int i)
        {
            return GetStringOrDefault(dr, i, default(string));
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of String. 
        /// If value is DbNull returns the default value.
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static string GetStringOrDefault(this DbDataReader dr, string columnName, string defaultValue)
        {
            return GetStringOrDefault(dr, dr.GetOrdinal(columnName), defaultValue);
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of String. 
        /// If value is DbNull returns the default value.
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static string GetStringOrDefault(this DbDataReader dr, string columnName)
        {
            return GetStringOrDefault(dr, dr.GetOrdinal(columnName));
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of String. 
        /// If value is DbNull returns an empty string.
        /// </summary>
        public static string GetStringOrEmpty(this DbDataReader dr, int i)
        {
            return GetStringOrDefault(dr, i, string.Empty);
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of String.  
        /// If value is DbNull returns an empty string.
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static string ReadStringOrEmpty(this DbDataReader dr, string columnName)
        {
            return GetStringOrDefault(dr, dr.GetOrdinal(columnName), string.Empty);
        }

        #endregion

        #region GetInt

        /// <summary>
        /// Gets the value of the specified column as an instance of int. 
        /// If value is DbNull returns the default value.
        /// </summary>
        public static int GetIntOrDefault(this DbDataReader dr, int i, int defaultValue)
        {
            if (dr.IsDBNull(i))
                return defaultValue;
            return dr.GetInt32(i);
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of int. 
        /// If value is DbNull returns the default value.
        /// </summary>
        public static int GetIntOrDefault(this DbDataReader dr, int i)
        {
            return GetIntOrDefault(dr, i, default(int));
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of int. 
        /// If value is DbNull returns the default value.
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static int GetIntOrDefault(this DbDataReader dr, string columnName, int defaultValue)
        {
            return GetIntOrDefault(dr, dr.GetOrdinal(columnName), defaultValue);
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of int. 
        /// If value is DbNull returns the default value.
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static int GetIntOrDefault(this DbDataReader dr, string columnName)
        {
            return GetIntOrDefault(dr, dr.GetOrdinal(columnName));
        }

        #endregion

        #region GetShort

        /// <summary>
        /// Gets the value of the specified column as an instance of short. 
        /// If value is DbNull returns the default value.
        /// </summary>
        public static short GetShortOrDefault(this DbDataReader dr, int i, short defaultValue)
        {
            if (dr.IsDBNull(i))
                return defaultValue;
            return dr.GetInt16(i);
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of short. 
        /// If value is DbNull returns the default value.
        /// </summary>
        public static short GetShortOrDefault(this DbDataReader dr, int i)
        {
            return GetShortOrDefault(dr, i, default(short));
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of short. 
        /// If value is DbNull returns the default value.
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static short GetShortOrDefault(this DbDataReader dr, string columnName, short defaultValue)
        {
            return GetShortOrDefault(dr, dr.GetOrdinal(columnName), defaultValue);
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of short. 
        /// If value is DbNull returns default value
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static short GetShortOrDefault(this DbDataReader dr, string columnName)
        {
            return GetShortOrDefault(dr, dr.GetOrdinal(columnName));
        }

        #endregion

        #region GetByte

        /// <summary>
        /// Gets the value of the specified column as an instance of byte (tinyint). 
        /// If value is DbNull returns the default value.
        /// </summary>
        public static short GetByteOrDefault(this DbDataReader dr, int i, byte defaultValue)
        {
            if (dr.IsDBNull(i))
                return defaultValue;
            return dr.GetByte(i);
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of byte (tinyint). 
        /// If value is DbNull returns the default value.
        /// </summary>
        public static short GetByteOrDefault(this DbDataReader dr, int i)
        {
            return GetByteOrDefault(dr, i, default(byte));
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of byte (tinyint). 
        /// If value is DbNull returns the default value.
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static short GetByteOrDefault(this DbDataReader dr, string columnName, byte defaultValue)
        {
            return GetByteOrDefault(dr, dr.GetOrdinal(columnName), defaultValue);
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of byte (tinyint). 
        /// If value is DbNull returns default value
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static short GetByteOrDefault(this DbDataReader dr, string columnName)
        {
            return GetByteOrDefault(dr, dr.GetOrdinal(columnName));
        }

        #endregion

        #region GetLong

        /// <summary>
        /// Gets the value of the specified column as an instance of long. 
        /// If value is DbNull returns the default value.
        /// </summary>
        public static long GetLongOrdDefault(this DbDataReader dr, int i, long defaultValue)
        {
            if (dr.IsDBNull(i))
                return defaultValue;

            return dr.GetInt16(i);
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of long. 
        /// If value is DbNull returns the default value.
        /// </summary>
        public static long GetLongOrdDefault(this DbDataReader dr, int i)
        {
            return GetLongOrdDefault(dr, i, default(long));
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of long. 
        /// If value is DbNull returns the default value.
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static long GetLongOrdDefault(this DbDataReader dr, string columnName, long defaultValue)
        {
            return GetLongOrdDefault(dr, dr.GetOrdinal(columnName), defaultValue);
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of long. 
        /// If value is DbNull returns the default value.
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static long GetLongOrdDefault(this DbDataReader dr, string columnName)
        {
            return GetLongOrdDefault(dr, dr.GetOrdinal(columnName));
        }

        #endregion

        #region GetDecimal 

        /// <summary>
        /// Gets the value of the specified column as an instance of decimal. 
        /// If value is DbNull returns the default value.
        /// </summary>
        public static decimal GetDecimalOrDefault(this DbDataReader dr, int i, decimal defaultValue)
        {
            if (dr.IsDBNull(i))
                return defaultValue;
            return dr.GetDecimal(i);
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of decimal. 
        /// If value is DbNull returns the default value.
        /// </summary>
        public static decimal GetDecimalOrDefault(this DbDataReader dr, int i)
        {
            return GetDecimalOrDefault(dr, i, default(decimal));
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of decimal. 
        /// If value is DbNull returns the default value.
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static decimal GetDecimalOrDefault(this DbDataReader dr, string columnName, decimal defaultValue)
        {
            return GetDecimalOrDefault(dr, dr.GetOrdinal(columnName), defaultValue);
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of decimal. 
        /// If value is DbNull returns the default value.
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static decimal GetDecimalOrDefault(this DbDataReader dr, string columnName)
        {
            return GetDecimalOrDefault(dr, dr.GetOrdinal(columnName));
        }

        #endregion

        #region GetDouble

        /// <summary>
        /// Gets the value of the specified column as an instance of double. 
        /// If value is DbNull returns the default value.
        /// </summary>
        public static double GetDoubleOrDefault(this DbDataReader dr, int i, double defaultValue)
        {
            if (dr.IsDBNull(i))
                return defaultValue;
            return dr.GetDouble(i);
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of double. 
        /// If value is DbNull returns the default value.
        /// </summary>
        public static double GetDoubleOrDefault(this DbDataReader dr, int i)
        {
            return GetDoubleOrDefault(dr, i, default(double));
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of double. 
        /// If value is DbNull returns the default value.
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static double GetDoubleOrDefault(this DbDataReader dr, string columnName, double defaultValue)
        {
            return GetDoubleOrDefault(dr, dr.GetOrdinal(columnName), defaultValue);
        }

        /// <summary>
        /// Gets the value of the specified column as an instance of double. 
        /// If value is DbNull returns the default value.
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static double GetDoubleOrDefault(this DbDataReader dr, string columnName)
        {
            return GetDoubleOrDefault(dr, dr.GetOrdinal(columnName));
        }

        #endregion

        #region GetDateTime

        /// <summary>
        /// Gets the value of the specified column as an instance of DateTime. 
        /// If value is DbNull returns the default value.
        /// </summary>
        public static DateTime GetDateTimeOrDefault(this DbDataReader dr, int i, DateTime defaultValue)
        {
            if (dr.IsDBNull(i))
                return defaultValue;
            return dr.GetDateTime(i);
        }
        /// <summary>
        /// Gets the value of the specified column as an instance of DateTime. 
        /// If value is DbNull returns the default value.
        /// </summary>
        public static DateTime GetDateTimeOrDefault(this DbDataReader dr, int i)
        {
            return GetDateTimeOrDefault(dr, i, default(DateTime));
        }
        /// <summary>
        /// Gets the value of the specified column as an instance of DateTime. 
        /// If value is DbNull returns the default value.
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static DateTime GetDateTimeOrDefault(this DbDataReader dr, string columnName, DateTime defaultValue)
        {
            return GetDateTimeOrDefault(dr, dr.GetOrdinal(columnName), defaultValue);
        }
        /// <summary>
        /// Gets the value of the specified column as an instance of DateTime. 
        /// If value is DbNull returns the default value.
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static DateTime GetDateTimeOrDefault(this DbDataReader dr, string columnName)
        {
            return GetDateTimeOrDefault(dr, dr.GetOrdinal(columnName));
        }

        #endregion

        #region IsDbNull
        /// <summary>
        /// Returns true if the column contains nonexistent or missing values 
        /// <remarks>Column must exist</remarks>
        /// </summary>
        public static bool IsDbNull(this DbDataReader dr, string columnName)
        {
            return dr.IsDBNull(dr.GetOrdinal(columnName));
        }

        #endregion
    }
}