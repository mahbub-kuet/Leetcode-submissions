/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} head
 * @return {ListNode}
 */

// https://leetcode.com/problems/reverse-linked-list/

var reverseList = function(head) {
    //var lastNode = new ListNode(head.val);
    //head = head.next;
    var rev = [];
    while(head !== null){
        //let node = new ListNode(head.val);
        //node.next = lastNode;
        //lastNode = node;
        rev.unshift(head.val);
        head = head.next;
    }
    //console.log(lastNode);
    return rev;
};