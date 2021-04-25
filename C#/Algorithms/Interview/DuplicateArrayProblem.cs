using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Algorithms
{
    public class DuplicateArrayProblem
    {
        int[] _a;

        public DuplicateArrayProblem(int[] a)
        {
            _a = a;
        }

        public void FindDuplicates()
        {
            for(int i = 0; i < _a.Length; i++)
            {
                if(_a[Math.Abs(_a[i])] >= 0)
                {
                    _a[Math.Abs(_a[i])] = -_a[Math.Abs(_a[i])];
                }
                else
                {
                    Console.WriteLine($"Repetition found: {Math.Abs(_a[i])}");
                }
            }
        }
    }
}
