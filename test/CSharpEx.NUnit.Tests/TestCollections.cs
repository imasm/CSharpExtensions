#region LICENSE

//    Copyright 2014 Ivan Masmità
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//        http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

#endregion

using NUnit.Framework;
using System.Collections.Generic;


namespace CSharpEx.Tests
{ 
    [TestFixture]
    public class TestCollections
    {
        private readonly List<int> _nullList = null;
        private readonly List<int> _emptyList = new List<int>();
        private readonly List<int> _list = new List<int> {1, 2, 3};

        [Test]
        public void TestIsNullOrEmptyList()
        {
            Assert.True(_nullList.IsNullOrEmpty());
            Assert.True(_emptyList.IsNullOrEmpty());
            Assert.False(_list.IsNullOrEmpty());
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