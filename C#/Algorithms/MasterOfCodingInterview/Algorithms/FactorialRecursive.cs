using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.MasterOfCodingInterview.Algorithms
{
    public class FactorialRecursive
    {

        public int SolveRecursive(int x)
        {
            if(x==1)
            {
                return x;
            }
            return x * SolveRecursive(x - 1);
        }


        public int SolveIterative(int x)
        {
            int result = 1;
            for (int i = 2; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }

        public int SolveDynamic(int x, Dictionary<int,int> cache)
        {
            if(cache.ContainsKey(x))
            {
                return cache[x];
            }
            if(x==2 || x == 1)
            {
                return x;
            }
            cache.Add(x, x * SolveDynamic(x - 1, cache));

            return cache[x];

        }
    }
}
