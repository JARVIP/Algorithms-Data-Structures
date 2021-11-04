using System;

namespace Algorithms.Interview
{
    public class BubbleSort
    {
        private int[] nums;

        public BubbleSort(int[] nums)
        {
            this.nums = nums;
        }

        public void Sort()
        {
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = 0;j < nums.Length - i - 1; j++)
                {
                    if(nums[j] > nums[j+1])
                    {
                        Swap(j, j + 1);
                    }
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
