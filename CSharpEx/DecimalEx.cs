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
    /// Decimal extensions
    /// </summary>
    public static class DecimalEx
    {
        /// <summary>
        /// Returns a number rounded to the desired multiple
        /// </summary>
        public static decimal MRound(this decimal value, decimal divisor)
        {
            return Math.Truncate(value / divisor) * divisor;
        }

        /// <summary>
        /// Rounds a decimal value to the nearest integer. 
        /// When a number is halfway between two others, it is rounded toward the nearest number that is away from zero.
        /// </summary>
        public static decimal RoundAwayFromZero(this decimal value)
        {
            return Math.Round(value, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// Rounds a decimal value to the nearest integer. 
        /// When a number is halfway between two others, it is rounded toward the nearest number that is away from zero.
        /// </summary>
        public static decimal RoundAwayFromZero(this decimal value, int decimals)
        {
            return Math.Round(value, decimals, MidpointRounding.AwayFromZero);
        }

        /// <summary>
        /// Rounds a decimal value to the nearest integer. 
        /// When a number is halfway between two others, it is rounded toward the nearest even number.
        /// </summary>
        public static decimal RoundToEven(this decimal value)
        {
            return Math.Round(value, MidpointRounding.ToEven);
        }

        /// <summary>
        /// Rounds a decimal value to the nearest integer. 
        /// When a number is halfway between two others, it is rounded toward the nearest even number.
        /// </summary>
        public static decimal RoundToEven(this decimal value, int decimals)
        {
            return Math.Round(value, decimals, MidpointRounding.ToEven);
        }
    }
}