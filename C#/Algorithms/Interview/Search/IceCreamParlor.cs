using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.Search
{
    public class IceCreamParlor
    {
        public void Solve(List<int> cost, int money)
        {
            // core logic
            Dictionary<int, int> hashMap = new Dictionary<int, int>();
            for (int i = 0; i < cost.Count(); i++)
            {
                if (cost[i] < money)
                {
                    if (hashMap.ContainsKey(money - cost[i]))
                    {
                        int index = hashMap[money - cost[i]];
                        Console.WriteLine((index + 1) + " " + (i + 1));
                        return;
                    }

                    if (!hashMap.ContainsKey(cost[i]))
                    {
                        hashMap.Add(cost[i], i);
                    }
                }
            }
        }
    }
}
