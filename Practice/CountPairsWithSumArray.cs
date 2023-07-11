using System.Collections;

namespace dsaproblem.Practice;

public class CountPairsWithSumArray
{
    public static void CountPairsWithSum(int[] array, int sum)
    {
        //He is saying this is not good solution o(N^2)
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] + array[j] == sum)
                {
                    Console.WriteLine("Summa " + i + " " + j);
                    count++;
                }
            }
        }
        Console.WriteLine(count);
    }

    // arr = {1, 5, 7, 1}
    // sum = 6
    // count = b = ?
    // a = arr[0]
    // you are checking a + b = sum
    // use unordered<int, int> Or Dictionary<int (key : 1, 3, 5, 7), int (count of key)>
    // b = sum - a;
    // check if B exists in Dictionary, if yes, count = count + dict[B]
    // if a exists in dictionary, increment its count, else assign 1 to it.
    // Push arr[i] to dictionary
    public static void CountPairsWithSumGPT(int[] array, int sum)
    {
        //Not Correct
        HashSet<int> numSet = new HashSet<int>();

        for (int i = 0; i < array.Length; i++)
        {
            int complement = sum - array[i];

            if (numSet.Contains(complement))
            {
                Console.WriteLine("Pair found at indices: " + Array.IndexOf(array, complement) + ", " + i);
            }

            numSet.Add(array[i]);
        }
    }

    //1, 1, 1, 1
    //2
    public static void CountPairsWithSumDict(int[] array, int sum)
    {
        int count = 0;
        Dictionary<int, int> numSet = new();
        for (int i = 0; i < array.Length; i++)
        {
            int complement = sum - array[i];
            if (numSet.ContainsKey(complement))
            {
                // Console.WriteLine("Complement " + complement);
                count += numSet[complement];
            }

            if (numSet.ContainsKey(array[i]))
            {
                // Console.WriteLine("if arrayy[i] " + array[i]);
                numSet[array[i]]++;
            }
            else
            {
               // Console.WriteLine(" else arrayy[i] " + array[i]);
                numSet[array[i]] = 1;
            }
        }
        Console.WriteLine(count);
    }

    // arr = {1, 5, 7, 1}
    // complement = sum - array[i];
    // if(complement) exists => cwl(array[complement], array[i])
    // it won't work for arrays with duplicate numbers
    public static void IndexPairsWithSumArray(int[] array, int sum){
        ArrayList numSet = new();
        int complement = 0;
        for(int i = 0; i < array.Length; i++)
        {
            complement = sum - array[i];
            // Console.WriteLine(sum);
            // Console.WriteLine(complement);
            if(numSet.Contains(complement))
            {
                Console.WriteLine("IndexA : " + numSet.IndexOf(complement) + " IndexB : " + i);
            }
            numSet.Add(array[i]);
        }
    }

    public static void IndexPairsAmar(int [] array, int target)
    {
        int n = array.Length;
        if(n < 2)
        return;

        int left = 0, right = 1;
        int sum = 0;
        while(left < n && right < n)
        {
            sum = array[left] + array[right];
            if(sum < target)
            {
                if(right != n-1)
                {
                    right++;
                }
                else
                {
                    left++;
                }
            }

        }

    }
}