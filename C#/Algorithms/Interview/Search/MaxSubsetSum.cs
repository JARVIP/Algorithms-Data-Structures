using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.Search
{
    public class MaxSubsetSum
    {
        public int Solve(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return 0;
            int n = arr.Length;
            if (n == 1)
                return arr[0];
            if (n == 2)  //Just for clarification  not really need that
                return Math.Max(arr[0], arr[1]);
            //will hold all max till the i-th location
            int[] g = new int[n];
            int currMax = Math.Max(arr[0], arr[1]);
            g[0] = arr[0];
            g[1] = currMax;
            for (int i = 2; i < arr.Length; i++)
            {
                currMax = Math.Max(g[i - 2] + arr[i], currMax);
                currMax = Math.Max(arr[i], currMax);
                g[i] = currMax;

            }
            return g[n - 1];
            // return IntStream.of(g).max().getAsInt();
        }
    }
}
