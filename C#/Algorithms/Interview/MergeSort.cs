using System;

namespace Algorithms.Interview
{
    public class MergeSort
    {
        private int[] nums;

        public MergeSort(int[] nums)
        {
            this.nums = nums;
        }

        public void Sort()
        {

            MergeSrt(nums);
        }

        private void MergeSrt(int[] num)
        {
            if (num.Length == 1)
            {
                return;
            }

            int middleIndex = num.Length / 2;
            int[] leftHalf = new int[middleIndex];
            int[] righttHalf = new int[num.Length - middleIndex];
            //Array.Copy(num, 0, leftHalf, 0, middleIndex);
            //Array.Copy(num, middleIndex, righttHalf, 0, num.Length - middleIndex);

            MergeSrt(leftHalf);
            MergeSrt(righttHalf);

            int i = 0, j = 0, k = 0;

            while (i < leftHalf.Length && j < righttHalf.Length)
            {
                if (leftHalf[i] < righttHalf[j])
                {
                    num[k] = leftHalf[i];
                    i++;
                }
                else
                {
                    num[k] = righttHalf[j];
                    j++;
                }
                k++;
            }

            while (i < leftHalf.Length)
            {
                num[k] = leftHalf[i];
                i++;
                k++;
            }
            while (j < righttHalf.Length)
            {
                num[k] = righttHalf[j];
                j++;
                k++;
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
