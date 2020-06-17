/*
 * @lc app=leetcode id=3 lang=javascript
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
/**
 * @param {string} s
 * @return {number}
 */
var lengthOfLongestSubstring = function (s) {
    if (!s || typeof (s) !== "string") return 0;
    if (s.length === 1) return 1;

    const stringArr = s.split("");

    let hash = {};
    let start = 0;
    let longestSubString = 0;

    for (let i = 0; i < stringArr.length; i++) {
        hash[stringArr[i]] != null && start <= hash[stringArr[i]] ? start = hash[stringArr[i]] + 1
            : longestSubString = Math.max(longestSubString, (i - start + 1));

        hash[stringArr[i]] = i;
    }

    return longestSubString;
};
// @lc code=end

