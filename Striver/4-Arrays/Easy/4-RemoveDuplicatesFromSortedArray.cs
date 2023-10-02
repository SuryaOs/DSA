using System.Collections.Generic;
using System.Text;

namespace dsaproblem.Striver.Arrays.Easy;

public class RemoveDuplicatesFromSortedArray
{
    public static void RemoveDuplicates(int[] a)
    {
        HashSet<int> set = new();
        for (int i = 0; i < a.Length; i++)
        {
            set.Add(a[i]);
        }
        Console.WriteLine(string.Join(", ", set));
    }
    public static void FindDuplicate(int[] a)
    {
        HashSet<int> set = new();
        HashSet<int> dup = new();
        for (int i = 0; i < a.Length; i++)
        {
            if(!set.Add(a[i]))
            {
                dup.Add(a[i]);
            }
        }
        Console.WriteLine(string.Join(", ", set));
        Console.WriteLine(string.Join(", ", dup));
    }

    // he is not removing duplictes , returning the size of unique elements in array.
    public static void RemoveDuplicatesOptimal(int[] a)
    {
        int i = 0;
        int j = 1;

        while (j < a.Length )
        {
            if (a[i] != a[j])
            {
                i++;
                a[i] = a[j];
            }
            j++;
        }

    Console.WriteLine(i);
        // StringBuilder stringBuilder = new StringBuilder();
        // for (int k = 0; k < duplicate.Length; k++)
        // {
        //     if (k > 0)
        //         stringBuilder.Append(", ");

        //     stringBuilder.Append(duplicate[k]);
        // }

        // Console.WriteLine(stringBuilder.ToString());
    }

    public static void RemoveDuplicateStriver(int[] a)
    {
        int i = 0;
        for(int j = 1; j < a.Length; j++)
        {
            if(a[i] != a[j]){
                a[i+1] = a[j];
                i++;
            }
        }
        Console.WriteLine(string.Join(", ", a));
    }
}