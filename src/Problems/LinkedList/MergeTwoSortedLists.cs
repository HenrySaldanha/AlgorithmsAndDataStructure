namespace Problems.LinkedList;

/// <summary>
/// You are given the heads of two sorted linked lists list1 and list2.
/// Merge the two lists in a one sorted list. The list should be made by
/// splicing together the nodes of the first two lists.
/// Return the head of the merged linked list.
/// </summary>

/// <example>
/// Input: list1 = [1,2,4], list2 = [1,3,4]
/// Output: [1,1,2,3,4,4]
/// </example>

public class MergeTwoSortedLists
{
    public ListNode Solution(ListNode list1, ListNode list2)
    {
        if (list1 is null)
            return list2;

        if (list2 is null)
            return list1;

        if (list1.val < list2.val)
        {
            list1.next = Solution(list1.next, list2);
            return list1;
        }
        else
        {
            list2.next = Solution(list2.next, list1);
            return list2;
        }
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