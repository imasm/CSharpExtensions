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

        [Test]
        public void TestTruncateDateTime()
        {
            var d1 = new DateTime(2014, 01, 1, 12, 52, 25, 180);
            var dSecond = new DateTime(2014, 01, 1, 12, 52, 25);
            var dMinute = new DateTime(2014, 01, 1, 12, 52, 00);
            var dHour = new DateTime(2014, 01, 1, 12, 00, 00);
            var dQuarters = new DateTime(2014, 01, 1, 12, 45, 00, 00);

            Assert.AreEqual(dSecond, d1.TruncateToSecond()); // 12:52:25.180 -> 12:02:25
            Assert.AreEqual(dMinute, d1.TruncateToMinute()); // 12:52:25.180 -> 12:02:00
            Assert.AreEqual(dHour, d1.TruncateToHours()); // 12:52:25.180 -> 12:0
            Assert.AreEqual(dQuarters, d1.TruncateTo(TimeSpan.FromMinutes(15))); //12:52:25.180 -> 12:45:00
        }

        [Test]
        public void TestRoundDateTime()
        {
            var d1 = new DateTime(2014, 01, 1, 12, 02, 25);
            var dMinuteLow = new DateTime(2014, 01, 1, 12, 02, 00);
            var d2 = new DateTime(2014, 01, 1, 12, 02, 35);
            var dMinuteUp = new DateTime(2014, 01, 1, 12, 03, 00);

            var d3 = new DateTime(2014, 01, 1, 12, 02, 35, 20);
            var dSecond = new DateTime(2014, 01, 1, 12, 02, 35, 00);


            var d4 = new DateTime(2014, 01, 1, 12, 46, 35, 20);
            var dHour = new DateTime(2014, 01, 1, 13, 00, 00);
            var dQuarters = new DateTime(2014, 01, 1, 12, 45, 00,00);

            Assert.AreEqual(dMinuteLow, d1.RoundToMinute()); // 12:02.25 -> 12:02
            Assert.AreEqual(dMinuteUp, d2.RoundToMinute()); //12:02.35 -> 12:03
            Assert.AreEqual(dSecond, d3.RoundToSecond()); //12:02.35.20 -> 12:02:35

            Assert.AreEqual(dHour, d4.RoundToHours()); // 12:46:35.20 -> 13:00
            Assert.AreEqual(dQuarters, d4.RoundTo(TimeSpan.FromMinutes(15))); //12:46:35.20 -> 12:45
        }
    }
}
