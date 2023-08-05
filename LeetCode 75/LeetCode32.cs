using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode32;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}


public class Solution
{
    public static int PairSum(ListNode head)
    {
        Stack<ListNode> stack = new Stack<ListNode>();

        ListNode cycle = head;
        stack.Push(cycle);

        int len = 1;
        
        while (cycle != null && cycle.next != null)
        {
            cycle = cycle.next;
            stack.Push(cycle);
            len++;
        }

        int max = int.MinValue;
        int i = 0;
        while ( len/2 > i)
        {
            int temp = head.val + stack.Pop().val;
            if (temp > max) max = temp;
            head = head.next;
            i++;
        }

        return max;
    }

    public static void Main()
    {
        ListNode listNode = new ListNode(4, new ListNode(2, new ListNode(2, new ListNode(3))));

        var value = PairSum(listNode);

        Console.WriteLine(value);
        
    }
}