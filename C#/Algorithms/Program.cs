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

            ReverseInteger reverse = new ReverseInteger(1234);
            Console.WriteLine(reverse.Reverse());
        }
    }
}
