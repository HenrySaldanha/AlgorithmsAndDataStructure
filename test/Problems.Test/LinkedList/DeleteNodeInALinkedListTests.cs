using Problems.LinkedList;

namespace Problems.Test.LinkedList;

public class DeleteNodeInALinkedListTests
{
    [Fact]
    public void Solution_ValidInput_MustReturnCorrectAnswer()
    {
        //Arrange
        var solution = new DeleteNodeInALinkedList();
        var head = new DeleteNodeInALinkedList.ListNode(1);
        head.next = new DeleteNodeInALinkedList.ListNode(2);
        head.next.next = new DeleteNodeInALinkedList.ListNode(3);

        //Act
        solution.Solution(head.next);

        //Assert
        Assert.Equal(1, head.val);
        Assert.Equal(3, head.next.val);
        Assert.Null(head.next.next);
    }
}