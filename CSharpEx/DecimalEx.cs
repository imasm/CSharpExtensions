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
            
    }
}
