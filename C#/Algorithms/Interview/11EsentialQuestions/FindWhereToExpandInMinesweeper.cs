using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview._11EsentialQuestions
{
    public class FindWhereToExpandInMinesweeper
    {
        public int[,] Solve(int[,] matrix, int rows, int cols, int i, int j)
        {
            Queue<int[]> q = new Queue<int[]>();    
            q.Enqueue(new int[] { i,j});
            if(matrix[i,j] == 0)
            {
                while(q.Count() > 0)
                {
                    int[] exp = q.Dequeue();
                    int row_i = exp[0];
                    int col_i = exp[1];
                    for (int x = row_i - 1; x <= row_i + 1; x++)
                    {
                        for (int y = col_i - 1; y <= col_i + 1; y++)
                        {
                            if (0 <= x && x < rows && 0 <= y && y < cols && matrix[x, y] == 0)
                            {
                                q.Enqueue(new int[] { x, y });
                                matrix[x, y] = -2;
                            }
                        }
                    }
                }
            }
            return matrix;
        }
    }
}
