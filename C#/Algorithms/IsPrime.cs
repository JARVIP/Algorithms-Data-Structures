using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class IsPrime
    {
        int n;

        public IsPrime(int n)
        {
            this.n = n;
        }

        public void Check()
        {
            for (int j = 2; j <= n / j; j++)
            {
                if (n % j == 0) n = 1;
            }
            if (n == 1) Console.WriteLine("Not prime");
            else Console.WriteLine("Prime");
        }
    }
}
