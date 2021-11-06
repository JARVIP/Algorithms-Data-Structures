using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview._11EsentialQuestions
{
    public class Rotating2DArray
    {
        public int [,] SolveOutOfPlace(int[,] matrix, int n)
        {
            int[,] rotated = new int[n, n];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j <n;j++)
                {
                    RotateSub(out int x, out int y, i, j, n);
                    rotated[x, y] = matrix[i, j];
                }
            }
            return rotated;
        }


        public int[,] SolveInPlace(int[,] matrix, int n)
        {
           for(int  i = 0; i < Math.Ceiling(n/2.0); i++)
            {
                for(int j = 0; j < Math.Floor(n/2.0); j++)
                {
                    int[] temp = new int[] { -1, -1, -1, -1 };
                    int x = i;
                    int y = j;
                    for(int k = 0; k < 4; k++)
                    {
                        temp[k] = matrix[x, y];
                        RotateSub(out x, out y, i, j, n);
                    }
                    for (int k = 0; k < 4; k++)
                    {
                        matrix[x, y] = temp[(k - 1) % 4];
                        RotateSub(out x, out y, i, j, n);
                    }
                }
            }
            return matrix;
        }

        void RotateSub(out int x, out int y, int i, int j,int n)
        {
            x = j;
            y = n - 1 - i;
        }
    }
}
