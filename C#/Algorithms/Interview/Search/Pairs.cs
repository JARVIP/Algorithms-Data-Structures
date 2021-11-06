using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.Search
{
    public class Pairs
    {
        public int Solve(int k, List<int> arr)
        {
            Dictionary<int, int> pairs = arr.ToDictionary(x => x, x=> 1);
            int count = 0;
            for(int i = 0; i < arr.Count(); i++)
            {
                if (k <= arr[i])
                {
                   var temp = arr[i] - k;
               
                    if(pairs.ContainsKey(temp))
                    {
                        count += pairs[temp];
                    }
                }
            }
            return count;
        }
    }
}
