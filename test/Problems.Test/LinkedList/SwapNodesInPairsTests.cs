using Problems.LinkedList;
using Xunit;

namespace Problems.Test.LinkedList
{
    public class SwapNodesInPairsTests
    {
        [Fact]
        public void Solution_ValidInput_MustReturnCorrectAnswer()
        {
            //Arrange
            var solution = new SwapNodesInPairs();
            var head = new ListNode(1, new ListNode(2,new ListNode(3, new ListNode(4))));

            //Act
            var response = solution.Solution(head);

            //Assert
            Assert.Equal(2, response.val);
            Assert.Equal(1, response.next.val);
            Assert.Equal(4, response.next.next.val);
            Assert.Equal(3, response.next.next.next.val);
        }
    }
}