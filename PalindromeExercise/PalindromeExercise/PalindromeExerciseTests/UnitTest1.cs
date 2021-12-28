using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("RaceCar", true)]
        [InlineData("Hello", false)]
        [InlineData("racecar", true)]
        [InlineData("civic", true)]
        [InlineData("madam", true)]
        public void Palindrome(string y, bool expected)
        {
            //arrange
            var z = new WordSmith();
            //act
            var actual = z.IsAPalindrome(y);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
