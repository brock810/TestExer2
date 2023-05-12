using System;

namespace PalindromeExercise
{
    public class WordSmith
    {
        static void Main(string[] args)
        {
        }
            public bool IsAPalindrome(string word)
            {
                
                return word == Reverse(word);
            }

            private string Reverse(string word)
            {
                var charArray = word.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
        }
    }
