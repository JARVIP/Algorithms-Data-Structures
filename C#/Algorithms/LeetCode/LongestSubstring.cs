using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode
{
    public class LongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            int[] ch = new int[128];
            for(int i = 0; i < ch.Length; i++)
            {
                ch[i] = -1;
            }
            int count = 0;
            for (int j = 0, i = 0; j < s.Length; j++)
            {
                if (ch[127 - s[j]] >= 0)
                {
                    i = Math.Max(ch[127 - s[j]], i);
                }
                count = Math.Max(count, j - i + 1);

                ch[127 - s[j]] = j + 1;
            }
            return count;
        }
    }
}
