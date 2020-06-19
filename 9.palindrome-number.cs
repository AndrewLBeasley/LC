/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution
{
    public bool IsPalindrome(int x)
    {

        if (x < 0) return false;

        char[] numArr = x.ToString().Select(num => num).ToArray();

        numArr.Reverse();
        string y = string.Join(",", numArr);

        return x == int.Parse(y);
    }
}
// @lc code=end

