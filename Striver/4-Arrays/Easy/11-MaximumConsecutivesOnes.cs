namespace dsaproblem.Striver.Arrays.Easy
{
    public class MaximumConsecutivesOnes
    {
        // Two Variables (not pointers) is Optimal
        // I though of using adding the count in Hashset and getting the max
        public static void FindConsecutiveOnes(int[] a)
        {
            int count = 0;
            int max_count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 1) count++;
                if (a[i] == 0 || i == a.Length - 1)
                {
                    if(count > max_count)
                    max_count = count;
                    count = 0;
                }
            }
            Console.WriteLine(max_count);
        }
    }
}