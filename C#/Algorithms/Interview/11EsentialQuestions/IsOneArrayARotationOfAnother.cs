using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview._11EsentialQuestions
{
    public class IsOneArrayARotationOfAnother
    {
        public bool Solve(int[] a, int[] b)
        {
            if (a.Length != b.Length)
                return false;

            int key = a[0];
            int key_i = -1;

            for(int i = 0; i < b.Length; i++)
            {
                if(b[i] == key)
                {
                    key_i = i;
                    break;
                }
            }

            if (key_i == -1)
                return false;

            for(int i = 0; i < a.Length; i++)
            {
                int j = (key_i + i) % a.Length;
                if (a[i] != b[j])
                    return false;
            }
            return true;
        }
    }
}
