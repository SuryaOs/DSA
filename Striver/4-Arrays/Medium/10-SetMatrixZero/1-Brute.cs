namespace dsaproblem.Striver.Arrays.Medium;

public class Brute
{
    public static void FindSetMatrixBrute(int[,] a)
    {
        int rowLength = a.GetLength(0);
        int colLength = a.GetLength(1);
        Console.WriteLine($"RowLength is {rowLength} and ColumnLength is {colLength}");
        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                if (a[i, j] == 0)
                {
                    SetRowMinusOne(a, i, colLength);
                    SetColumnMinusOne(a, j, rowLength);
                }
            }
        }
        SetMinusOneToZero(a, rowLength, colLength);
        PrintResult(a, rowLength, colLength);
    }
    public static void SetRowMinusOne(int[,] a, int i, int colLength)
    {
        for (int j = 0; j < colLength; j++)
        {
            if (a[i, j] != 0)
            {
                a[i, j] = -1;
            }
        }
    }
    public static void SetColumnMinusOne(int[,] a, int i, int rowLength)
    {
        for (int j = 0; j < rowLength; j++)
        {
            if (a[j, i] != 0)
            {
                a[j, i] = -1;
            }
        }
    }
    public static void SetMinusOneToZero(int[,] a, int rowLength, int colLength)
    {
        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                if (a[i, j] == -1)
                    a[i, j] = 0;
            }
        }
    }
    public static void PrintResult(int[,] a, int rowLength, int colLength)
    {
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