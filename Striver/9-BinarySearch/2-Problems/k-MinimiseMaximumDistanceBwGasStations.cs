using System.Runtime.InteropServices.Marshalling;

namespace BinarySearch.Problems;

public class MinimiseMaximumDistanceBetweenGasStations
{
    public static void Run()
    {
        int[] arr = { 1, 13, 17, 23 };
        int k = 4;
        Console.WriteLine(Naive(arr, k)); // O (K * N)
        Console.WriteLine(Medium(arr, k)); // TC : O(N LogN + K LogN) ; SC : O(N-1)
        Console.WriteLine(Optimal(arr, k));
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
    private static double Medium(int[] a, int k)
    {
        int[] howMany = new int[a.Length - 1];
        PriorityQueue<Pair, Pair> pq = new();
        for (int i = 0; i < a.Length - 1; i++) // TC : O(N Log N)
        {
            int diff = a[i + 1] - a[i];
            var segment = new Pair(diff, i);
            pq.Enqueue(segment, segment); // TC O(logn)
        }
        for (int i = 1; i <= k; i++) // TC : O(K Log N)
        {
            var kvp = pq.Dequeue();
            var index = kvp.second;
            howMany[index]++; // insert bw maximum distance

            double diff = a[index + 1] - a[index]; // divide the segment and updated the pq
            double sectionLength = diff / (howMany[index] + 1);
            var segment = new Pair(sectionLength, index);
            pq.Enqueue(segment, segment); // O(Log N)
        }
        var top = pq.Peek();
        return top.first;
    }

    private static double Optimal(int[] a, int k)
    {
        double high = -1;
        for (int i = 0; i < a.Length - 1; i++)
        {
            int diff = a[i + 1] - a[i];
            high = Math.Max(diff, high);
        }
        double low = 0;
        while (high - low > 10e-6)
        {
            double mid = (low + high) / 2.0;
            int count = NoOfStations(a, mid);
            if (count > k)
            {
                low = mid;
            }
            else
            {
                high = mid;
            }
        }
        return high;
    }
    private static int NoOfStations(int[] a, double mid)
    {
        int noOfStations = 0;
        for (int i = 0; i < a.Length - 1; i++)
        {
            int diff = a[i + 1] - a[i];
            noOfStations += (int)Math.Ceiling(diff / mid) - 1;
        }
        return noOfStations;
    }
}
public class Pair : IComparable<Pair>
{
    public double first;
    public int second;

    public Pair(double first, int second)
    {
        this.first = first;
        this.second = second;
    }

    public int CompareTo(Pair? other)
    {
        return other.first.CompareTo(first);
    }
}
