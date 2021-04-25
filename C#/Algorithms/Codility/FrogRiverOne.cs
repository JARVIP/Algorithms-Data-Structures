using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Codility
{
    public class FrogRiverOne
    {
        private int _x;
        private int[] _a;

        public FrogRiverOne(int x, int[] a)
        {
            _x = x;
            _a = a;
        }

        public int solution()
        {
            int[] arr = new int[_x];
            int jump = 0;
            for (int i = 0; i < _a.Length; i++)
            {
                if (_a[i] <= _x)
                {
                    if (arr[_a[i] - 1] != 1)
                    {
                        jump++;
                        arr[_a[i] - 1] = 1;
                    }
                    if (jump == _x)
                        return i;
                }
            }
            return -1;
        }
    }
}
