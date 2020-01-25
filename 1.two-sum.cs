/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int difference = 0;

        Dictionary<int, int> numberDictionary = new Dictionary<int, int>();

        foreach(int num in nums) {
            int index = Array.IndexOf<int>(nums, num);

            // numberDictionary.Add(index, num);

            Console.WriteLine(index);
        }

        for(int i = 0; i < nums.Count(); i++) {
            difference = target - nums[i];

            if(numberDictionary.ContainsValue(nums[i]) && numberDictionary[nums[i]] != i) {
                return new Array[i, Array.IndexOf(nums, numberDictionary[nums[i]])];
            }
        }
    }
}
// @lc code=end

