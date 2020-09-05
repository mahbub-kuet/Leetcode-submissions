/**
 * @param {number[]} nums
 * @return {number}
 */

 // https://leetcode.com/problems/missing-number/
 
var missingNumber = function(nums) {
    var sum = (nums.length*(nums.length+1))/2;
    //console.log(sum);
    nums.forEach((i)=>{
        sum = sum-i;
    });
    
    return sum;    
};