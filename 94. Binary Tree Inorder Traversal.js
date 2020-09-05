/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number[]}
 */

 // https://leetcode.com/problems/binary-tree-inorder-traversal/

var nodes;
var inorderTraversal = function(root) {
    nodes=[];
    traversal(root);
    return nodes;
};

var traversal = function(root) {
    
    if(root === null){
        return;
    }
    
    traversal(root.left);
    nodes.push(root.val);
    traversal(root.right);
    
};