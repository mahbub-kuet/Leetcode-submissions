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

 // https://leetcode.com/problems/add-two-numbers-ii/
 
var addTwoNumbers = function(l1, l2) {
    var arr1=[],arr2=[], res= [];
    
    while( l1!==null || l2!==null){        
        if(l1 !== null){
            arr1.push(l1.val);
            l1=l1.next;
        }
        else
            arr1.unshift(0);
            
        if(l2 !== null){
            arr2.push(l2.val);
            l2 = l2.next;
        }
        else
            arr2.unshift(0);
    }    
    
    var carry = 0;
    for(let i=arr1.length-1;i>=0;i--){   
         res[i] = (arr1[i]+arr2[i]+carry)%10;
         carry =parseInt((arr1[i]+arr2[i]+carry)/10);            
    }
    
    if(carry === 1)
        res.unshift(carry);
    
    return res;      
    
};