namespace Problems.LinkedList;

/// <summary>
/// Given a linked list, swap every two adjacent nodes and return its head. 
/// You must solve the problem without modifying the values in the list's nodes (i.e., only nodes themselves may be changed.)
/// </summary>

/// <example>
/// Input: head = [1,2,3,4]
/// Output: [2,1,4,3]
/// </example>

public class SwapNodesInPairs
{
    public ListNode Solution(ListNode head)
    {
        if (head?.next is null)
            return head;

        var newHead = new ListNode();
        newHead.next = head;
        var prev = newHead;

        while (prev.next is not null && prev.next.next is not null)
        {
            var first = prev.next;
            var second = prev.next.next;

            first.next = second.next;
            second.next = first;

            prev.next = second;

            prev = first;
        }

        return newHead.next;
    }
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
}