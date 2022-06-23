using Problems.LinkedList;

namespace Problems.Test.LinkedList;

public class ReverseLinkedListTests
{
    [Fact]
    public void Solution_ValidInput_MustReturnSuccess()
    {
        //Arrange
        var solution = new ReverseLinkedList();
        var head = new ReverseLinkedList.ListNode(1);
        head.next = new ReverseLinkedList.ListNode(2);
        head.next.next = new ReverseLinkedList.ListNode(3);
        head.next.next.next = new ReverseLinkedList.ListNode(4);
        head.next.next.next.next = new ReverseLinkedList.ListNode(5);

        //Act
        var result = solution.Solution(head);

        //Assert
        Assert.Equal(5, result.val);
        Assert.Equal(4, result.next.val);
        Assert.Equal(3, result.next.next.val);
        Assert.Equal(2, result.next.next.next.val);
        Assert.Equal(1, result.next.next.next.next.val);
        Assert.Null(result.next.next.next.next.next);
    }
}