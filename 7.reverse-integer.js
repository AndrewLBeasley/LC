

/*
 * @lc app=leetcode id=7 lang=javascript
 *
 * [7] Reverse Integer
 */

// @lc code=start
/**
 * @param {number} x
 * @return {number}
 */
var reverse = function (x) {
    const sign = Math.sign(x);

    x = parseInt(x.toString().split("").map(i => parseInt(i)).reverse().join(""));
    x = Math.abs(x) * sign;

    if (x > (Math.pow(2, 31) - 1) || x < -(Math.pow(2, 31))){
        return 0;
    }

    return x;
};
// @lc code=end

