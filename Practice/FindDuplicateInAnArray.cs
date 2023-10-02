using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;

namespace dsaproblem.Practice;

public class FindDuplicateInAnArray
{
    public static void FindDuplicate(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
    // https://www.youtube.com/watch?v=lYxEdtR5_xQ&list=PLtQWXpf5JNGINAVFwxIL1jDQ6s2CIRExA&index=3
    // Time complexity = o(n) but space complexity also = o(n)
    // Brute force
    public static void FindDuplicateEfficient(int[] array)
    {
        HashSet<int> hashSet = new();
        for (int i = 0; i < array.Length; i++)
        {
            if (hashSet.Contains(array[i]))
            {
                Console.WriteLine(array[i]);
            }
            else
            {
                hashSet.Add(array[i]);
            }
        }
    }
    // Without Space Complexity
    // Form new Index = Abs(array[0]) - 1 = value at a[0] - -1 will be neew index
    // If the value is greater than 0, Just Negative it.
    // While Iterating if the value is already negative then it is duplicate.
    // It works if the number is from 1 to N
    public static void FindDuplicateYT(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            HashSet<int> result = new();
            int index = Math.Abs(array[i]) - 1;
            if (array[index] > 0)
            {
                array[index] = -array[index];
            }
            else
            {
                result.Add(Math.Abs(array[index] ));
            }
        }
    }
}