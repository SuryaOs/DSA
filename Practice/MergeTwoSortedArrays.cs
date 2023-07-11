namespace dsaproblem.Practice;

public class MergeTwoSortedArrays
{
    public static void MergeTwoSortedArray(int[] a, int[] b) {
        int[] c = a.Concat(b).Order().ToArray();
        Console.WriteLine(string.Join(", ", c));
    }

    // https://www.youtube.com/watch?v=txh1zq9PaFw&list=PLk6CEY9XxSIDApw_RB8cowBQmzrznmpTA&index=7
    public static void MergeTwoSortedArrayYT(int[] a, int[] b) {
        for (int i = 0; i<b.Length; i++) {
            for (int j = 0; j<a.Length; j++ ) {
                if(a[j] > b[i])
                {
                    int temp = a[j];
                    a[j] = b[i];
                    b[i] = temp;
                }
                if(b[i] > b[j]) {
                    int temp = b[i];
                    b[i] = b[j];
                    b[j] = temp;
                }
            }
        }
        Console.WriteLine(string.Join(",", a));
        Console.WriteLine(string.Join(",", b));

    }
}