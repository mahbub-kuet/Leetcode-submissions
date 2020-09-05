/**
 * @param {number} n
 * @return {boolean}
 */

 // https://leetcode.com/problems/power-of-three/
 
var isPowerOfThree = function(n) {
    // if(n%3 !== 0) return false;
    
    var d=1;
    while(d<n)
      {
        d=d*3;
        //console.log(d);
      }
    
    
    return d===n? true:false;    
};