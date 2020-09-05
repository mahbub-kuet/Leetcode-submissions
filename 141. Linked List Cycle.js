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

 // https://leetcode.com/problems/linked-list-cycle/
 
var hasCycle = function(head) {
    if(head == null || head.next == null)
        return false;
    var slow = head, fast = head.next;
    
    while(fast !==null && fast.next !==null){
        if(slow == fast)
            return true;
        
        slow = slow.next;
        fast = fast.next.next;        
    }
    
    return false;    
    
};