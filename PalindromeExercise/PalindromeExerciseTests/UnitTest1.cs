using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("1221", true)]
        public void TestIsAPalindrome(string word, bool expected)
        {
            // Arrange
            var wordSmith = new WordSmith();

            // Act
            var actual = wordSmith.IsAPalindrome(word);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}