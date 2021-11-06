using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.Array
{
    public class NewYearChaos
    {
        public void Solve(List<int> q)
        {
            int bribe = 0;
            bool chaotic = false;
            int n = q.Count();
            for (int i = 0; i < n; i++)
            {
                if (q[i] - (i + 1) > 2)
                {
                    chaotic = true;
                    break;
                }
                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                    if (q[j] > q[i])
                        bribe++;
            }
            if (chaotic)
                Console.WriteLine("Too chaotic");
            else
                Console.WriteLine(bribe);
        }
    }
}
