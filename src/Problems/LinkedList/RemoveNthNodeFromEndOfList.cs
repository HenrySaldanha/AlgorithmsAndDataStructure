namespace Problems.LinkedList;

/// <summary>
/// Given the head of a linked list, remove the nth node from the end of the list and return its head.
/// </summary>

/// <example>
/// Input: head = [1,2,3,4,5], n = 2
/// Output: [1,2,3,5]
/// </example>

/// <example>
/// Input: head = [1], n = 1
/// Output: []
/// </example>

public class RemoveNthNodeFromEndOfList
{
    public ListNode Solution(ListNode head, int n)
    {
        var size = 0;
        var temp = head;

        while (temp != null)
            (size, temp) = (size + 1, temp.next);

        if (size == n)
            return head.next;

        temp = head;
        for (var i = 0; i < size - n - 1; i++)
            temp = temp.next;

        temp.next = temp.next.next;

        return head;
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