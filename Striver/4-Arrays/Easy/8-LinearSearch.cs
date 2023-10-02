namespace dsaproblem.Striver.Arrays.Easy;

public class LinearSearch
{
    public static void Search(int[] a, int k) {
        for(int i = 0; i < a.Length; i++) {
            if(a[i] == k)
            Console.WriteLine($"The index is {i}");
        }
    }
}