/**
 * @param {string} s
 * @return {string}
 */
var reverseVowels = function(s) {
   var letters= s.split('');
    var vowels= 'aeiouAEIOU', left=0,right=letters.length-1;
    while(left< right){
        if( vowels.includes(letters[left]) === true){
            while(true){
                 if( vowels.includes(letters[right]) === true){
                      // swap
				 var temp= letters[left];
				 letters[left]= letters[right];
				 letters[right]= temp;
				 right--;
				 break;
				 }else{
					 right--;
				 }
            }
        } 
        left++;
    }
    return letters.join('');
};