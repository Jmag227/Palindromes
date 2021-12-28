using System;
using Xunit;
using System.Linq;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1, 2, 3, 6)]
        [InlineData(2, 3, 4, 9)]
        [InlineData(3, 4, 10, 17)]
        [InlineData(4, 10, 30, 44)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var x = new UnitTestMethods();
            //Act
            int answer = x.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, answer);
        }

        [Theory]
        [InlineData(10, 10, 0)]
        [InlineData(5, 6, -1)]
        [InlineData(11, 5, 6)]
        [InlineData(30, 15, 15)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var x = new UnitTestMethods();
            //Act
            int answer = x.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, answer);
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(1, 5, 5)]
        [InlineData(2, 5, 10)]
        [InlineData(20, 5, 100)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var x = new UnitTestMethods();
            //Act
            int answer = x.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, answer);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(4, 2, 2)]
        [InlineData(12, 3, 4)]
        [InlineData(40, 4,10)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var x = new UnitTestMethods();
            //Act
            int answer = x.Div(num1, num2);
            //Assert
            Assert.Equal(expected, answer);
        }

        [Fact]
        public void GetEvensUnder50()
        {
            //Arrange
            var x = new UnitTestMethods();
            int[] odds =
            {
                1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25,
                27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49
            };
            //Act
            int[] answer = x.GetEvensUnder50();

            //Assert
            Assert.Equal(odds, answer);

        }

        [Fact]
        public void CanVote()
        {
            //Arrange
            var x = new UnitTestMethods();
            //Act
            bool answer = x.CanVote();
            //Assert
            Assert.True(answer);
        }
    }
}
