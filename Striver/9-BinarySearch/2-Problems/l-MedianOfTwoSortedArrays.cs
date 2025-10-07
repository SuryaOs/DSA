namespace BinarySearch.Problems;

public class MedianOfTwoSortedArrays
{
    public static void Run()
    {
        int[] a = { 1, 3, 4, 7, 10, 13 };
        int[] b = { 2, 3, 6, 20 };
        Console.WriteLine(Naive(a, b)); // TC  O(n1 + n2); SC O(n1 + n2)
        Console.WriteLine(Medium(a, b)); // TC  O(n1 + n2)
    }
    private static int Naive(int[] a, int[] b)
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
        int ans = 0;
        int mid = (resLen / 2);
        if (resLen % 2 == 0)
        {
            ans = (res[mid] + res[mid - 1]) / 2;
        }
        else
        {
            ans = res[mid];
        }
        return ans;
    }
    public static int Medium(int[] a, int[] b)
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

        return (ind1El + ind2El) / 2;
    }
}