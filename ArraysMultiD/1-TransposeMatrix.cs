using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dsaproblem.ArraysMultiD
{
    public static class TransposeMatrix
    {
        public static void Transpose(int [,] a)
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
    }
}