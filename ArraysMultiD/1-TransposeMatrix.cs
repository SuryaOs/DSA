using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dsaproblem.ArraysMultiD
{
    public static class TransposeMatrix
    {
        // Extra Dataset
        public static void Transpose(int[,] a)
        {
            int[,] b = new int[a.GetLength(0), a.GetLength(1)];

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    b[i, j] = a[j, i];
                }
            }

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(b[i, j]);
                }
                Console.WriteLine();
            }
        }
        // InPlace Swapping
        public static void TransposeOptimal(int[,] mat)
        {
            int rowLength = mat.GetLength(0);
            int colLength = mat.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = i + 1; j < colLength; j++)
                {
                    int temp = mat[i, j];
                    mat[i, j] = mat[j, i];
                    mat[j, i] = temp;
                }
            }
            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}