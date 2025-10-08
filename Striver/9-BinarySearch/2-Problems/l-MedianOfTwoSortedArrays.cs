namespace BinarySearch.Problems;

public class MedianOfTwoSortedArrays
{
    public static void Run()
    {
        int[] a = { 2, 4, 6 };
        int[] b = { 1, 3 };
        Console.WriteLine(Naive(a, b)); // TC  O(n1 + n2); SC O(n1 + n2)
        Console.WriteLine(Medium(a, b)); // TC  O(n1 + n2)
        Console.WriteLine(Optimal(a, b)); // TC  O(n1 + n2)
    }
    private static double Naive(int[] a, int[] b)
    {
        int resLen = a.Length + b.Length;
        int[] res = new int[resLen];
        int aI = 0;
        int bI = 0;
        int k = 0;
        while (aI < a.Length && bI < b.Length)
        {
            if (a[aI] <= b[bI])
            {
                res[k] = a[aI];
                aI++;
            }
            else
            {
                res[k] = b[bI];
                bI++;
            }
            k++;
        }
        while (aI < a.Length)
        {
            res[k++] = a[aI++];
        }
        while (bI < b.Length)
        {
            res[k++] = b[bI++];
        }
        double ans;
        int mid = (resLen / 2);
        if (resLen % 2 == 0)
        {
            ans = (res[mid] + res[mid - 1]) / 2.0;
        }
        else
        {
            ans = res[mid];
        }
        return ans;
    }
    public static double Medium(int[] a, int[] b)
    {
        int n1 = a.Length;
        int n2 = b.Length;

        int n = n1 + n2;

        int ind2 = n / 2;
        int ind1 = ind2 - 1;

        int i = 0;
        int j = 0;

        int count = 0;

        int ind1El = -1;
        int ind2El = -1;

        while (i < n1 && j < n2)
        {
            if (a[i] <= b[j])
            {
                if (count == ind1) ind1El = a[i];
                if (count == ind2) ind2El = a[i];
                count++;
                i++;
            }
            else
            {
                if (count == ind1) ind1El = b[j];
                if (count == ind2) ind2El = b[j];
                count++;
                j++;
            }
        }
        while (i < n1)
        {
            if (count == ind1) ind1El = a[i];
            if (count == ind2) ind2El = a[i];
            count++;
            i++;
        }
        while (j < n2)
        {
            if (count == ind1) ind1El = b[j];
            if (count == ind2) ind2El = b[j];
            count++;
            j++;
        }
        if (n % 2 == 1)
            return ind2El;

        return (ind1El + ind2El) / 2.0;
    }
    private static double Optimal(int[] a, int[] b)
    {
        int n1 = a.Length;
        int n2 = b.Length;
        if (n1 > n2) return Optimal(b, a);

        int low = 0;
        int high = n1;
        int leftHalf = (n1 + n2 + 1) / 2;
        while (low <= high)
        {
            int mid1 = (low + high) / 2;
            int mid2 = leftHalf - mid1;

            int l1 = mid1 > 0 ? a[mid1 - 1] : int.MinValue;
            int l2 = mid2 > 0 ? b[mid2 - 1] : int.MinValue;
            int r1 = mid1 < n1 ? a[mid1] : int.MaxValue;
            int r2 = mid2 < n2 ? b[mid2] : int.MaxValue;

            if (l1 > r2)
            {
                high = mid1 - 1;
            }
            else if (l2 > r1)
            {
                low = mid1 + 1;
            }
            else
            {
                int x = Math.Max(l1, l2);
                int y = Math.Min(r1, r2);

                if ((n1 + n2) % 2 == 1) return x;
                return (x + y) / 2.0;
            }
        }
        return 0;
    }
}