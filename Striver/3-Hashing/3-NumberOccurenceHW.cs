namespace dsaproblem.Striver.Hashing;

public class NumberOccurenceHW
{
    public static void print(int[] arr)
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

        foreach (var dic in hash)
        {
            Console.WriteLine(dic.Key + " " + dic.Value);
        }
    }
}