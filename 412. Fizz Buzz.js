/**
 * @param {number} n
 * @return {string[]}
 */

 // https://leetcode.com/problems/fizz-buzz/
 
var fizzBuzz = function(n) {
    var fizzbuzz = [];
    for (let i=1;i<=n;i++){
        if(i%15===0){
            fizzbuzz.push('FizzBuzz');
        }else if(i%5===0){
            fizzbuzz.push('Buzz');
        }else if(i%3===0){
            fizzbuzz.push('Fizz');
        }else{
            fizzbuzz.push(''+i);
        }
    }
    
    return fizzbuzz;
};