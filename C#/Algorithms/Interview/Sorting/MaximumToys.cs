using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.Sorting
{
    public class MaximumToys
    {
        public int Solve(List<int> prices, int k)
        {
            prices.Sort();
            int counter = 0;
            foreach (var item in prices)
            {
                k = k - item;
                if (k <= 0)
                {
                    break;
                }
                counter++;
            }
            return counter;
        }
    }
}
