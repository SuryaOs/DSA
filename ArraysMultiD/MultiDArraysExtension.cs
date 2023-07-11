namespace dsaproblem.ArraysMultiD;

public static class MultiDArraysExtension
{
    public static void Practice() {
        int[,] a = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        // TransposeMatrix.Transpose(a);
        // SumMatrix.Sum(a, a);
        // SumMatrix.SumRowAndColumn(a);
        SprialMatrix.Sprial();
 }
}