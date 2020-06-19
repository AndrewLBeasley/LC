using LeetCodeMethods;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeTests
{
    [TestClass]
    public class LeetCodeTests
    {
        ILeetCode _leetCode;
        [TestInitialize]
        private void Initialize()
        {
            _leetCode = new LeetCode();
        }

        [TestMethod]
        private void TestLengthOfLongestSubstring()
        {
            int lengthOfLongestSubstring = _leetCode.LengthOfLongestSubstring("abcabcbb");

            Assert.IsNotNull(lengthOfLongestSubstring);
            Assert.Equals(lengthOfLongestSubstring, 3);
        }

        [TestMethod]
        private void TestRomanToInt()
        {
            int romanToInt = _leetCode.RomanToInt("III");

            Assert.IsNotNull(romanToInt);
            Assert.Equals(romanToInt, 3);
        }
    }
}
