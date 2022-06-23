namespace Problems.LinkedList;

/// <summary>
/// Given the head of a linked list, remove the nth node from the end of the list and return its head.
/// </summary>
/// <example>
/// Input: head = [1,2,3,4,5], n = 2
/// Output: [1,2,3,5]
/// </example>
public class ReverseLinkedList
{
    public ListNode Solution(ListNode head)
    {
        var curr = head;
        ListNode last = null;
        ListNode temp = null;

        while (curr is not null)
        {
            temp = curr.next;
            curr.next = last;
            last = curr;
            curr = temp;
        }

        return last;
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