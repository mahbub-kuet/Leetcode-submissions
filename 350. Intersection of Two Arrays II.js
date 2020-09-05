/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number[]}
 */

 // https://leetcode.com/problems/intersection-of-two-arrays-ii/
 
var intersect = function(nums1, nums2) {
    var result=[],temp=[];
    if( nums1.length === 0 || nums2.length ===0)
	    return result;
	
	nums1.forEach(x=>{
		var foundIndex = nums2.indexOf(x);
			if(  foundIndex !== -1 ){
				result.push(x);
				nums2.splice(foundIndex,1);	
			}
	});
	return result;
};