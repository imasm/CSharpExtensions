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
    }
}
