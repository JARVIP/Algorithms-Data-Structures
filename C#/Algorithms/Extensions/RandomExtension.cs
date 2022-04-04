using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Extensions
{
    public static class RandomExtensions
    {
        public static void Shuffle(this Random rng, int[] array)
        {
            int n = array.Length;
            for(int i = 0; i < n; i++)
            {
                int k = rng.Next(n--);
                array[i] = k;
            }
        }
    }
}
