namespace dsaproblem.Striver.Arrays.Medium.RotateMatrix;
public class RotateMatrixOptimal
{
    public static void RotateMatrix(int[,] mat)
    {
        int rowLength = mat.GetLength(0);
        int colLength = mat.GetLength(1);

        // Transpose
        for (int i = 0; i < rowLength; i++)
        {
            for (int j = i + 1; j < colLength; j++)
            {
                int temp = mat[i, j];
                mat[i, j] = mat[j, i];
                mat[j, i] = temp;
            }
        }
        // Swap 1st Col with 4th Col , 2nd cold with 3rd col => i col with n - j
        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength / 2; j++)
            {
                int temp = mat[i, j];
                mat[i, j] = mat[i, colLength - 1 - j];
                mat[i, colLength - 1] = temp;
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