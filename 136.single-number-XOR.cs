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
        int single = nums[0];
        for(var i =1; i < nums.Count(); i++) {
            single = single ^ nums[i];
        }

        return single;
    }
}
// @lc code=end

