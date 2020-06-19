using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeMethods
{
    public interface ILeetCode
    {
        public int LengthOfLongestSubstring(string s);
        public int RomanToInt(string s);
        public bool IsHappy(int n);
        public bool IsPalindrome(int x);
        public int SingleNumberXOR(int[] nums);
    }
}
