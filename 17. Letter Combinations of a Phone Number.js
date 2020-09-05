/**
 * @param {string} digits
 * @return {string[]}
 */
// https://leetcode.com/problems/letter-combinations-of-a-phone-number/

var letterCombinations = function(digits) {
    var mappings = [
        [],//0
        ['*'],//1
        ['a', 'b', 'c'],
        ['d', 'e', 'f'],
        ['g', 'h', 'i'],
        ['j', 'k', 'l'],
        ['m', 'n', 'o'],
        ['p', 'q', 'r', 's'],
        ['t', 'u', 'v'],
        ['w', 'x', 'y', 'z']
    ];

    if(digits.length === 0 || digits.includes("0"))
        return [];
    if(digits.length === 1)
        return mappings[parseInt(digits)];  
		
    var ret=[];	
	digits = digits.split('');

	for(let i=0;i<digits.length -1; i++){
		var set1=ret.length === 0 ? mappings[parseInt(digits[i])] : ret;
		var set2=mappings[parseInt(digits[i+1])];
		ret = [];
    
		set1.forEach(function(l1){
			set2.forEach(function(l2){
				ret.push(l1+l2);
			});
		});
	}	
    
    return ret;
};