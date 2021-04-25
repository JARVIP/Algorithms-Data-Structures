using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Codility
{
    /*
    This is a demo task.

    Write a function:

    class Solution { public int solution(int[] A); }

    that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

    For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

    Given A = [1, 2, 3], the function should return 4.

    Given A = [−1, −3], the function should return 1.

    Write an efficient algorithm for the following assumptions:

    N is an integer within the range [1..100,000];
    each element of array A is an integer within the range [−1,000,000..1,000,000].
     */
    public class MissingInteger
    {
        private int[] _n;

        public MissingInteger(int[] n)
        {
            _n = n;
        }

        public int solution()
        {
            int[] counter = new int[_n.Length];

            for (int i = 0; i < _n.Length; i++)
            {
                if (_n[i] > 0 && _n[i] <= _n.Length)
                    counter[_n[i] - 1] += 1;
            }

            for (int i = 0; i < counter.Length; i++)
            {
                if (counter[i] == 0)
                    return i + 1;
            }
            return counter.Length + 1;
        }
    }
}
