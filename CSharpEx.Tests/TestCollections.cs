using System.Collections.Generic;
using NUnit.Framework;

namespace CSharpEx.Tests
{
    [TestFixture]
    public class TestCollections
    {
        readonly List<int> _nullList = null;
        readonly List<int> _emptyList = new List<int>();
        readonly List<int> _list = new List<int> { 1, 2, 3 };

        [Test]
        public void TestIsNullOrEmptyList()
        {
            Assert.IsTrue(_nullList.IsNullOrEmpty());
            Assert.IsTrue(_emptyList.IsNullOrEmpty());
            Assert.IsFalse(_list.IsNullOrEmpty());
        }

        [Test]
        public void TestFirstIndex()
        {
            Assert.AreEqual(-1, _nullList.FirstIndex(x => x == 3));
            Assert.AreEqual(-1, _emptyList.FirstIndex(x => x == 3));
            Assert.AreEqual(0, _list.FirstIndex(x => x == 1));
            Assert.AreEqual(1, _list.FirstIndex(x => x == 2));
            Assert.AreEqual(2, _list.FirstIndex(x => x == 3));
            Assert.AreEqual(-1, _list.FirstIndex(x => x == 4));
        }
    }
}
