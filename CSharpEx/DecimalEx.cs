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
