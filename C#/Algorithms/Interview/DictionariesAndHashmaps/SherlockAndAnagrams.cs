using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.DictionariesAndHashmaps
{
    public class SherlockAndAnagrams
    {

        public int Solve(string s)
        {
            var dict = new Dictionary<string, int>();
            var count = 0;

            for (var i = 0; i < s.Length; i++)
            {
                for (var j = i; j < s.Length; j++)
                {
                    var subString = s.Substring(i, j - i + 1);
                        
                    string orderedString = new string(subString.ToCharArray().OrderBy(p => p).ToArray());

                    if (!dict.ContainsKey(orderedString))
                    {
                        dict.Add(orderedString, 1);
                    }
                    else
                    {
                        count += dict[orderedString];
                        dict[orderedString]++;
                    }
                }
            }

            return count;

        }
    }
}
