namespace dsaproblem.Striver.Arrays.Easy;

public class CheckIfArrayIsSorted
{
    public static void IsArraySorted(int[] a){
        bool isAscending = true;
        for(int i= 0; i < a.Length-1; i++)
        {
            if(a[i] > a[i+1])
            {
                isAscending = false;
                break;
            }
        }
        Console.WriteLine($"It is sorted in ascending - {isAscending}");
    }
}