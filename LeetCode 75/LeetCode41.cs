using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCod41;


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
    public TreeNode DeleteNode(TreeNode root, int val)
    {
        if (root == null) return null;

        if (val == root.val)
        {
            if (root.left == null) return root.right;
            if (root.right == null) return root.left;

            TreeNode minRightSubtree = root.right;
            while (minRightSubtree.left != null)
            {
                minRightSubtree = minRightSubtree.left;
            }
            root.val = minRightSubtree.val;
            root.right = DeleteNode(root.right, minRightSubtree.val);
        }
        else if (val < root.val)
        {
            root.left = DeleteNode(root.left, val);
        }
        else
        {
            root.right = DeleteNode(root.right, val);
        }
        return root;
    }
}