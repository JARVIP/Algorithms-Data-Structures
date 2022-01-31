using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.GG.DynamicProgramming
{
    internal class LongestCommonSubsequence
    {

        internal int SolveRecursion(string a, string b, int m, int n)
        {
            if (m == 0 || n == 0)
                return 0;
            if(a[m - 1] == b[n - 1])
            {
                return 1 + SolveRecursion(a, b, m - 1, n - 1);
            }
            else
            {
                return Math.Max(SolveRecursion(a, b, m - 1,n), SolveRecursion(a,b,m, n-1));
            }
        }


        internal int SolveUsingTabulation(char[] X, char[] Y, int m, int n)
        {
            int[,] L = new int[m + 1, n + 1];

            /* Following steps build L[m+1][n+1]
            in bottom up fashion. Note
            that L[i][j] contains length of
            LCS of X[0..i-1] and Y[0..j-1] */
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        L[i, j] = 0;
                    else if (X[i - 1] == Y[j - 1])
                        L[i, j] = L[i - 1, j - 1] + 1;
                    else
                        L[i, j] = Math.Max(L[i - 1, j], L[i, j - 1]);
                }
            }
            return L[m, n];
        }



    }
}
