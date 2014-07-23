using NUnit.Framework;

namespace CSharpEx.Tests
{
    [TestFixture]
    public class TestDouble
    {
        [TestCase(0.80, .25, Result = 0.75)]
        [TestCase(0.80, .05, Result = 0.80)]
        [TestCase(0.255, .25, Result = 0.25)]
        public double TestMRound(double value, double divisor)
        {
            return value.MRound(divisor);
        }

        [TestCase(1.5, Result = 2)]
        [TestCase(2.5, Result = 3)]
        [TestCase(3.5, Result = 4)]
        public double TestRoundAwayFromZero(double value)
        {
            return value.RoundAwayFromZero();
        }

        [TestCase(1.5, Result = 2)]
        [TestCase(2.5, Result = 2)]
        [TestCase(3.5, Result = 4)]
        public double TestRoundToEven(double value)
        {
            return value.RoundToEven();
        }
    }
}
