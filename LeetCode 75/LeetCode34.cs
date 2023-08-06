using LeetCode33;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode34;

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
    public static bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        Queue<int> ints = new Queue<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root1);

        while (stack.Count > 0)
        {
            TreeNode treeNode = stack.Pop();

            if (treeNode.left != null)
            {
                stack.Push(treeNode.left);
            }
            if (treeNode.right != null)
            {
                stack.Push(treeNode.right);
            }

            if (treeNode.right == null && treeNode.left == null)
            {
                ints.Enqueue(treeNode.val);
            }
        }

        stack.Push(root2);

        while (stack.Count > 0)
        {
            TreeNode treeNode = stack.Pop();

            if (treeNode.left != null)
            {
                stack.Push(treeNode.left);
            }
            if (treeNode.right != null)
            {
                stack.Push(treeNode.right);
            }

            if (treeNode.right == null && treeNode.left == null)
            {
                if (ints.Count > 0)
                {
                    if (ints.Dequeue() != treeNode.val)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        return ints.Count == 0;
    }

    //public static void Main()
    //{
    //    TreeNode root1 = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));
    //    TreeNode root2 = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));

    //    var value = LeafSimilar(root1, root2);

    //    Console.WriteLine(value);
    //}
}
