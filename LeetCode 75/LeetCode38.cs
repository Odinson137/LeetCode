using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode38;
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
    public IList<int> RightSideView(TreeNode root)
    {
        List<int> list = new List<int>();
        if (root == null)
        {
            return list;
        }

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count() > 0)
        {
            int len = queue.Count();

            list.Add(queue.Peek().val);

            for (int i = 0; i < len; i++)
            {

                root = queue.Dequeue();
                Console.WriteLine(root.val);

                if (root.right != null)
                {
                    queue.Enqueue(root.right);

                }

                if (root.left != null)
                {
                    queue.Enqueue(root.left);
                }
            }
        }

        return list;
    }
}