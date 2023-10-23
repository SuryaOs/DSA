namespace dsaproblem.Striver.Arrays.Medium.SetMatrixZero;

public class Optimal
{
    public static void FindSetMatrixZeroOptimal(int[,] mat)
    {
        // 2, 1 == 0 . a[2, 0] Row a[0 ,  1] Col
        int rowLength = mat.GetLength(0); // a[i, 0]
        int colLength = mat.GetLength(1); // a[0, j]
        int c0 = 1;

        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                if (mat[i, j] == 0)
                {
                    mat[i, 0] = 0;
                    if (j == 0)
                        c0 = 0;
                    else
                        mat[0, j] = 0;
                }
            }
        }
        for (int i = 1; i < rowLength; i++)
        {
            for (int j = 1; j < colLength; j++)
            {
                if (mat[i, 0] == 0 || mat[0, j] == 0)
                {
                    mat[i, j] = 0;
                }
            }
        }

        if (mat[0, 0] == 0)
        {
            for (int j = 1; j < colLength; j++)
            {
                mat[0, j] = 0;
            }
        }
        if (c0 == 0)
        {
            for (int j = 1; j < rowLength; j++)
            {
                mat[j, 0] = 0;
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