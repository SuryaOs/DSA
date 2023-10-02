namespace dsaproblem.Striver.Arrays.Easy;

public class SecondLargestElement
{
    // 8 10 5 7 9
    public static void FindSecondLargestElement(int[] a ){
        int max = a[0];
        int secondMax = int.MinValue;

        int min = a[0];
        int secondMin = int.MaxValue;

        for(int i = 1; i < a.Length; i++){
            if(a[i] > max)
                max = a[i];

            if(a[i] < min)
                min = a[i];

            if(a[i] < max && a[i] > secondMax)
            {
                secondMax = a[i];
            }

            if(a[i] > min && a[i] < secondMin)
            {
                secondMin = a[i];
            }
        }
        Console.WriteLine($"First Largest Element is {max}");
        Console.WriteLine($"Second Largest Element is {secondMax}");
        Console.WriteLine($"First Smallest Element is {min}");
        Console.WriteLine($"Second Smallest Element is {secondMin}");
        // Array.Sort(a);
        // Console.WriteLine($"Sorted Array: {string.Join(", ", a)}");
        // Console.WriteLine($"MaxElement with Function {a.Max()}");
    }
}