using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Codility
{
    /*
     
        A non-empty array A consisting of N integers is given. The product of triplet (P, Q, R) equates to _a[P] * _a[Q] * _a[R] (0 ≤ P < Q < R < N).

        For example, array A such that:

          _a[0] = -3
          _a[1] = 1
          _a[2] = 2
          _a[3] = -2
          _a[4] = 5
          _a[5] = 6
        contains the following example triplets:

        (0, 1, 2), product is −3 * 1 * 2 = −6
        (1, 2, 4), product is 1 * 2 * 5 = 10
        (2, 4, 5), product is 2 * 5 * 6 = 60
        Your goal is to find the maximal product of any triplet.

        Write a function:

        class Solution { public int solution(int[] A); }

        that, given a non-empty array A, returns the value of the maximal product of any triplet.

        For example, given array A such that:

          _a[0] = -3
          _a[1] = 1
          _a[2] = 2
          _a[3] = -2
          _a[4] = 5
          _a[5] = 6
        the function should return 60, as the product of triplet (2, 4, 5) is maximal.

        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [3..100,000];
        each element of array A is an integer within the range [−1,000..1,000].
     
     */


    public class MaxProductOfThree
    {
        private int[] _a;

        public MaxProductOfThree(int[] a)
        {
            _a = a;
        }


        public int Solution()
        {
            Array.Sort(_a);
            int maxProduct = _a[0] * _a[1] * _a[2]; ;
            
            maxProduct = maxProduct < _a[0] * _a[1] * _a[_a.Length - 1] ? _a[0] * _a[1] * _a[_a.Length - 1] : maxProduct;
           
            maxProduct = maxProduct < _a[_a.Length - 3] * _a[_a.Length - 2] * _a[_a.Length - 1] ? _a[_a.Length - 3] * _a[_a.Length - 2] * _a[_a.Length - 1] : maxProduct;

            return maxProduct;
        }
    }
}
