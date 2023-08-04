using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode29;

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
    public static ListNode DeleteMiddle(ListNode head)
    {
        if (head.next == null)
            return null;

        ListNode selected = head;
        ListNode beforeMiddle = null;
        ListNode doubleSpeed = head;
        while (doubleSpeed != null && doubleSpeed.next != null)
        {
            beforeMiddle = selected;
            selected = selected.next;
            doubleSpeed = doubleSpeed.next.next;
        }

        beforeMiddle.next = selected.next;
        return head;
    }

    //public static void Main()
    //{
    //    //ListNode listNode = new ListNode(1, new ListNode(3, new ListNode(4, new ListNode(7, new ListNode(1, new ListNode(2, new ListNode(6)))))));
    //    ListNode listNode = new ListNode(1);

    //    var value = DeleteMiddle(listNode);
    //    while (value.next != null)
    //    {
    //        Console.WriteLine(value.val);
    //        value = value.next;
    //    }
    //}
}