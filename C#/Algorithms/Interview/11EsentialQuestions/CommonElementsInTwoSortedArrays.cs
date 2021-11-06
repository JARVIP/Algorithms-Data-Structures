using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview._11EsentialQuestions
{
    public class CommonElementsInTwoSortedArrays
    {
        // my solution
        public List<int> Solve(int[] a, int[] b)
        {
            int startIndex = 0;
            List<int> result = new List<int>();
            for(int i = 0; i < a.Length; i++)
            {
               
                while(startIndex < b.Length)
                {
                    if (a[i] < b[startIndex])
                    {
                        break;
                    }
                    if (b[startIndex] == a[i])
                    {
                        result.Add(a[i]);
                        startIndex++;
                        break;
                    }
                    startIndex++;
                }
            }

            return result;
        }

        // instructor solution.
        public List<int> CommonElements(int[] a, int[] b)
        {
            List<int> result = new List<int>();
            int p1 = 0;
            int p2 = 0;
            while(p1 < a.Length && p2 < b.Length)
            {
                if(a[p1] == b[p2])
                {
                    result.Add(a[p1]);
                    p1++;
                    p2++;
                }
                else if(a[p1] > b[p2])
                {
                    p2++;
                }else
                {
                    p1++;
                }
            }
            return result;
        }
    }
}
