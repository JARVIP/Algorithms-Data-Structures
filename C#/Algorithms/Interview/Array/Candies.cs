using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.Array
{
    public class Candies
    {
        public long Solve(int n, List<int> arr)
        {
            int[] cache = new int[arr.Count()];
            cache[0] = 1;

            for (int i = 1; i < arr.Count(); i++)
            {
                if (arr[i - 1] < arr[i])
                {
                    cache[i] = cache[i - 1] + 1;
                }

                if (arr[i - 1] >= arr[i])
                {
                    cache[i] = 1;
                }
            }

            for (int i = arr.Count() - 2; i >= 0; i--)
            {
                if (arr[i] > arr[i + 1])
                {
                    if (cache[i] <= cache[i + 1])
                    {
                        cache[i] = cache[i + 1] + 1;
                    }
                }
            }

            long sum = 0;
            for (int i = 0; i < cache.Length; i++)
            {
                sum += cache[i];
            }

            return sum;
        }
    }
}
