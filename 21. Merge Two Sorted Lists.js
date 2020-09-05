/**
 * Definition for singly-linked list.
 * function ListNode(val) {
 *     this.val = val;
 *     this.next = null;
 * }
 */
/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */

 // https://leetcode.com/problems/merge-two-sorted-lists/
 
var mergeTwoLists = function(l1, l2) {
    var res = [];
    while(l1 !== null || l2 !== null){
        if(l1 !== null && l2 !== null && l1.val === l2.val){
            res.push(l1.val);
            l1 = l1.next;
            res.push(l2.val);
            l2 = l2.next;
        }
        else if(l1 !== null && l2 !== null && l1.val < l2.val){
             res.push(l1.val);
            l1 = l1.next;
        }
        else if(l1 !== null && l2 !== null && l1.val > l2.val){
             res.push(l2.val);
             l2 = l2.next;
        }
        else if(l1 !== null){
            res.push(l1.val);
            l1 = l1.next;
        }
        else if(l2 !== null){
             res.push(l2.val);
             l2 = l2.next;   
        }
        
       
    }
     return res;
    
};