namespace dsaproblem.Sorting;

public class SortingExtension
{
    public static void Practice()
    {
        int[] a = {13, 46, 9, 52, 20, 11};
        // SelectionSort.SortStable(a);
        InsertionSort.InsertSort(a);
        int[] bubble = {13, 46, 24, 52, 20, 9 };
        // BubbleSort.SortStriver(bubble);
    }
}