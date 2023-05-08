using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("sure", false)]
        [InlineData("what", false)]
        [InlineData("hello", false)]

        public void myTester(string word, bool expected)
        {
            var tester = new WordSmith();

            bool actual = tester.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }

    }
}
