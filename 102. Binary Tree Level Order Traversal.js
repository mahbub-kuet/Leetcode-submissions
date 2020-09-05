/**
 * Definition for a binary tree node.
 * function TreeNode(val) {
 *     this.val = val;
 *     this.left = this.right = null;
 * }
 */
/**
 * @param {TreeNode} root
 * @return {number[][]}
 */

// https://leetcode.com/problems/binary-tree-level-order-traversal/

var nodes,levelnodes;
var levelOrder = function(root) {
    nodes=[];
    var h= calculateHeight(root); 
    for(let i=1;i<=h;i++){
        levelnodes=[];
        nodes.push(traverseLevel(root,i));
    }
    return nodes;
};

function calculateHeight(root){
    if(root === null)
       return 0;
    var lheight= calculateHeight(root.left);
    var rheight= calculateHeight(root.right);
    if (lheight > rheight)
        return(lheight+1);
    else 
        return(rheight+1); 
}

function traverseLevel(root,level){
    if(root === null)
        return;
    if(level ===1){
        levelnodes.push(root.val);
    }  
    else if(level >1){
        traverseLevel(root.left,level-1);
        traverseLevel(root.right,level-1);
    }
    return levelnodes;
}