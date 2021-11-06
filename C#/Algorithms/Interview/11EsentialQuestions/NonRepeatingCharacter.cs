using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview._11EsentialQuestions
{
    public class NonRepeatingCharacter
    {
        public char? Solve(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for(int  i = 0; i < s.Length; i++)
            {
                if(dict.ContainsKey(s[i]))
                {
                    dict[s[i]]++;
                    continue;
                }
                dict.Add(s[i], 1);
            }
            foreach(var item in dict)
            {
                if (item.Value == 1)
                    return item.Key;
            }
            return null;
        }
        
    }
}
