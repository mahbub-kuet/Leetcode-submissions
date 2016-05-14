/**
 * @param {number} num
 * @return {boolean}
 */
var isPowerOfFour = function(num) {
    return  num<0? false : (Boolean)(!(num&num-1)&&((num-1)%3===0));
};