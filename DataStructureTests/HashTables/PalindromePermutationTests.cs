using DataStructures.HashTables;
using Xunit;

namespace DataStructureTests.HashTables
{
    
    public class PalindromePermutationTests
    {
        [Fact]
        public void Should_ReturnTrue_When_AnyPermutationIsAPalindrome()
        {
            // [arrange]
            var input = "tact coa";
            var underTest = new PalindromePermutation();

            // [act]
            var result = underTest.HasPermutationsThatArePalindrome(input);

            // [assert]
            Assert.True(result);
        }

        [Fact]
        public void Should_ReturnFalse_When_NoPermutationIsAPalindrome()
        {
            // [arrange]
            var input = "no permutations of this are a palindrome";
            var underTest = new PalindromePermutation();

            // [act]
            var result = underTest.HasPermutationsThatArePalindrome(input);

            // [assert]
            Assert.False(result);
        }

        [Fact]
        public void Should_ReturnFalse_When_StringHasNoLetters()
        {
            // [arrange]
            var input = " ";
            var underTest = new PalindromePermutation();

            // [act]
            var result = underTest.HasPermutationsThatArePalindrome(input);

            // [assert]
            Assert.False(result);
        }
    }
}
