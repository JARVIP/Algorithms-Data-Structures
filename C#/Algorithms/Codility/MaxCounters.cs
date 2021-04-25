using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Codility
{
    public class MaxCounters
    {
        private int _n;
        private int[] _a;

        public MaxCounters(int n, int[] a)
        {
            _n = n;
            _a = a;
        }

        public int[] solution()
        {
            int[] operations = new int[_n];
            int maxCounter = 0, staticMaxCounter = 0;
            bool setMaxCounter = false;
            for (int i = 0; i < _a.Length; i++)
            {
                if (_a[i] <= _n)
                {
                    if (setMaxCounter && operations[_a[i] - 1] < staticMaxCounter)
                    {
                        operations[_a[i] - 1] = staticMaxCounter + 1;
                    }
                    else
                    {
                        operations[_a[i] - 1] += 1;
                    }

                    maxCounter = maxCounter < operations[_a[i] - 1] ? operations[_a[i] - 1] : maxCounter;
                }
                else if (_a[i] == _n + 1)
                {
                    setMaxCounter = true;
                    staticMaxCounter = maxCounter;
                }
            }
            for (int i = 0; i < _n; i++)
            {
                if (setMaxCounter)
                {
                    operations[i] = operations[i] < staticMaxCounter ? staticMaxCounter : operations[i];
                }
            }
            return operations;
        }
    }
}
