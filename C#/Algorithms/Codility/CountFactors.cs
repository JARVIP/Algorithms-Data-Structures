using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Codility
{
    /*
        A positive integer D is a factor of a positive integer N if there exists an integer M such that N = D * M.

        For example, 6 is a factor of 24, because M = 4 satisfies the above condition (24 = 6 * 4).

        Write a function:

        class Solution { public int solution(int N); }

        that, given a positive integer N, returns the number of its factors.

        For example, given N = 24, the function should return 8, because 24 has 8 factors, namely 1, 2, 3, 4, 6, 8, 12, 24. There are no other factors of 24.

        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [1..2,147,483,647].
     */

    public class CountFactors
    {
        private int _n;

        public CountFactors(int n)
        {
            _n = n;
        }

        public int solution()
        {
            int sqrtN = (int)Math.Sqrt(_n);
            int numFactor = 0;

            for (int i = 1; i <= sqrtN; i++)
            {
                if (_n % i == 0)
                {
                    numFactor++;
                }
            }

            numFactor = numFactor * 2;

            if (sqrtN * sqrtN == _n)
            {
                numFactor = numFactor - 1;
            }

            return numFactor;
        }
    }
}
