using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.Search
{
    public class TripleSum
    {
        public long Solve(int[] a, int[] b, int[] c)
        {
            Dictionary<int, int> aKeys = new Dictionary<int, int>();
            Dictionary<int, int> bKeys = new Dictionary<int, int>();
            Dictionary<int, int> cKeys = new Dictionary<int, int>();
            System.Array.Sort(a);
            System.Array.Sort(b);
            System.Array.Sort(c);
            long count = 0;
            int indexa = 0;
            int indexc = 0;
            long countA = 0;
            long countC = 0;
            int k = 0;
            while (k < b.Length && b[k] < a[0] && b[k] < c[0])
            {
                k++;
            }
            for (int i = k; i < b.Length; i++)
            {
                if (!bKeys.ContainsKey(b[i]))
                {
                    bKeys.Add(b[i], 1);
                    while (indexa < a.Length && a[indexa] <= b[i])
                    {
                        if (!aKeys.ContainsKey(a[indexa]))
                        {
                            aKeys.Add(a[indexa], 1);
                            countA++;
                        }
                        indexa++;
                    }
                    while (indexc < c.Length && c[indexc] <= b[i])
                    {
                        if (!cKeys.ContainsKey(c[indexc]))
                        {
                            cKeys.Add(c[indexc], 1);
                            countC++;
                        }
                        indexc++;
                    }
                    count += countC * countA;
                }
            }
            return count;
        }
    }
}
