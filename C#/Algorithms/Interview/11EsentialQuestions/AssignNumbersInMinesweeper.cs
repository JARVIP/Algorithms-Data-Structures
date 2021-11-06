using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview._11EsentialQuestions
{
    public class AssignNumbersInMinesweeper
    {
        public void Print(int[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + ",");
                }
                Console.WriteLine();
            }
        }

        public int[,] Solve(int[][] bombs, int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for(int i = 0; i < bombs.Length; i++)
            {
                int[] bomb = bombs[i];

                int x = bomb[0];
                int y = bomb[1];

                matrix[x, y] = -1;

                if(x - 1 >= 0 && matrix[x - 1, y] != -1)
                {
                    matrix[x - 1, y] += 1;
                }
                if(y-1 >= 0 && matrix[x, y-1] != -1)
                {
                    matrix[x, y - 1] += 1;
                }
                if (y - 1 >= 0 && x - 1 >= 0 && matrix[x -1, y - 1] != -1)
                {
                    matrix[x - 1, y - 1] += 1;
                }
                if (y + 1 < rows && x - 1 >= 0 && matrix[x - 1, y + 1] != -1)
                {
                    matrix[x - 1, y + 1] += 1;
                }
                if (y + 1 < rows && matrix[x, y + 1] != -1)
                {
                    matrix[x, y + 1] += 1;
                }
                if (y + 1 < rows && x + 1 < cols && matrix[x + 1, y + 1] != -1)
                {
                    matrix[x + 1, y + 1] += 1;
                }
                if (x + 1 < cols && matrix[x + 1, y] != -1)
                {
                    matrix[x + 1, y] += 1;
                }
                if (y - 1 >= 0 && x + 1 < cols && matrix[x + 1, y - 1] != -1)
                {
                    matrix[x + 1, y - 1] += 1;
                }
            }

            return matrix;
        }

        public void mineSweeper(int[][] bombs, int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for(int i = 0; i < bombs.Length; i++)
            {
                int row_i = bombs[i][0];
                int col_i = bombs[i][1];
                matrix[row_i, col_i] = -1;

                for(int x = row_i - 1; x <= row_i + 1; x++)
                {
                    for(int y = col_i-1; y <= col_i + 1; y++)
                    {
                        if(0 <=x && x < rows && 0<=y && y < cols && matrix[x, y] != -1)
                        {
                            matrix[x, y]++;
                        }
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + ",");
                }
                Console.WriteLine();
            }
        }
    }
}
