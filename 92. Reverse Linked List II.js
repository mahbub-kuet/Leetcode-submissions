/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} head
 * @param {number} m
 * @param {number} n
 * @return {ListNode}
 */

// https://leetcode.com/problems/reverse-linked-list-ii/ 

var reverseBetween = function(head, m, n) {
    var before = [], middle = [], after= [],i=1;;    
    while(head!=null){
        if(i<m)
            before.push(head.val);
        else if(i>=m && i<=n)
            middle.unshift(head.val);
        else
            after.push(head.val);
        
        head = head.next; 
        i++;
    }
    return before.concat(middle).concat(after);   
};