using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode33;

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
    private static int SearchDepth (TreeNode node, int depth)
    {
        if (node == null) return depth - 1;
        return Math.Max(SearchDepth(node.left, depth + 1), SearchDepth(node.right, depth + 1));
    }

    public static int MaxDepth(TreeNode root)
    {
        return SearchDepth(root, 1);


        //if (root == null) return 0;

        //Stack<TreeNode> stack = new Stack<TreeNode>();
        //stack.Push(root);
        //int maxDepth = 0;

        //while (stack.Count > 0)
        //{
        //    TreeNode node = stack.Pop();

        //    // Проверяем, есть ли у узла дети, и если есть, добавляем их в стек с увеличенной глубиной
        //    if (node.left != null)
        //        stack.Push(node.left);

        //    if (node.right != null)
        //        stack.Push(node.right);

        //    // Обновляем максимальную глубину
        //    maxDepth++;
        //}

        //return maxDepth;
    }

    //public static void Main()
    //{
    //    TreeNode treeNode = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));

    //    var value = MaxDepth(treeNode);

    //    Console.WriteLine(value);

    //}
}