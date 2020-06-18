/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
public class Solution
{
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
            ["M"] = 1000
        };

        int total = 0;

        for (int i = 0; i < numArr.Length; i++)
        {
            var num = Convert.ToString(numArr[i]);
            var next = i == numArr.Length - 1 ? numArr[i] : numArr[i + 1];

            if (numerals[num] < numerals[Convert.ToString(next)])
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
// @lc code=end

