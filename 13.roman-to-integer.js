/*
 * @lc app=leetcode id=13 lang=javascript
 *
 * [13] Roman to Integer
 */

// @lc code=start
/**
 * @param {string} s
 * @return {number}
 */
var romanToInt = function (s) {
    const numArr = s.split("");

    const numerals = {
        I: 1,
        V: 5,
        X: 10,
        L: 50,
        C: 100,
        D: 500,
        M: 1000
    };
    
    let total = 0;

    numArr.forEach((num, i, arr) => numerals[num] < numerals[arr[i + 1]] ? total += numerals[num] * -1 : total += numerals[num]);
    return total;
};
// @lc code=end

