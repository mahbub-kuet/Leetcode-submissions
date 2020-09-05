/**
 * @param {string} s
 * @return {number}
 */

 // https://leetcode.com/problems/excel-sheet-column-number/
 
var titleToNumber = function(s) {
    var result=0;
    for(let i=0;i<s.length;i++){
        result = result *26 + s.charCodeAt(i)-64;
    }
     return result;
 };