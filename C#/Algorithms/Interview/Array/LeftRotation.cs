using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.Array
{
    public class LeftRotation
    {
        public List<int> solve(List<int> a, int d)
        {
            int n = a.Count();
            int rotationIndex = d % n;
            List<int> result = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int index = (i + rotationIndex) % n;
                result.Add(a[index]);
            }
            return result;
        }
    }
}
