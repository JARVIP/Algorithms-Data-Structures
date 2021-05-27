using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Codility
{
    /*
        Write a function

        class Solution { public int solution(int[] A); }

        that, given an array A consisting of N integers, returns the number of distinct values in array A.

        For example, given array A consisting of six elements such that:

         A[0] = 2    A[1] = 1    A[2] = 1
         A[3] = 2    A[4] = 3    A[5] = 1
        the function should return 3, because there are 3 distinct values appearing in array A, namely 1, 2 and 3.

        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [0..100,000];
        each element of array A is an integer within the range [−1,000,000..1,000,000].
     
     */
    public class Distinct
    {
        private int[] _a;

        public Distinct(int[] a)
        {
            _a = a;
        }

        public int Solution()
        {
            if (_a.Length == 0)
                return 0;
            int minValue = _a.Min();
            int maxValue = _a.Max();
            int countDistinct = 0;

            int[] countArray = new int[maxValue - minValue + 1];


            for (int i = 0; i < _a.Length; i++)
            {
                if (countArray[_a[i] - minValue] == 0)
                {
                    countDistinct++;
                }
                countArray[_a[i] - minValue] = 1;
            }

            return countDistinct;
        }
    }
}
