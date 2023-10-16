namespace dsaproblem.Striver.Recursions.Advanced;

public class PermutationSwap
{
    // Easier than Permutation One - Coz in One we need to carry one
    public static void FindPermutation(int[] a, int ind)
    {
        if (ind == a.Length)
        {
            // You can add it to List of integer
            // You can add the list of integer to another list
            Console.WriteLine(string.Join(", ", a));
            return;
        }

        for (int i = ind; i < a.Length; i++)
        {
            Swap(a, i, ind);
            FindPermutation(a, ind + 1);
            Swap(a, ind, i);
        }
    }
    public static void Swap(int[] a, int ind, int i)
    {
        int temp = a[ind];
        a[ind] = a[i];
        a[i] = temp;
    }
}