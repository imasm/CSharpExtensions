using System;
using NUnit.Framework;

namespace CSharpEx.Tests
{
    [TestFixture]
    public class TestDateTime
    {
        [Test]
        public void TestDayOfWeekEU()
        {
            for (int i = 0; i < 6; i++)
            {
                Assert.AreEqual(i, new DateTime(2014, 1, 6 + i).DayOfWeekEU(), "Day " + i);
            }
        }
    }
}
