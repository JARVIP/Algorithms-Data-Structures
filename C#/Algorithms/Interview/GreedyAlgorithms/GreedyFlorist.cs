using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.GreedyAlgorithms
{
    public class GreedyFlorist
    {
        public int Solve(int k, int[] c)
        {
            System.Array.Sort(c);
            int cost = 0;
            int numberOfBye = 0;
            int exp = 0;
            for (int i = c.Length - 1; i >= 0; i--)
            {
                cost += (1 + exp) * c[i];
                numberOfBye++;
                if (numberOfBye % k == 0)
                {
                    exp++;
                }
            }
            return cost;
        }
    }
}
