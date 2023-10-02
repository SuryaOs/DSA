using System.Collections.Generic;
using System.Text;

namespace dsaproblem.Striver.Arrays.Easy;

public class UnionArray
{
    // Two Pointer
    // Compore two array values and add smaller ones
    // Add it to Hash set to avoid Duplication
    public static void Union(int[] a, int[] b)
    {
        HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < a.Length; i++)
        {
            set.Add(a[i]);
        }
        for (int i = 0; i < b.Length; i++)
        {
            set.Add(b[i]);
        }
        Console.WriteLine(string.Join(", ", set));
    }
    public static void UnionOptimal(int[] arr1, int[] arr2)
    {
        int m = arr1.Length;
        int n = arr2.Length;

        int i = 0, j = 0;
        HashSet<int> set = new HashSet<int>();

        while (i < m && j < n)
        {
            if (arr1[i] < arr2[j])
            {
                set.Add(arr1[i]);
                i++;
            }
            else if (arr2[j] < arr1[i])
            {
                set.Add(arr2[j]);
                j++;
            }
            else
            {
                set.Add(arr1[i]);
                i++;
                j++;
            }
        }

        while (i < m)
        {
            set.Add(arr1[i]);
            i++;
        }

        while (j < n)
        {
            set.Add(arr2[j]);
            j++;
        }

        Console.WriteLine(string.Join(",",set));

    }
}