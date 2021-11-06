using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.Miscellaneous
{
    public class TimeComplexityPrimality
    {
        public string Solve(int x)
        {
            int k = 1;
            if (x == 1)
                return "Not prime";
            else if (x == 2)
                return "Prime";
            else if (x % 2 == 0)
                return "Not prime";
            else
            {
                for (int i = 3; i * i <= x; i += 2)
                {
                    if (x % i == 0)
                    {
                        return "Not prime";
                    }
                }
            }
            return "Prime";
        }
    }
}
