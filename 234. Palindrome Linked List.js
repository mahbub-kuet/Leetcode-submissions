/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} head
 * @return {boolean}
 */

 // https://leetcode.com/problems/palindrome-linked-list/
 
var isPalindrome = function(head) {
    var arr = [];
    while(head !== null){
        arr.push(head.val);
        head = head.next;
    }
    
    var len = arr.length;
    for(let i=0;i<len/2;i++){
        if(arr[i] !== arr[len-1-i]){
            return false;
        }
    }
    
    return true;
};