using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[]{1,2,3,4 };
            ReverseArray reverseArray = new ReverseArray(n);
            int[] reversed = reverseArray.GetReverseArray();
            foreach(var item in reversed){
                Console.Write($"{item}, ");
            }

        }
    }
}
