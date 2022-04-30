﻿using Xunit;

namespace Problems.Test
{
    public class RemoveElementTests
    {
        [Theory]
        [InlineData(new[] { 3, 2, 2, 3 }, 2, 2)]
        [InlineData(new[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
        public void SolutionA_ValidInput_MustReturnCorrectAnswer(int[] numbers, int remove, int answer)
        {
            //Arrange
            var solution = new RemoveElement();

            //Act
            var response = solution.SolutionA(numbers, remove);

            //Assert
            Assert.Equal(answer, response);
        }
    }
}
