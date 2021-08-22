using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.String
{
    /*
     Reduce a string of lowercase characters in range ascii[‘a’..’z’]by doing a series of operations. In each operation, select a pair of adjacent letters that match, and delete them.

Delete as many characters as possible using this method and return the resulting string. If the final string is empty, return Empty String

Example.


aab shortens to b in one operation: remove the adjacent a characters.


Remove the two 'b' characters leaving 'aa'. Remove the two 'a' characters to leave ''. Return 'Empty String'.

Function Description

Complete the superReducedString function in the editor below.

superReducedString has the following parameter(s):

string s: a string to reduce*/
    public class SuperReducedString
    {

        public string superReducedString(string s)
        {
            int startIndex = 1;
            while (startIndex < s.Length)
            {
                if (s[startIndex] == s[startIndex - 1])
                {
                    s = s.Remove(startIndex - 1, 2);
                    startIndex = 1;
                }
                else
                {
                    startIndex++;
                }
            }

            if (string.IsNullOrEmpty(s))
            {
                return "Empty String";
            }
            return s;
        }
    }
}
