using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeMethods
{
    public class LeetCode : ILeetCode
    {        
        static void Main() 
        {
        }
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

        public int SingleNumberGroupBy(int[] nums)
        {
            var numLookup = nums.GroupBy(num => num);
            return numLookup.Where(group => group.Count() == 1).First().Key;
        }

        public int SingleNumberXOR(int[] nums)
        {
            int single = nums[0];
            for (var i = 1; i < nums.Count(); i++)
            {
                single = single ^ nums[i];
            }

            return single;
        }

        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numberDictionary = new Dictionary<int, int>(nums.Count());

            for (int i = 0; i < nums.Length; i++)
            {
                if (numberDictionary.ContainsValue(target - nums[i]))
                {
                    int dictionaryKey = numberDictionary.FirstOrDefault(key => key.Value == target - nums[i]).Key;

                    if (dictionaryKey != i)
                    {
                        int[] twoSum = { dictionaryKey, i };

                        return twoSum;
                    }
                }

                numberDictionary.Add(i, nums[i]);
            }

            return null;
        }

        public int ReverseInteger(int x)
        {
            int[] digits = x.ToString().Select(i => Convert.ToInt32(i)).ToArray();
            int[] tempDigits = digits;

            //digits.Reverse(tempDigits);

            return 0;
        }

        public bool IsPalindrome(int x)
        {
            if (x < 0) return false;

            char[] numArr = x.ToString().Select(num => num).ToArray();

            numArr.Reverse();
            string y = string.Join(",", numArr);

            return x == int.Parse(y);
        }

        public bool IsHappy(int n)
        {
            if (n == 1)
            {
                return true;
            }

            string sumString = Convert.ToString(n);
            char[] sumArray = sumString.ToCharArray();
            int total = 0;

            while (total != 1)
            {
                for (var i = 0; i < sumArray.Length; i++)
                {
                    var num = int.Parse(sumArray[i].ToString());
                    total += (int)Math.Pow(num, 2);
                }

                if (total == 89) return false;

                sumArray = Convert.ToString(total).ToCharArray();

                if (total != 1)
                {
                    total = 0;
                }
            }

            return true;
        }
    }
}
