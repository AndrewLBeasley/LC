/*
 * @lc app=leetcode id=136 lang=csharp
 *
 * [136] Single Number
 */

// @lc code=start
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        var numLookup = nums.GroupBy(num => num);
        return numLookup.Where(group => group.Count() == 1).First().Key;
    }
}
// @lc code=end

