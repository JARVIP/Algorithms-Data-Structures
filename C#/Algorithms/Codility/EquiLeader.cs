using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Codility
{
    /*
        A non-empty array A consisting of N integers is given.

        The leader of this array is the value that occurs in more than half of the elements of A.

        An equi leader is an index S such that 0 ≤ S < N − 1 and two sequences A[0], A[1], ..., A[S] and A[S + 1], A[S + 2], ..., A[N − 1] have leaders of the same value.

        For example, given array A such that:

            A[0] = 4
            A[1] = 3
            A[2] = 4
            A[3] = 4
            A[4] = 4
            A[5] = 2
        we can find two equi leaders:

        0, because sequences: (4) and (3, 4, 4, 4, 2) have the same leader, whose value is 4.
        2, because sequences: (4, 3, 4) and (4, 4, 2) have the same leader, whose value is 4.
        The goal is to count the number of equi leaders.

        Write a function:

        class Solution { public int solution(int[] A); }

        that, given a non-empty array A consisting of N integers, returns the number of equi leaders.

        For example, given:

            A[0] = 4
            A[1] = 3
            A[2] = 4
            A[3] = 4
            A[4] = 4
            A[5] = 2
        the function should return 2, as explained above.

        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [1..100,000];
        each element of array A is an integer within the range [−1,000,000,000..1,000,000,000].
     
     */

    public class EquiLeader
    {
        private int[] _a;

        public EquiLeader(int[] a)
        {
            _a = a;
        }

        public int solution()
        {
            int n = _a.Length;
            int size = 0;
            Stack<int> s = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                if (size == 0)
                {
                    size += 1;
                    s.Push(_a[i]);
                }
                if (size > 0)
                {
                    if (s.Peek() != _a[i]) size--;
                    else size++;
                }
            }
            int candidate = -1;
            if (size > 0) candidate = s.Peek();
            int count = 0;
            int leader = -1;

            for (int i = 0; i < n; i++)
            {
                if (_a[i] == candidate) count += 1;
                if (count > n / 2) leader = candidate;
            }

            int equileader = 0;
            int leaders = 0;

            for (int i = 0; i < n; i++)
            {
                if (_a[i] == leader) leaders++;

                if (leaders > (i + 1) / 2 && count - leaders > (n - i - 1) / 2)
                {
                    equileader++;
                }
            }
            return equileader;
        }
    }
}
