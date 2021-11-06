using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.String
{
    /*
        Sherlock considers a string to be valid if all characters of the string appear the same number of times. It is also valid if he can remove just  character at  index in the string, and the remaining characters will occur the same number of times. Given a string , determine if it is valid. If so, return YES, otherwise return NO.

        Example

        This is a valid string because frequencies are .


        This is a valid string because we can remove one  and have  of each character in the remaining string.


        This string is not valid as we can only remove  occurrence of . That leaves character frequencies of .

        Function Description

        Complete the isValid function in the editor below.

        isValid has the following parameter(s):

        string s: a string
        Returns

        string: either YES or NO
        Input Format

        A single string .
     */
    public class SherlockandtheValidString
    {
        public string isValid(string s)
        {
            Hashtable counts = new Hashtable();
            for (int i = 0; i < s.Length; i++)
            {
                if (!counts.ContainsKey(s[i].ToString()))
                {
                    counts[s[i].ToString()] = 1;
                }
                else
                {
                    counts[s[i].ToString()] = (int)counts[s[i].ToString()] + 1;
                }
            }

            int prevValue = -1;
            int matchChange = 0;

            foreach (DictionaryEntry de in counts)
            {
                if (prevValue == -1)
                {
                    prevValue = (int)de.Value;
                }
                else
                {
                    int val = (int)de.Value;
                    if (val - prevValue != 0)
                    {
                        if (matchChange > 0)
                        {
                            return "NO";
                        }
                        if (Math.Abs(val - prevValue) == 1 || val == 1 || prevValue == 1)
                        {
                            if (Math.Abs(val - prevValue) == 1)
                            {
                                if (val < prevValue)
                                {
                                    prevValue = val;
                                }
                            }
                            else
                            {
                                if (val > prevValue)
                                {
                                    prevValue = val;
                                }
                            }

                            matchChange = 1;
                        }
                        else
                        {
                            return "NO";
                        }
                    }
                }
            }
            return "YES";
        }
    }
}
