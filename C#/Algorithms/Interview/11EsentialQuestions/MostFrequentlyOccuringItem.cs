using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview._11EsentialQuestions
{
    public class MostFrequentlyOccuringItem
    {
        // my sollution and instructor's sollution was same
        public int Solve(int[] arr)
        {
            Dictionary<int, int> counter = new Dictionary<int, int>();
            int maxValue = 0;
            int maxKey = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(counter.ContainsKey(arr[i]))
                {
                    counter[arr[i]]++;
                }
                else
                {
                    counter.Add(arr[i], 1);
                }

                if (maxValue < counter[arr[i]])
                {
                    maxValue = counter[arr[i]];
                    maxKey = arr[i];
                }
            }
            return maxKey;
        }
    }
}
