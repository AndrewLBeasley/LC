using System;
using System.Collections.Generic;
using System.Linq;

namespace test
{
    public class LeetCode
    {
        public int LengthOfLongestSubstring(string s)
        {
            var type = s.GetType();
            if (s == null || type != typeof(string))
            {
                return 0;
            }
            if (s.Length == 1)
            {
                return 1;
            }

            char[] stringlist = s.ToCharArray();
            Dictionary<char, int> charDictionary = new Dictionary<char, int>();
            int start = 0;
            int longestSubString = 0;

            for (int i = 0; i < stringlist.Length; i++)
            {
                if (charDictionary.ContainsKey(stringlist[i]) && start <= charDictionary[stringlist[i]])
                {
                    start = charDictionary[stringlist[i]] + 1;
                }
                else
                {
                    longestSubString = Math.Max(longestSubString, (i - start + 1));
                }

                charDictionary[stringlist[i]] = i;
            }

            return longestSubString;
        }

        public int RomanToInt(string s)
        {
            char[] numArr = s.ToCharArray();
            Dictionary<string, int> numerals = new Dictionary<string, int>
            {
                ["I"] = 1,
                ["V"] = 5,
                ["X"] = 10,
                ["L"] = 50,
                ["C"] = 100,
                ["D"] = 500,
                ["M"] = 100
            };

            int total = 0;

            for (int i = 0; i < numArr.Length; i++)
            {
                var num = Convert.ToString(numArr[i]);
                var next = i == numArr.Length - 1 ? numArr[i] : numArr[i + 1];

                if (numerals[num] < numerals[Convert.ToString(numArr[i + 1])])
                {
                    total += numerals[num] * -1;
                }
                else
                {
                    total += numerals[num];
                }
            }

            return total;
        }
    }
}
