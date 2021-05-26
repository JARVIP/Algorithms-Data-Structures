using System;

namespace Algorithms.Interview
{
    public class InsertionSort
    {
        private int[] nums;

        public InsertionSort(int[] nums)
        {
            this.nums = nums;
        }

        public void Sort()
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int j = i;

                while (j > 0 && nums[j - 1] > nums[j])
                {
                    Swap(j - 1, j);
                    j--;
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
