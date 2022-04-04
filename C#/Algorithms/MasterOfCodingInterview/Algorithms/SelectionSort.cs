using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.MasterOfCodingInterview.Algorithms
{
    public class SelectionSort : Sort
    {
        public int[] Solve(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                Swap(arr, i, minIndex);
            }
            return arr;
        }
    }
}
