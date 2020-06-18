/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
public class Solution
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
}
// @lc code=end

