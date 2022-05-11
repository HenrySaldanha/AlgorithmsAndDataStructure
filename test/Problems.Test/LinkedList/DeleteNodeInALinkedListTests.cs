﻿using Problems.LinkedList;
using Xunit;
using static Problems.LinkedList.DeleteNodeInALinkedList;

namespace Problems.Test.LinkedList
{
    public class DeleteNodeInALinkedListTests
    {
        [Fact]
        public void Solution_ValidInput_MustReturnCorrectAnswer()
        {
            //Arrange
            var solution = new DeleteNodeInALinkedList();
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);

            //Act
            solution.Solution(head.next);

            //Assert
            Assert.Equal(1, head.val);
            Assert.Equal(3, head.next.val);
            Assert.Null(head.next.next);
        }
    }
}