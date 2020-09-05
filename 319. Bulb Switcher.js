/**
 * @param {number} n
 * @return {number}
 */

 // https://leetcode.com/problems/bulb-switcher/
 
var bulbSwitch = function(n) {
    var i=0;
    while(i*i<=n){
        i++;
    }
    return i-1;
};