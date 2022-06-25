namespace Problems.Test.Sorting;

public class SortListTests
{
    [Fact]
    public void Solution_ValidInput_MustReturnSuccess()
    {
        //Arrange
        var solution = new SortList();
        var head = new ListNode(4);
        head.next = new ListNode(2);
        head.next.next = new ListNode(1);
        head.next.next.next = new ListNode(3);

        //Act
        var result = solution.Solution(head);

        //Assert
        Assert.Equal(1, result.val);
        Assert.Equal(2, result.next.val);
        Assert.Equal(3, result.next.next.val);
        Assert.Equal(4, result.next.next.next.val);
    }
}