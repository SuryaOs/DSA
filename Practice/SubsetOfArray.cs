namespace dsaproblem.Practice;

public class SubsetOfArray
{
    public static void Subset(int[] a, int[] b)
    {
		int aIndex = a.Length;
		int bIndex = b.Length;
		int count = 0;
		for(int i = 0; i < aIndex; i++) {
			for(int j=0; j <bIndex; j++) {
				if(a[i] == b[j])
				   {
					   count++;
				   }
			}
		}
        Console.WriteLine(count == bIndex);
    }

    public static void SubsetEfficient(int[] a, int[] b)
    {
        int bIndex = b.Length;
        HashSet<int> set = new(a);
        for(int i=0; i< bIndex; i++)
        {
            if(!set.Contains(b[i]))
            Console.WriteLine(false);
        }
    }
}