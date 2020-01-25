/*
 * @lc app=leetcode id=1 lang=javascript
 *
 * [1] Two Sum
 */

// @lc code=start
/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    let difference = 0;

    for(let i = 0; i <= nums.length; i++) {
        difference = target - nums[i];

        if(nums.includes(difference) && nums.indexOf(difference) !== i) {
            return [i, nums.indexOf(difference)];
        }
    }
};
// @lc code=end

