using Problems.LinkedList;

namespace Problems.Test.LinkedList;

public class SwapNodesInPairsTests
{
    [Fact]
    public void Solution_ValidInput_MustReturnCorrectAnswer()
    {
        //Arrange
        var solution = new SwapNodesInPairs();
        var head = new SwapNodesInPairs.ListNode(1, new SwapNodesInPairs.ListNode(2, new SwapNodesInPairs.ListNode(3, new SwapNodesInPairs.ListNode(4))));

        //Act
        var response = solution.Solution(head);

        //Assert
        Assert.Equal(2, response.val);
        Assert.Equal(1, response.next.val);
        Assert.Equal(4, response.next.next.val);
        Assert.Equal(3, response.next.next.next.val);
    }
}