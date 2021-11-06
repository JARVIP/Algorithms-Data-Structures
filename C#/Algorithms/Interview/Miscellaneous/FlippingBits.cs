using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.Miscellaneous
{
   public  class FlippingBits
    {
        public long Solve(long n)
        {
            var bitString = Convert.ToString(n, 2);
            StringBuilder sb = new StringBuilder();
            int counter = 0;
            for (int i = 0; i < 32; i++)
            {
                if(bitString.Length >= 32 - i)
                {
                    sb.Append(bitString[counter] == '0' ? '1' : '0');
                    counter++;
                }
                else
                {
                    sb.Append('1');
                }
            }
            bitString = sb.ToString();
            long result = Convert.ToInt64(bitString, 2);

            return result;
        }
    }
}
