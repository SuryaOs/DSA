namespace dsaproblem.Striver.Hashing;

public class FindHighestandLowestFrequency
{
    public static void Print(int[] arr)
    {
        Dictionary<int, int> hash = new();
        for (int i = 0; i < arr.Length; i++)
        {
            if (hash.ContainsKey(arr[i]))
            {
                hash[arr[i]]++;
            }
            else
            {
                hash[arr[i]] = 1;
            }
        }

        int minFreq = arr.Length, maxFreq = 0, minValue = 0, maxValue = 0;
        foreach (var dic in hash)
        {
            if (minFreq > dic.Value)
            {
                minFreq = dic.Value;
                minValue = dic.Key;
            }
            if (maxFreq < dic.Value)
            {
                maxFreq = dic.Value;
                maxValue = dic.Key;
            }
        }
        Console.WriteLine("The Frequency of " + maxValue + " is " + maxFreq);
        Console.WriteLine("The Frequency of " + minValue + " is " + minFreq);
    }

    public static void PrintBrute(int[] arr)
    {
        bool[] visited = new bool[arr.Length];
        int maxFreq = 0, minFreq = arr.Length;
        int maxEl = 0, minEl = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (visited[i])
                continue;

            int count = 1;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] == arr[i])
                {
                    count++;
                    visited[j] = true;
                }
            }
            if (maxFreq < count)
            {
                maxFreq = count;
                maxEl = arr[i];
            }
            if (minFreq > count)
            {
                minFreq = count;
                minEl = arr[i];
            }
        }
        Console.WriteLine("The Frequency of " + maxEl + " is " + maxFreq);
        Console.WriteLine("The Frequency of " + minEl + " is " + minFreq);
    }
}