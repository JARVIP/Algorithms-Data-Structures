using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.DictionariesAndHashmaps
{
    public class CountTriplets
    {
        public long Solve(List<long> arr, long r)
        {
            //arr.Sort();
            //Dictionary<long, int> temp = new Dictionary<long, int>();
            //long counter = 0;
            //for (int i = 0; i < arr.Count(); i++)
            //{
            //    if (!temp.ContainsKey(arr[i]))
            //    {
            //        temp.Add(arr[i], 1);
            //    }
            //    else
            //    {
            //        temp[arr[i]] += 1;
            //    }
            //    if (arr[i] % r == 0)
            //    {
            //        if (temp.ContainsKey(arr[i] / r) && temp.ContainsKey(arr[i] / r / r))
            //        {
            //            counter = counter + Math.Max(temp[arr[i] / r], temp[arr[i] / r / r]);
            //        }
            //    }
            //}
            //return counter;

            //number of times we encounter key*r
            var doubles = new Dictionary<long, long>();
            //number of times we encounter a triplet
            var triplets = new Dictionary<long, long>();
            long count = 0;
            foreach (var key in arr)
            {
                long keyXr = key * r;

                if (triplets.ContainsKey(key))
                    count += triplets[key];

                if (doubles.ContainsKey(key))
                {
                    if (triplets.ContainsKey(keyXr))
                        triplets[keyXr] += doubles[key];
                    else
                        triplets.Add(keyXr, doubles[key]);
                }

                if (doubles.ContainsKey(keyXr))
                    doubles[keyXr]++;
                else
                    doubles.Add(keyXr, 1);
            }
            return count;
        }
    }
}
