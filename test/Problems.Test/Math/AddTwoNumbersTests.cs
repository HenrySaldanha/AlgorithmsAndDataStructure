namespace Problems.Test.Math;

public class AddTwoNumbersTests
{
    [Fact]
    public void Solution_ValidInput_MustReturnCorrectAnswer()
    {
        //Arrange
        var solution = new AddTwoNumbers();
        var nodeA2 = new AddTwoNumbers.ListNode(3);
        var nodeA1 = new AddTwoNumbers.ListNode(4, nodeA2);
        var rootA = new AddTwoNumbers.ListNode(2, nodeA1);

        var nodeB2 = new AddTwoNumbers.ListNode(4);
        var nodeB1 = new AddTwoNumbers.ListNode(6, nodeB2);
        var rootB = new AddTwoNumbers.ListNode(5, nodeB1);

        //Act
        var response = solution.Solution(rootA, rootB);

        //Assert
        Assert.Equal(7, response.val);
        Assert.Equal(0, response.next.val);
        Assert.Equal(8, response.next.next.val);
    }
}