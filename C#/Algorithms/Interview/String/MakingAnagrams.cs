using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.String
{
    public class MakingAnagrams
    {
        public int Solve(string a, string b)
        {
            Dictionary<char, int> bDict = new Dictionary<char, int>();
            foreach (var item in b)
            {
                if (bDict.ContainsKey(item))
                {
                    bDict[item]++;
                    continue;
                }
                bDict.Add(item, 1);
            }
            int strLen = 0;
            foreach (var item in a)
            {
                if (bDict.ContainsKey(item) && bDict[item] > 0)
                {
                    strLen++;
                    bDict[item]--;
                }
            }
            return a.Length - strLen + b.Length - strLen;
        }

    }
}
