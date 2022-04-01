using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.MasterOfCodingInterview.Algorithms
{
    public class FibonacciDynamicProgramming
    {
        public int Solve(int x, Dictionary<int, int> cache)
        {
            if(cache.ContainsKey(x))
            {
                Console.WriteLine($"{x}: from cache");
                return cache[x];
            }else
            {
                if (x < 2)
                {
                    return x;
                }
                else
                {
                    cache.Add(x, Solve(x - 1, cache) + Solve(x - 2, cache));
                    return cache[x];
                }
            }

        }
    }
}
