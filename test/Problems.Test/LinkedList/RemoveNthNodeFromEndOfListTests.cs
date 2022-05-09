using Problems.LinkedList;
using Xunit;
using static Problems.LinkedList.RemoveNthNodeFromEndOfList;

namespace Problems.Test.LinkedList
{
    public class RemoveNthNodeFromEndOfListTests
    {
        [Fact]
        public void Solution_RemoveLast_MustReturnCorrectAnswer()
        {
            //Arrange
            var solution = new RemoveNthNodeFromEndOfList();
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);

            //Act
            var result = solution.Solution(head, 1);

            //Assert
            Assert.Equal(1, result.val);
            Assert.Equal(2, result.next.val);
            Assert.Null(result.next.next);
        }

        [Fact]
        public void Solution_RemoveFirst_MustReturnCorrectAnswer()
        {
            //Arrange
            var solution = new RemoveNthNodeFromEndOfList();
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);

            //Act
            var result = solution.Solution(head, 3);

            //Assert
            Assert.Equal(2, result.val);
            Assert.Equal(3, result.next.val);
            Assert.Null(result.next.next);
        }
    }
}
