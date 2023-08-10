using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode40;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        if (root == null) return null;

        if (val > root.val)
        {
            return SearchBST(root.right, val);
        }
        else if (val < root.val)
        {
            return SearchBST(root.left, val);
        }
        else
        {
            return root;
        }
        // TreeNode node = root;
        // while (node != null) {
        //     if (val > node.val) {
        //         node = node.right;
        //     } else if (val < node.val) {
        //         node = node.left;
        //     } else if (val == node.val) {
        //         return node;
        //     } else {
        //         return null;
        //     }
        // }
        // return null;
    }
}