namespace ReviseExtension.Strings;

public class SumOfBeautyOfSubstrings
{
    public static void Brute()
    {
        // string a = "xyx";
        string a = "aabcbaa";
        // for (int i = 0; i < a.Length; i++)
        // {
        //     for (int j = i; j < a.Length; j++)
        //     {
        //         string s = "";
        //         for (int k = i; k <= j; k++)
        //         {
        //             s += a[k];
        //         }
        //         Console.WriteLine(s);
        //     }
        // }
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            int[] hash = new int[26];
            string s = "";
            for (int j = i; j < a.Length; j++)
            {
                s += a[j];
                hash[a[j] - 'a']++;
                sum += CheckMagic(hash, s);
            }
        }
        Console.WriteLine(sum);
    }
    private static int CheckMagic(int[] hash, string abc)
    {
        // Console.WriteLine(abc);
        int min = int.MaxValue;
        int max = int.MinValue;
        for (int i = 0; i < abc.Length; i++)
        {
            min = Math.Min(hash[abc[i] - 'a'], min);
            max = Math.Max(hash[abc[i] - 'a'], max);
        }
        return max - min;
    }
}