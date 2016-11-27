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
    /// Double extensions
    /// </summary>
    public static class DoubleEx
    {
        /// <summary>
        /// Compare two double values. Returns true if the diference is lower than tolerance
        /// </summary>
        /// <param name="value1">First double value</param>
        /// <param name="value2">Second double value</param>
        /// <param name="tolerance">Tolerance permitted</param>
        /// <returns>True if values are closer.</returns>
        public static bool AreEqual(this double value1, double value2, double tolerance = double.Epsilon)
        {
            return (Math.Abs(value1 - value2) < tolerance);
        }

        /// <summary>
        /// Compare two double values.
        /// Uses the BitConverter.DoubleToInt64Bits method to convert a double-precision floating-point value to its integer representation.
        /// </summary>
        /// <param name="value1">First double value</param>
        /// <param name="value2">Second double value</param>
        /// <param name="units">Units used as tolerance</param>
        /// <returns>True if values are closer.</returns>
        public static bool HasMinimalDifference(this double value1, double value2, int units = 1)
        {
            long lValue1 = BitConverter.DoubleToInt64Bits(value1);
            long lValue2 = BitConverter.DoubleToInt64Bits(value2);

            // If the signs are different, return false except for +0 and -0.
            if ((lValue1 >> 63) != (lValue2 >> 63))
            {
                if (value1 == value2)
                    return true;

                return false;
            }

            long diff = Math.Abs(lValue1 - lValue2);

            if (diff <= (long) units)
                return true;

            return false;
        }

        /// <summary>
        /// Returns a number rounded to the desired multiple
        /// </summary>
        public static double MRound(this double value, double divisor)
        {
            return Math.Truncate(value / divisor) * divisor;
        }

        /// <summary>
        /// Rounds a double value to the nearest integer. 
        /// When a number is halfway between two others, it is rounded toward the nearest number that is away from zero.
        /// </summary>
        public static double RoundAwayFromZero(this double value)
        {
            return Math.Round(value, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// Rounds a double value to the nearest integer. 
        /// When a number is halfway between two others, it is rounded toward the nearest number that is away from zero.
        /// </summary>
        public static double RoundAwayFromZero(this double value, int doubles)
        {
            return Math.Round(value, doubles, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// Rounds a double value to the nearest integer. 
        /// When a number is halfway between two others, it is rounded toward the nearest even number.
        /// </summary>
        public static double RoundToEven(this double value)
        {
            return Math.Round(value, MidpointRounding.ToEven);
        }

        /// <summary>
        /// Rounds a double value to the nearest integer. 
        /// When a number is halfway between two others, it is rounded toward the nearest even number.
        /// </summary>
        public static double RoundToEven(this double value, int doubles)
        {
            return Math.Round(value, doubles, MidpointRounding.ToEven);
        }
    }
}