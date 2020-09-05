/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} head
 * @param {number} val
 * @return {ListNode}
 */

 // https://leetcode.com/problems/remove-linked-list-elements/
 
var removeElements = function(head, val) {
    var res = [];
    while(head !== null){     
        if(head.val !== val)
            res.push(head.val);
        
        head = head.next;
    }
    
    return res;    
};