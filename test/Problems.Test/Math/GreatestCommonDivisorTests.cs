﻿using Problems.Math;
using Xunit;

namespace Problems.Test
{
    public class GreatestCommonDivisorTests
    {
        [Theory]
        [InlineData(6, 9, 3)]
        [InlineData(7, 4, 1)]
        [InlineData(12, 36, 12)]
        [InlineData(20, 15, 5)]
        public void SolutionA_ValidInput_MustReturnCorrectAnswer(int a, int b, int answer)
        {
            //Arrange
            var solution = new GreatestCommonDivisor();

            //Act
            var response = solution.SolutionA(a, b);

            //Assert
            Assert.Equal(answer, response);
        }
    }
}