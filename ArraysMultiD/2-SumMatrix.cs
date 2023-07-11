namespace dsaproblem.ArraysMultiD;

public static class SumMatrix
{
    //0 1 = 1 5 = 00+01 10+11
    //2 3 = 2 4 = 00+10 01+11
    public static void Sum(int[,] a, int[,] b) {

        int[,] sum = new int[a.GetLength(0), a.GetLength(1)];
        for (int i = 0; i < a.GetLength(0); i++) {
            for (int j = 0; j < a.GetLength(1); j++) {
                Console.Write(a[i,j] + b[i,j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    public static void SumRowAndColumn(int[,] a)
    {
        int rowLength = a.GetLength(0);
        int columnLength = a.GetLength(1);
        int[] rowSum = new int[rowLength];
        for(int i = 0; i<rowLength; i++)
        {
            int sum = 0;
            for(int j =0; j<columnLength; j++)
            {
               sum+= a[i,j];
            }
            rowSum[i] = sum;
            Console.WriteLine(rowSum[i]);
        }
    }
}