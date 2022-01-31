using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.Array
{
    public class MinimumSwaps
    {
        public int Solve(int[] arr)
        {
            //// with bubble sort // not working is some scenario
            //int counter = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length - i - 1; j++)
            //    {
            //        if (arr[j] > arr[j + 1])
            //        {
            //            swap(arr, j, j + 1);
            //            counter++;
            //        }
            //    }
            //}
            //return counter;

            // right scenario
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != i + 1)
                {
                    swap(arr, i, arr[i] - 1);
                    counter++;
                    i = 0;
                }
            }
            return counter;
        }

        public void swap(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
