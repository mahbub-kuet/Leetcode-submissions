/**
 * @param {number} n
 * @return {number}
 */

 // https://leetcode.com/problems/factorial-trailing-zeroes/
 
var trailingZeroes = function(n) {    
    return n < 5 ? 0 : (parseInt(n/5) + trailingZeroes(n/5));
};