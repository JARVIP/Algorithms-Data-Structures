using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.DictionariesAndHashmaps
{
    public class RansomNote
    {
        public void Solve(List<string> magazine, List<string> note)
        {
            Dictionary<string, int> mag = new Dictionary<string, int>();
            bool f = true;
            foreach (var item in magazine)
            {
                if (!mag.ContainsKey(item))
                {
                    mag.Add(item, 1);
                    continue;
                }
                mag[item]++;
            }

            foreach (var item in note)
            {
                if (mag.ContainsKey(item) && mag[item] > 0)
                {
                    mag[item]--;
                }
                else
                {
                    f = false;
                    break;
                }
            }

            if (f)
            {
                Console.WriteLine("Yes");
                return;
            }
            Console.WriteLine("No");
        }

    }
}
