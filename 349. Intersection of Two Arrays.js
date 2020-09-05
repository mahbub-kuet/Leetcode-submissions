/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number[]}
 */

 // https://leetcode.com/problems/intersection-of-two-arrays/
 
var intersection = function(nums1, nums2) {
    if ( nums1.length === 0 || nums2.length === 0)
       return [];
       
    var group1={},group2={},result=[];
    nums1.forEach(x=>{
        group1[x] = group1[x] ||1;
    });
     nums2.forEach(x=>{
        group2[x] = group2[x] ||1;
    });
    
    Object.keys(group1).forEach(x=> {
        if(group2[x])
            result.push(parseInt(x));
    });
    
    return result;
};