using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.String
{
    public class AlternatingCharacters
    {
        public int Solve(string s)
        {
            char prevChar = '0';
            int countDeletions = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if(prevChar.Equals(s[i]))
                {
                    countDeletions++;
                }
                prevChar = s[i];
            }
            return countDeletions;
        }
    }
}
