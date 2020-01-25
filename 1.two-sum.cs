/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution
{
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
}
// @lc code=end

