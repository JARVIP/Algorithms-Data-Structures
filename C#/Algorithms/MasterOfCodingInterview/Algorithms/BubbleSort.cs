using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.MasterOfCodingInterview.Algorithms
{
    public class BubbleSort : Sort
    {
        [Benchmark]
        public int[] Solve(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                    }
                }
            }

            return arr;
        }



        [Benchmark]
        public int[] SolveN(int[] arr)
        {
            int[] N = new int[arr.Max() + 1];
            for (int i = 0; i < arr.Length; i++)
            {
               N[arr[i]] = N[arr[i]] +1;
            }

            int index = 0;

            for(int i = 0; i < N.Length; i++)
            {
                while(N[i] > 0)
                {
                    arr[index] = i;
                    N[i] = N[i]-1;
                    index++;
                }
            }



            return arr;
        }

    }
}
