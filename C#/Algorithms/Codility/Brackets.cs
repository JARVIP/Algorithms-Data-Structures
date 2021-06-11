using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Codility
{
    /*
        A string S consisting of N characters is considered to be properly nested if any of the following conditions is true:

        S is empty;
        S has the form "(U)" or "[U]" or "{U}" where U is a properly nested string;
        S has the form "VW" where V and W are properly nested strings.
        For example, the string "{[()()]}" is properly nested but "([)()]" is not.

        Write a function:

        class Solution { public int solution(string S); }

        that, given a string S consisting of N characters, returns 1 if S is properly nested and 0 otherwise.

        For example, given S = "{[()()]}", the function should return 1 and given S = "([)()]", the function should return 0, as explained above.

        Write an efficient algorithm for the following assumptions:

        N is an integer within the range [0..200,000];
        string S consists only of the following characters: "(", "{", "[", "]", "}" and/or ")".
     */
    public class Brackets
    {
        private string _s;

        public Brackets(string s)
        {
            _s = s;
        }

        char OpositeCharacter(char a)
        {
            switch (a)
            {
                case '(':
                    return ')';
                case ')':
                    return '(';
                case '[':
                    return ']';
                case '{':
                    return '}';
                case ']':
                    return '[';
                default:
                    return '{';
            }
        }

        bool RightOne(char a)
        {
            if (a == ')' || a == ']' || a == '}')
            {
                return true;
            }
            return false;
        }

        public int solution()
        {

            if (_s.Length == 0)
                return 1;
            if (_s.Length == 1)
                return 0;
            Stack<char> stack = new Stack<char>();
            stack.Push(_s[0]);
            for (int i = 1; i < _s.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(_s[i]);
                    continue;
                }
                if (RightOne(_s[i]) && _s[i].Equals(OpositeCharacter(stack.Peek())))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(_s[i]);
                }
            }
            return stack.Count > 0 ? 0 : 1;
        }
    }
}
