using System;
using System.Collections.Generic;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{  
     internal class Program
    {
    static void ExplorePath(int[][] matrix, int x, int y, int fieldWidth, int fieldHeight)
    {
        if (!(x >= 0 && y >= 0 && x < fieldWidth && y < fieldHeight)) return;

        if (matrix[y][x] == 0) return;

        if (matrix[y][x] == 1)
            matrix[y][x] = 0;

        ExplorePath(matrix, x + 1, y, fieldWidth, fieldHeight);
        ExplorePath(matrix, x - 1, y, fieldWidth, fieldHeight);
        ExplorePath(matrix, x, y + 1, fieldWidth, fieldHeight);
        ExplorePath(matrix, x, y - 1, fieldWidth, fieldHeight);
        ExplorePath(matrix, x + 1, y + 1, fieldWidth, fieldHeight);
        ExplorePath(matrix, x - 1, y - 1, fieldWidth, fieldHeight);
        ExplorePath(matrix, x + 1, y - 1, fieldWidth, fieldHeight);
        ExplorePath(matrix, x - 1, y + 1, fieldWidth, fieldHeight);
    }

 
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int row = input[0];
            int col = input[1];
            int[][] matrix1 = new int[row][];

            for (int i = 0; i < row; i++)
            {
                matrix1[i] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            }


            int count = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (matrix1[i][j] == 1)
                    {
                        ExplorePath(matrix1, j, i, col, row);
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}