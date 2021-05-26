using System;

namespace Algorithms.Interview
{
    public class QuickSort
    {
        private int[] nums;

        public QuickSort(int[] nums)
        {
            this.nums = nums;
        }

        public void Sort()
        {
            Quicksort(0, nums.Length - 1);
        }

        private void Quicksort(int low, int hight)
        {
            if(low >= hight)
            {
                return;
            }

            int pivot_index = Partition(low, hight);

            Quicksort(low, pivot_index - 1);
            Quicksort(pivot_index + 1, hight);
        }

        private int Partition(int low, int hight)
        {
            int pivot_index = (low + hight) / 2;

            Swap(pivot_index, hight);

            for(int j = low; j <= hight; j++)
            {
                if (nums[j] <= nums[hight])
                {
                    Swap(low, j);
                    low++;
                }
            }
            Swap(low, hight);
            return low;
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
