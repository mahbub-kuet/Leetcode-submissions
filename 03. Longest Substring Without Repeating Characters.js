/**
 * @param {string} s
 * @return {number}
 */

// https://leetcode.com/problems/longest-substring-without-repeating-characters/

var lengthOfLongestSubstring = function(s) {
    if (s.length === 0) 
	return 0; 
		
    var start = 0, maxLen = 1;   
    for (var j = 0; j < s.length; j++) {
        var c = s.charAt(j);
      
	var substr= s.substring(start, j);
        var idx = substr.lastIndexOf(c);
        if (idx > -1) {
            start = start + idx + 1;
        }
      
        var currLen = j-start+1;
        if (currLen > maxLen) {
            maxLen = currLen;
        }
    }
    return maxLen;
};
