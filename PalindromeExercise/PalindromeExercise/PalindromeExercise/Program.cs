using System;

namespace PalindromeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class WordSmith
    {
        public bool IsAPalindrome(string y)
        {
            string empty = "";

            for (int i = y.Length-1; i >= 0; i--)
            {
                empty += y.ToLower()[i];
            }

            if (empty == y.ToLower())
            {
                return true;
            }
            else
            {
                return false;
            }         

        }

    }
}
