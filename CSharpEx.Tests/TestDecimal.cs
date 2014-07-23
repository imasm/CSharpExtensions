using NUnit.Framework;

namespace CSharpEx.Tests
{
    [TestFixture]
    public class TestDecimal
    {
        [TestCase(0.80, .25, Result=0.75)]
        [TestCase(0.80, .05, Result = 0.80)]
        [TestCase(0.255, .25, Result = 0.25)]
        public decimal TestMRound(decimal value, decimal divisor)
        {
            return value.MRound(divisor);
        }

        [TestCase(1.5, Result = 2)]
        [TestCase(2.5, Result = 3)]
        [TestCase(3.5, Result = 4)]
        public decimal TestRoundAwayFromZero(decimal value)
        {
            return value.RoundAwayFromZero();
        }

        [TestCase(1.5, Result = 2)]
        [TestCase(2.5, Result = 2)]
        [TestCase(3.5, Result = 4)]
        public decimal TestRoundToEven(decimal value)
        {
            return value.RoundToEven();
        }
    }
}
