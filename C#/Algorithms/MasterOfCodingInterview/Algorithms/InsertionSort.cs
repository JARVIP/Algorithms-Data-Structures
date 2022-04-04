using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.MasterOfCodingInterview.Algorithms
{
    public class InsertionSort : Sort
    {
        public int[] Solve(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Swap(arr, j, j - 1);
                    }
                }
            }

            return arr;
        }
    }
}
