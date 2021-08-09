using System;
using System.Linq;

namespace Algorithms.Codility
{
    /*
        An array A consisting of N different integers is given. The array contains integers in the range [1..(N + 1)],
        which means that exactly one element is missing.

        Your goal is to find that missing element.

        Write a function:

        class Solution { public int solution(int[] A); }

        that, given an array A, returns the value of the missing element.

        For example, given array A such that:

          A[0] = 2
          A[1] = 3
          A[2] = 1
          A[3] = 5
        the function should return 4, as it is the missing element.

        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [0..100,000];
        the elements of A are all distinct;
        each element of array A is an integer within the range [1..(N + 1)].
     
     */
    public class PermMissingElem
    {
        private int[] _a;

        public PermMissingElem(int[] a)
        {
            _a = a;
        }

        //O(N) or O(N* log(N))
        public int solution()
        {
            if (_a.Length == 0)
                return 1;

            Array.Sort(_a);

            for (int i = 0; i < _a.Length; i++)
            {
                if (_a[i] != i + 1)
                {
                    return i + 1;
                }
            }
            return _a.Length + 1;
        }

        //O(N ** 2)
        public int solution2()
        {
            int n = _a.Length + 1;
            // sum of consecutive integers from 1 to n is equal to n(n+1)/2.
            int result = n * (n + 1) / 2;
            return result - _a.Sum();
        }

        //O(N) or O(N* log(N))
        public int solution3()
        {
            Array.Sort(_a);
            int n = _a.Length;
            for (int i = 0; i < n; i++)
            {
                if (_a[i] != i + 1)
                {
                    return i + 1;
                }
            }
            return n == 0 ? 1 : _a[n - 1] + 1;
        }
    }
}
