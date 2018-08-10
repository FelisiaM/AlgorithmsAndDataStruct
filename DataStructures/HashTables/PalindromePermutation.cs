using System;
using System.Collections.Generic;

namespace DataStructures.HashTables
{
    /// <summary>
    /// Given a string, write a function to check if it is a permutation of a palindrome.
    /// A palindrome is a word or phrase that is the same forwards and backwards.
    /// A permutation is a rearrangement of letters.
    /// The palindrome does not need to be limited to just dictionary words.
    /// </summary>
    public class PalindromePermutation
    {
        public bool HasPermutationsThatArePalindrome(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            var cleanInput = input.ToLowerInvariant().Replace(" ", "");

            var charMap = CreateCharactersMap(cleanInput);

            var evenCharsSum = 0;
            var oddCharsSum = 0;
            CountEvenAndOddCharSum(charMap, ref evenCharsSum, ref oddCharsSum);

            if (IsEvenNumber(cleanInput.Length))
            {
                if (oddCharsSum > 0)
                {
                    return false;
                }
                return true;
            }

            if (oddCharsSum > 1)
            {
                return false;
            }
            return true;
        }

        private Dictionary<char, int> CreateCharactersMap(string inputString)
        {
            var charMap = new Dictionary<char, int>();

            foreach (var c in inputString)
            {
                if (charMap.ContainsKey(c))
                {
                    charMap[c]++;
                }
                else
                {
                    charMap.Add(c, 1);
                }
            }
            return charMap;
        }

        private void CountEvenAndOddCharSum(
            Dictionary<char, int> charMap,
            ref int evenCharsSum,
            ref int oddCharsSum)
        {
            foreach (var keyValuePair in charMap)
            {
                if (IsEvenNumber(keyValuePair.Value))
                {
                    evenCharsSum++;
                }
                else
                {
                    oddCharsSum++;
                }
            }
        }

        private bool IsEvenNumber(int input)
        {
            return input % 2 == 0;
        }
    }
}
