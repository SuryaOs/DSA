namespace dsaproblem.Striver.Arrays.Medium.RotateMatrix;

public class RotateMatrixBrute
{
    public static void RotateMatrix(int[,] mat)
    {
        int rowLength = mat.GetLength(0);
        int colLength = mat.GetLength(1);
        int[,] newMat = new int[rowLength, colLength];

        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                newMat[j, rowLength - 1 - i] = mat[i, j];
            }
        }
        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                Console.Write(newMat[i, j] + " ");
            }
            Console.WriteLine();
        }

    }
}