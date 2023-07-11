using System.Data.SqlTypes;

namespace dsaproblem.Arrays;

public static class PrimeNumbers
{
    // 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37 -- Prime
    // 4, 6, 8, 9, 10, 12, 14, 15, 16, 18, 20, 21 -- Composite

    public static void PrimeNumber()
    {
      Dictionary<int, int> numbers = new();
      int[] arr = {1, 5, 6, 9, 10, 6};
      for(int i = 0; i < arr.Length; i++)
      {
        if(numbers.ContainsKey(arr[i]))
        numbers[arr[i]]++;
        else
        numbers[arr[i]] = 1;
      }

      foreach(var n in numbers)
      {
      Console.WriteLine($"Key: {n.Key} - Value: {n.Value}");
      }
    }
}
