using System.Collections.Generic;
using NUnit.Framework;

namespace CSharpEx.Tests
{
    [TestFixture]
    public class TestCollections
    {

        [Test]
        public void TestIsNullOrEmptyList()
        {
            List<int> nullList = null;
            List<int> emptyList = new List<int>();
            List<int> list = new List<int> {1, 2, 3};
            
            Assert.IsTrue(nullList.IsNullOrEmpty());
            Assert.IsTrue(emptyList.IsNullOrEmpty());
            Assert.IsFalse(list.IsNullOrEmpty());
        }
    }
}
