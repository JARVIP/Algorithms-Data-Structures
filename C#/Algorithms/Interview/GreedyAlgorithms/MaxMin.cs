using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.GreedyAlgorithms
{
    public class MaxMin
    {
        public int Solve(int k, List<int> arr)
        {
            k -= 1;
            arr.Sort();
            int minValue = int.MaxValue;
            for (int i = 0; i < arr.Count() - k; i++)
            {
                int temp = arr[i + k] - arr[i];
                minValue = temp < minValue ? temp : minValue;
            }
            return minValue;
        }
    }
}
