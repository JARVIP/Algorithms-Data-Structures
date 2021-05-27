using System;
using System.Linq;

namespace Algorithms.Interview
{
    public class CountingSort
    {
        private int[] nums;
        int[] countArray;
        int minValue;
        int maxValue;
        public CountingSort(int[] nums)
        {
            this.nums = nums;
            minValue = nums.Min();
            maxValue = nums.Max();
            countArray = new int[maxValue - minValue + 1];
        }

        public void Sort()
        {
            for(int i = 0; i < nums.Length; i++)
            {
                countArray[nums[i] - minValue] += 1;
            }

            int z = 0;
            for(int i = minValue; i < maxValue + 1; i++)
            {
                while(countArray[i - minValue] > 0)
                {
                    nums[z] = i;
                    z++;
                    countArray[i - minValue] -= 1;
                }
            }
        }

        public void PrintNums()
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]},");
            }
            Console.WriteLine();
        }
    }
}
