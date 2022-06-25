namespace Problems.Sorting;

/// <summary>
/// Given the head of a linked list, return the list after sorting it in ascending order.
/// </summary>

/// <example>
/// Input: head = [4,2,1,3]
/// Output: [1,2,3,4]
/// </example>

public class SortList
{
    public ListNode Solution(ListNode head)
    {
        var aux = head;
        var list = new List<int>();
        while (aux != null)
        {
            list.Add(aux.val);
            aux = aux.next;
        }
        list.Sort();

        aux = head;
        for (var i = 0; i < list.Count; i++)
        {
            head.val = list[i];
            head = head.next;
        }
        return aux;
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