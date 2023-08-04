using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode30;

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
    public static ListNode OddEvenList(ListNode head)
    {
        if (head == null || head.next == null)
            return head;

        ListNode selected = head;
        ListNode even = head.next;
        ListNode temp = head.next;
        //newHead.next = new ListNode(selected.next.next.next.val);
        while (selected != null && selected.next != null && even != null && even.next != null)
        {
            selected.next = selected.next.next;
            selected = selected.next;

            even.next = even.next.next;
            even = even.next;
            
        }
        selected.next = temp;

        return head;
    }

    public static void Main()
    {
        ListNode listNode = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

        var value = OddEvenList(listNode);

        Console.WriteLine(value.val);
        while (value != null && value.next != null)
        {
            value = value.next;
            Console.WriteLine(value.val);
        }
    }
}