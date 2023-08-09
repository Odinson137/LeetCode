using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode39;
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
    public int MaxLevelSum(TreeNode node)
    {
        if (node == null)
            return 0;


        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(node);

        int n = 0;
        int maxSum = int.MinValue;

        int layer = 0;
        while (queue.Count() > 0)
        {
            int len = queue.Count();

            int sum = 0;
            for (int i = 0; i < len; i++)
            {
                node = queue.Dequeue();

                sum += node.val;

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

            layer++;
            if (sum > maxSum)
            {
                maxSum = sum;
                n = layer;
            }
        }

        return n;

    }
}