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

namespace CSharpEx.Tests
{
    [TestFixture]
    public class TestDecimal
    {
        [TestCase(0.80, .25, Result = 0.75)]
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