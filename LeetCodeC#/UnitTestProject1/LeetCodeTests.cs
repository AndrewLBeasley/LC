using LeetCodeMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeTests
{
    [TestClass]
    public class LeetCodeTests
    {
        private ILeetCode _leetCode;

        [TestInitialize]
        public void Initialize()
        {
            _leetCode = new LeetCode();
        }


        [TestMethod]
        public void TestLengthOfLongestSubstring()
        {
            int results = _leetCode.LengthOfLongestSubstring("abcabcbb");
            Assert.IsNotNull(results);
            Assert.Equals(results, 3);
        }



        [TestMethod]
        public void TestRomanToInt()
        {
            int results = _leetCode.RomanToInt("III");
            Assert.IsNotNull(results);
            Assert.Equals(results, 3);
        }

    }
}
