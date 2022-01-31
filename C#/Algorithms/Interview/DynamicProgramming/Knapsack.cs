using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.DynamicProgramming
{
    public class Knapsack
    {
        private int[] _weight;
        private int[] _value;

        public Knapsack(int[] weight, int[] value)
        {
            _weight = weight;
            _value = value;
        }

        public int Solve(int n, int c)
        {
            int result;
            if(n == 0 || c == 0)
            {
                result = 0; 
            }else if(_weight[n] > c)
            {
                result = Solve(n - 1, c);
            }else
            {
                int temp1 = Solve(n - 1, c);
                int temp2 = _value[n] + Solve(n - 1, c - _weight[n]);
                result = Math.Max(temp1, temp2);
            }
            return result;
        }
    }
}
