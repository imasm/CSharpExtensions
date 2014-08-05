using System;
using NUnit.Framework;

namespace CSharpEx.Tests
{
    [TestFixture]
    public class TestStrings
    {
        #region SplitAndTrim
        [Test]
        public void TestSplitAndTrim()
        {
            const string sample = "0 , 1 ,    2 , 3 ,4 ";
            var array = sample.SplitAndTrim(new char[] {','});
            Assert.AreEqual(5, array.Length);
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual( i.ToString(), array[i]);
            }
        }

        [Test]
        public void TestSplitAndTrimWithEmpty()
        {
            const string sample = "0 , 1 ,  ,  2 ,, 3 ,4 ";
            var array = sample.SplitAndTrim(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(5, array.Length);
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(i.ToString(), array[i]);
            }
        }

        [Test]
        public void TestSplitAndTrimWithEmptyInMiddle()
        {
            const string sample = "0 , 1 ,  ,  2 A,, 3 ,4 ";
            var array = sample.SplitAndTrim(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(5, array.Length);
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    Assert.AreEqual("2 A", array[i]);
                } else
                    Assert.AreEqual(i.ToString(), array[i]);
            }
        }
        #endregion

        #region Conversions

        [Test]
        public void TestInt()
        {
            Assert.AreEqual(5, "5".ParseToInt());
            Assert.AreEqual(5, "5".ParseToIntOrDefault());
            Assert.AreEqual(0, "A".ParseToIntOrDefault());
            Assert.AreEqual(-1, "A".ParseToIntOrDefault(-1));
            Assert.AreEqual(0, "".ParseToIntOrDefault());
            Assert.AreEqual(0, ((string)null).ParseToIntOrDefault(0));
        }

        [Test]
        public void TestShort()
        {
            Assert.AreEqual(5, '5'.ParseToShort());
            Assert.AreEqual(5, '5'.ParseToShortOrDefault());
            Assert.AreEqual(0, 'A'.ParseToShortOrDefault());
            Assert.AreEqual(-1,'A'.ParseToShortOrDefault(-1));
        }

        [Test]
        public void TestLong()
        {
            Assert.AreEqual(5, "5".ParseToLong());
            Assert.AreEqual(1234567890123, "1234567890123".ParseToLongOrDefault());
            Assert.AreEqual(0, "A".ParseToLongOrDefault());
            Assert.AreEqual(-1, "Asdfsdfsd".ParseToLongOrDefault(-1));
            Assert.AreEqual(0, "".ParseToLongOrDefault());
            Assert.AreEqual(0, ((string)null).ParseToLongOrDefault(0));
        }

        [Test]
        public void TestDouble()
        {
            Assert.AreEqual(5, "5".ParseToDouble());
            Assert.AreEqual(5, "5.5".ParseToDouble());
            Assert.AreEqual(1234567890123, "1234567890123".ParseToDoubleOrDefault());
            Assert.AreEqual(0, "A".ParseToDoubleOrDefault());
            Assert.AreEqual(-1, "Asdfsdfsd".ParseToDoubleOrDefault(-1));
            Assert.AreEqual(0, "".ParseToDoubleOrDefault());
            Assert.AreEqual(0, ((string)null).ParseToDoubleOrDefault(0));
        }

        [Test]
        public void TestDecimal()
        {
            Assert.AreEqual(5, "5".ParseToLong());
            Assert.AreEqual(1234567890123, "1234567890123".ParseToLongOrDefault());
            Assert.AreEqual(0, "A".ParseToLongOrDefault());
            Assert.AreEqual(-1, "Asdfsdfsd".ParseToLongOrDefault(-1));
            Assert.AreEqual(0, "".ParseToLongOrDefault());
            Assert.AreEqual(0, ((string)null).ParseToLongOrDefault(0));
        }
        #endregion


    }
}
