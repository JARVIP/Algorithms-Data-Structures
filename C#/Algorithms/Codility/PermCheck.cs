using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Codility
{
    /*
    A non-empty array A consisting of N integers is given.

    A permutation is a sequence containing each element from 1 to N once, and only once.

    For example, array A such that:

        A[0] = 4
        A[1] = 1
        A[2] = 3
        A[3] = 2
    is a permutation, but array A such that:

        A[0] = 4
        A[1] = 1
        A[2] = 3
    is not a permutation, because value 2 is missing.

    The goal is to check whether array A is a permutation.

    Write a function:

    class Solution { public int solution(int[] A); }

    that, given an array A, returns 1 if array A is a permutation and 0 if it is not.

    For example, given array A such that:

        A[0] = 4
        A[1] = 1
        A[2] = 3
        A[3] = 2
    the function should return 1.

    Given array A such that:

        A[0] = 4
        A[1] = 1
        A[2] = 3
    the function should return 0.

    Write an efficient algorithm for the following assumptions:

    N is an integer within the range [1..100,000];
    each element of array A is an integer within the range [1..1,000,000,000].
     
     */
    public class PermCheck
    {
        private int[] _n;

        public PermCheck(int[] n)
        {
            _n = n;
        }

        public int solution()
        {
            int[] count = new int[_n.Length];
            for (int i = 0; i < _n.Length; i++)
            {
                if (_n[i] > 0 && _n[i] <= _n.Length)
                {
                    count[_n[i] - 1] += 1;
                }
                else
                {
                    return 0;
                }
            }
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] != 1)
                    return 0;
            }
            return 1;
        }
    }
}
