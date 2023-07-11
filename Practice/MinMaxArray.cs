using System;
namespace dsaproblem.Practice;

public class MinMaxArray
{
    public static void MinMax(int[] array)
    {
        Console.WriteLine("Max Value : " + array.Max());
        Console.WriteLine("Max Value : " + array.Min());
    }
    //{1, 8, 3, 7, 6, 8, 9} - n * 2 - each number 2 comparisons
    public static void MinMaxEfficient(int[] array)
    {
        int max = array[0];
        int min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }

            if (array[i] < min)
            {
                min = array[i];
            }
        }
        Console.WriteLine("Max Value : " + max);
        Console.WriteLine("Min Value : " + min);
    }

    // Pair Comparisons- Reduces number of Comparisons - for a pair - 3 comparisons thus savin 1 comparison
    // 2 6 9 3 5 8 1
    // min = 2
    // max = 6
    // i = 2
    // if a[i] > a[i + 1];
    //  ifa[i] > max; max = a[i];
    //  ifa[i + 1] < min; min = a[i + 1];
    // else
    //  if a[i + 1] > max; max = a[i + 1];
    //  if a[i] < min; min = a[i];
    public static void MinMaxYT(int[] array)
    {
        int min, max, i;
        if (array.Length % 2 == 0)
        {
            if (array[0] > array[1])
            {
                max = array[0];
                min = array[1];
            }
            else
            {
                min = array[0];
                max = array[1];
            }
            i = 2;
        }
        else
        {
            min = array[0];
            max = array[0];
            i = 1;
        }

        while (i < array.Length - 1)
        {
            if (array[i] > array[i + 1])
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            else if (array[i + 1] > max)
            {
                max = array[i + 1];
            }
            if (array[i + 1] < min)
            {
                min = array[i];
            }
        i += 2;
        }
        Console.WriteLine("Max: " + max + " Min: "+ min);
    }
}