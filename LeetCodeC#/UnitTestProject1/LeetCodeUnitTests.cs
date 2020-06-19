using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;


namespace UnitTestProject1
{
    //private ILeetCode _leetCode; 

    [TestClass]
    public class LeetCodeUnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 10;
            var y = x.ToString();

            var list = y.Split(",");

            list.Reverse();
            y = string.Join(",", list);
            
            var matches = x == int.Parse(y);            
        }
    

        [TestMethod]
        public void TestMethod2()
        {

            //var results = LengthOfLongestSubstring("abcabcbb");
            //Assert.IsNotNull(results);
        }

       

        [TestMethod]
        public void TestMethod3()
        {
            //var results = RomanToInt("III");
            //Assert.IsNotNull(results);
        }

    }
}
