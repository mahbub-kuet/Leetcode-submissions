/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number}
 */

 // https://leetcode.com/problems/maximum-depth-of-binary-tree/
 
var maxDepth = function(root) {
    if(root === null){
         return 0;
     }
     var ldepth= maxDepth(root.left);
     var rdepth= maxDepth(root.right);
     
     if(ldepth > rdepth){
         return ldepth +1;
     }else{
         return rdepth +1;
     }
 };