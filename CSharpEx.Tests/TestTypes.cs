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

using System;
using NUnit.Framework;

namespace CSharpEx.Tests
{
    [TestFixture]
    public class TestTypes
    {
        [Test]
        public void TestNullable()
        {
            Assert.IsTrue(typeof (Nullable<int>).IsNullable());
            Assert.IsTrue(typeof (int?).IsNullable());
            Assert.IsFalse(typeof (object).IsNullable());
            Assert.IsFalse(typeof (string).IsNullable());
        }
    }
}