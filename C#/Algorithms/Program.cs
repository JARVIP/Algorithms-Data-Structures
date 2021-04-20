using Algorithms.Codility;
using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Reverse array Test
            ///int[] n = new int[]{1,2,3,4 };
            ///ReverseArray reverseArray = new ReverseArray(n);
            ///int[] reversed = reverseArray.GetReverseArray();
            ///foreach(var item in reversed){
            ///    Console.Write($"{item}, ");
            ///}
            ///

            /// PalindromeCheck test
            ///PalindromeCheck palindromeCheck = new PalindromeCheck("radar");
            ///Console.WriteLine(palindromeCheck.IsPalindrome());

            /// Reverse Integer test
            ///ReverseInteger reverse = new ReverseInteger(1234);
            ///Console.WriteLine(reverse.Reverse());

            /// Anagram Test
            ///AnagramProblem anagramProblem = new AnagramProblem("test", "sett");
            ///Console.WriteLine(anagramProblem.IsAnagram());

            /// Duplicate array problem Test
            ///DuplicateArrayProblem duplicateArrayProblem = new DuplicateArrayProblem(new int[]{1 ,2 , 3 , 1, 4, 2});
            ///duplicateArrayProblem.FindDuplicates();

            /// Is number Prime
            ///IsPrime isPrime = new IsPrime(169);
            ///isPrime.Check();

            OddOccurrencesInArray odd = new OddOccurrencesInArray(new int[] { 9,3,9,3,9,7,9 });
            Console.WriteLine(odd.solution());

        }
    }
}
