using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode35;

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
    static int num = 0;
    public static void Cycle(TreeNode root, int val)
    {

        if (root == null)
        {
            return;
        }

        if (root.val >= val)
        {
            num++;
            val = root.val;
        }
        Cycle(root.left, val);
        Cycle(root.right, val);

    }

    public static int GoodNodes(TreeNode root)
    {
        Cycle(root, root.val);
        return num;
    }

    //public static void Main()
    //{
    //    TreeNode root1 = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));

    //    var value = GoodNodes(root1);

    //    Console.WriteLine(value);
    //}


}


