using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.Array
{
   public class LuckBalance
    {
        public int Solve(int k, List<List<int>> contests)
        {
            contests = contests.OrderByDescending(x => x[0]).ToList();

            int sum = 0;
            foreach (var item in contests)
            {
                if (item[1] == 0)
                {
                    sum += item[0];
                }else if(k > 0)
                {
                    sum += item[0];
                    k--;
                }
                else
                {
                    sum -= item[0];
                } 
            }
            return sum;
        }
    }
}
