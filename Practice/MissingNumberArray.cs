using System.Data.SqlTypes;

namespace dsaproblem.Practice;

public class MissingNumberArray
{
    // [1, 3, 2, 5]
    public static void MissingNumber(int[] array) {
        int n = array.Length + 1;
        int sum = n * (n + 1)/2;

        for (int i = 0; i < n -1; i++)
        {
            sum -= array[i];
        }
        Console.WriteLine(sum);
    }

    public static void MissingNumberYT(int[] array) {
        int sum = array[0];
        for (int i = 0; i<array.Length; i++)
        {
            sum += i;
            // Console.WriteLine("Sum: " + sum);
            sum -= array[i];
            // Console.WriteLine("Minus: " + Math.Abs(sum));
        }
        Console.WriteLine(Math.Abs(sum));
    }

    // {1, 3, 2, 5}
    // {1, 2, 3, 4, 5}
    // {1, 2, 3, 5}
    // {0, 0, 0, 4, 0}
    // https://www.youtube.com/watch?v=8ng3R8eeGCA

    public static void MissingSingleNumberXOR(int[] array) {
        int missing = 0;

        for (int i = 0; i < array.Length; i++)
        {
            // Console.WriteLine(array[i]);
            missing ^= array[i];
        }
        for (int i = 1; i <= array.Length+1; i++)
        {
            // Console.WriteLine(i);
            missing ^= i;
        }
        Console.WriteLine(missing);
    }
}