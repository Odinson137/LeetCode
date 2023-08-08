using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode36;
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


    public int Cycle(TreeNode root, long targetSum)
    {
        if (root == null)
        {
            return 0;
        }

        int count = 0;
        if (targetSum == root.val)
        {
            count++;
        }

        count += Cycle(root.left, targetSum - root.val);
        count += Cycle(root.right, targetSum - root.val);
        return count;

    }

    public int PathSum(TreeNode root, int targetSum)
    {
        if (root == null)
        {
            return 0;
        }

        int result1 = Cycle(root, (long)targetSum);
        int result2 = PathSum(root.left, targetSum);
        int result3 = PathSum(root.right, targetSum);
        return result1 + result2 + result3;
    }
}
