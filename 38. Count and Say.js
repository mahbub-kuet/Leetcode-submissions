/**
 * @param {number} n
 * @return {string}
 */

// https://leetcode.com/problems/count-and-say/

var countAndSay = function(n) {
    if(n===1)
        return '1';
        
    var result = 1;    
    for(let i=1; i < n; i++){
        result = generateNextSay(result);
    }
    return result;
    
};

var generateNextSay = function(n){
		n=n+' ';
		var next = '';
		var sameNumberCounter = 1;
		for(let i=0;i<n.length-1;i++){
			if(n[i]=== n[i+1]){
				sameNumberCounter++;
			}else{
				next = next + sameNumberCounter + n[i];
				sameNumberCounter = 1;			
			}
		}
		return next;
};