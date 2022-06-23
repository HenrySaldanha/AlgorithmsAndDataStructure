namespace Problems.LinkedList;

/// <summary>
/// Given head, the head of a linked list, determine if the linked list has a cycle in it.
/// There is a cycle in a linked list if there is some node in the list that can be reached 
/// again by continuously following the next pointer.Internally, pos is used to denote the index 
/// of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.
/// Return true if there is a cycle in the linked list.Otherwise, return false.
/// </summary>

/// <example>
/// Input: 
/// 1->2
/// 2->3
/// 3->4
/// 4->1
/// , pos = 1
/// Output: [4,5,9]
/// Explanation: You are given the third node with value 1, the linked list should become 4 -> 5 -> 9 after calling your function.
/// </example>

public class LinkedListCycle
{
    public bool SolutionA(ListNode head)
    {
        var visited = new HashSet<ListNode>();

        while (head is not null && !visited.Contains(head))
        {
            visited.Add(head);
            head = head.next;
        }

        return head != null;
    }

    public bool SolutionB(ListNode head)
    {
        var fast = head;
        var slow = head;

        while (fast is not null && fast.next is not null)
        {
            fast = fast.next.next;
            slow = slow.next;

            if (fast == slow)
                return true;
        }

        return false;
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }
}