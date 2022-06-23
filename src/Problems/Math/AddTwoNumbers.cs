namespace Problems.Math;

/// <summary>
/// You are given two non-empty linked lists representing two non-negative integers. 
/// The digits are stored in reverse order, and each of their nodes contains a single digit. 
/// Add the two numbers and return the sum as a linked list.
/// You may assume the two numbers do not contain any leading zero, except the number 0 itself.
/// </summary>

/// <example>
/// Input: l1 = [2,4,3], l2 = [5,6,4]
/// Output: [7,0,8]
/// Explanation: 342 + 465 = 807.
/// </example>

public class AddTwoNumbers
{
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

    public ListNode Solution(ListNode l1, ListNode l2)
    {
        ListNode result = null;
        ListNode pointerResult = null;
        var carry = 0;

        while (l1 is not null || l2 is not null)
        {
            var sum = 0;

            if (l1 is not null)
            {
                sum += l1.val;
                l1 = l1.next;
            }

            if (l2 is not null)
            {
                sum += l2.val;
                l2 = l2.next;
            }

            sum += carry;
            carry = sum / 10;

            if (result is null)
            {
                result = new ListNode(sum >= 10 ? sum - 10 : sum);
                pointerResult = result;
            }
            else
            {
                pointerResult.next = new ListNode(sum >= 10 ? sum - 10 : sum);
                pointerResult = pointerResult.next;
            }
        }

        if (carry > 0)
            pointerResult.next = new ListNode(carry);


        return result;
    }
}