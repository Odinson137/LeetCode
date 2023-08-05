using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode31;

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
    public static ListNode ReverseList(ListNode head)
    {
        //Stack<ListNode> stack = new Stack<ListNode>();
        //stack.Push(head);

        //while (head != null && head.next != null)
        //{
        //    head = head.next;
        //    stack.Push(head);
        //}

        //ListNode node = stack.Pop();
        //ListNode a = node;

        //for (; stack.Count > 0;)
        //{
        //    node.next = stack.Pop();
        //    node = node.next;
        //    node.next = null;
        //}

        //return a

        ListNode cycle = head;
        ListNode prev = null;

        while (cycle != null)
        {
            ListNode temp = cycle.next;
            cycle.next = prev;
            prev = cycle;
            cycle = temp;
        }

        return prev;
    }

    //public static void Main()
    //{
    //    ListNode listNode = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

    //    var value = ReverseList(listNode);

    //    Console.WriteLine(value.val);
    //    while (value != null && value.next != null)
    //    {
    //        value = value.next;
    //        Console.WriteLine(value.val);
    //    }
    //}
}
