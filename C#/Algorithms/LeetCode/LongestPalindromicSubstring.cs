using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCode
{
    public class LongestPalindromicSubstring
    {
        public string Solve(string s)
        {
            string res = "";
            int resLen = 0;

            for(int i = 0; i < s.Length; i++)
            {
                // odd length 
                int r = i, l = i;
                while(l >= 0 && r < s.Length && s[l] == s[r])
                {
                    if(r - l + 1 > resLen)
                    {
                        res = s.Substring(l, r -l  +1 );
                        resLen = r - l + 1;
                    }
                    l--;
                    r++;
                }

                // even length
                l = i; r = i + 1;
                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    if (r - l + 1 > resLen)
                    {
                        res = s.Substring(l, r - l + 1);
                        resLen = r - l + 1;
                    }
                    l--;
                    r++;
                }
            }

            return res;
        }
    }
}
