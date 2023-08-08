using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode37;
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
    public TreeNode LowestCommonAncessr(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == null || root == p || root == q)
            return root;

        TreeNode leftLCA = LowestCommonAncessr(root.left, p, q);
        TreeNode rightLCA = LowestCommonAncessr(root.right, p, q);

        if (leftLCA != null && rightLCA != null)
            return root;

        return leftLCA ?? rightLCA;
    }

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        return LowestCommonAncessr(root, p, q);
    }
}