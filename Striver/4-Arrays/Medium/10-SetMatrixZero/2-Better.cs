namespace dsaproblem.Striver.Arrays.Medium.SetMatrixZero;

public class Better
{
    // This was my intuition but I was thinking to use dictionary instead of two array of integers
    // dictionary was wrong coz we can't store I index , J index . Idk why I thought of Dict
    public static void FindSetMatrixZeroBetter(int[,] a)
    {
        int rowLength = a.GetLength(0);
        int colLength = a.GetLength(1);

        int[] rows = new int[rowLength];
        int[] cols = new int[colLength];

        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                if (a[i, j] == 0)
                {
                    rows[i] = 1;
                    cols[j] = 1;
                }
            }
        }
        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                if (rows[i] == 1 || cols[j] == 1)
                {
                    a[i, j] = 0;
                }
            }
        }
        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}