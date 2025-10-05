namespace BinarySearch.Problems;

public class MinimiseMaximumDistanceBetweenGasStations
{
    public static void Run()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int k = 4;
        Console.WriteLine(Naive(arr, k)); // O (K * N)
    }
    private static double Naive(int[] a, int k)
    {
        int[] howManySection = new int[a.Length - 1];

        for (int gasStations = 1; gasStations <= k; gasStations++)
        {
            double maxVal = -1;
            int maxIndex = -1;

            for (int j = 0; j < a.Length - 1; j++)
            {
                double diff = a[j + 1] - a[j];
                double sectionLength = diff / (howManySection[j] + 1);
                if (maxVal < sectionLength)
                {
                    maxVal = sectionLength;
                    maxIndex = j;
                }
            }

            howManySection[maxIndex]++;
        }

        double maxAns = -1;
        for (int i = 0; i < a.Length - 1; i++)
        {
            double diff = a[i + 1] - a[i];
            double sectionLength = diff / (howManySection[i] + 1);
            maxAns = Math.Max(maxAns, sectionLength);
        }
        return maxAns;
    }
}
