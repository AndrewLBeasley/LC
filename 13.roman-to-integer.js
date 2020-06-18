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
        
    return numArr.reduce((acc, num, i, arr) =>( numerals[num] < numerals[arr[i + 1]] ? acc += numerals[num] * -1 : acc += numerals[num]), 0)    
};
// @lc code=end

