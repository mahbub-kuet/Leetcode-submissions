/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} node
 * @return {void} Do not return anything, modify node in-place instead.
 */

 // https://leetcode.com/problems/delete-node-in-a-linked-list/
 
var deleteNode = function(node) {
    if(node.next === null)
        return;
    
    node.val = node.next.val;
    node.next = node.next.next;
    
};