/*
 * @lc app=leetcode id=7 lang=csharp
 *
 * [7] Reverse Integer
 */

// @lc code=start
public class Solution
{
    public int Reverse(int x)
    {
        int[] digits = x.ToString().Select(i => Convert.ToInt32(i)).ToArray();
        int[] tempDigits = digits;
        
        digits.Reverse(tempDigits);

        return digits;
    }
}
// @lc code=end

