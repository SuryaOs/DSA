namespace dsaproblem.Striver.Hashing;

public class CharacterHashing
{
    //256 Char Max
    // a - 97 , a - a = 0
    // hash = new [ 256] , increment a[i]++ , print c[i] - works too
    public static void Print() {
        string a = "abcdabcef";
        int[] hash = new int[26];

        char[] chars= {'a', 'b', 'c', 'd', 'z' , 'e', 'f'};
        for (int i = 0; i < a.Length; i++)
        {
            int index = a[i] - 'a';
            hash[index]++;
        }

        for (int i = 0; i < chars.Length; i++)
        {
            int index = chars[i] - 'a';
            Console.WriteLine(chars[i] + " - " + hash[index]);
        }
    }
}