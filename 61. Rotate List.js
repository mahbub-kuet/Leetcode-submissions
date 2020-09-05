/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} head
 * @param {number} k
 * @return {ListNode}
 */

// https://leetcode.com/problems/rotate-list/

var rotateRight = function(head, k) {
    if(head == null) 
        return [];
    var res = [];
    while(head !=null){
        res.push(head.val);
        head = head.next;
    }
    k = k%res.length;
    for(let i=0;i<k;i++){
        let e= res.pop();
        res.unshift(e);
    }
    
    return res;
    
};