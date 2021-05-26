using System;

namespace Interview.Algorithms
{
    public class AnagramProblem
    {
        string _s1;
        string _s2;

        public AnagramProblem(string s1, string s2)
        {
            _s1 = s1;
            _s2 = s2;
        }
        
        public bool IsAnagram()
        {
            if(_s1.Length != _s2.Length)
            {
                return false;
            }
            char[] s1_l = _s1.ToCharArray();
            char[] s2_l = _s2.ToCharArray();
            Array.Sort(s2_l);
            Array.Sort(s1_l);

            for(int i = 0; i < s1_l.Length; i++)
            {
                if (s1_l[i] != s2_l[i])
                    return false;
            }
            return true;
        }
    }
}
