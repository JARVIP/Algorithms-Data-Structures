using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview._11EsentialQuestions
{
    public class OneAwayStrings
    {
        public bool IsOneAwaySameLength(string s1, string s2)
        {
            int countDiff = 0;
            for(int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    countDiff += 1;
                    if(countDiff > 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        public bool IsOneAwayDiffLength(string s1, string s2)
        {
            int i = 0;
            int countDiff = 0;
            while(i < s2.Length)
            {
                if (s1[i + countDiff] == s2[i])
                    i += 1;
                else
                {
                    countDiff++;
                    if (countDiff > 1)
                        return false;
                }
            }
            return true;
        }

        public bool IsOneAway(string s1, string s2)
        {
            if(s1.Length - s2.Length >= 2 || s2.Length - s1.Length >= 2)
            {
                return false;
            }else if(s1.Length == s2.Length)
            {
                return IsOneAwaySameLength(s1, s2);
            }
            else if(s1.Length > s2.Length)
            {
                return IsOneAwayDiffLength(s1, s2);
            }
            else
            {
                return IsOneAwayDiffLength(s2,s1);
            }

            return true;
        }
    }
}
