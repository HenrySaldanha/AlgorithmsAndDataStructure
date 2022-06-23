using Problems.LinkedList;
using static Problems.LinkedList.MergeTwoSortedLists;

namespace Problems.Test.LinkedList
{
    public class MergeTwoSortedListsTests
    {
        [Fact]
        public void Solution_ValidInput_MustReturnSuccess()
        {
            //Arrange
            var solution = new MergeTwoSortedLists();
            var list1 = new ListNode(1);
            list1.next = new ListNode(2);
            list1.next.next = new ListNode(4);

            var list2 = new ListNode(1);
            list2.next = new ListNode(3);
            list2.next.next = new ListNode(4);

            //Act
            var result = solution.Solution(list1, list2);

            //Assert
            Assert.Equal(1, result.val);
            Assert.Equal(1, result.next.val);
            Assert.Equal(2, result.next.next.val);
            Assert.Equal(3, result.next.next.next.val);
            Assert.Equal(4, result.next.next.next.next.val);
            Assert.Equal(4, result.next.next.next.next.next.val);
        }

        [Fact]
        public void Solution_ListNull_MustReturnSuccess()
        {
            //Arrange
            var solution = new MergeTwoSortedLists();
            var list1 = new ListNode(1);
            list1.next = new ListNode(5);
            list1.next.next = new ListNode(12);

            //Act
            var result = solution.Solution(list1, null);

            //Assert
            Assert.Equal(1, result.val);
            Assert.Equal(5, result.next.val);
            Assert.Equal(12, result.next.next.val);
        }
    }
}
