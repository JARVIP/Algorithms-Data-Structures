using System;

namespace Algorithms.Interview
{
    public class SelectionSort
    {
        private int[] nums;

        public SelectionSort(int[] nums)
        {
            this.nums = nums;
        }

        public void Sort()
        {
            for(int i = 0; i < nums.Length; i++)
            {
                int index = i;
                for (int j = i; j < nums.Length; j++)
                {
                    if(nums[j] < nums[index])
                    {
                        index = j;
                    }
                }

                if(index != i)
                {
                    Swap(index, i);
                }
            }
        }

        private void Swap(int i, int j)
        {
            int reminder = nums[i];
            nums[i] = nums[j];
            nums[j] = reminder;
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
