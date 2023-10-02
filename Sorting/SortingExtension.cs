namespace dsaproblem.Sorting;

public class SortingExtension
{
    public static void Practice()
    {
        int[] a = {13, 46, 9, 52, 20, 11};
        // SelectionSort.SortStable(a);
        // InsertionSort.InsertSort(a);
        int[] bubble = {13, 46, 24, 52, 20, 9 };
        BubbleSort.SortLatest(a);
        // MergeSorting.ms(a, 0, 5);
        // Test(a);
        // QuickSorting.QuickSort(a, 0, 5);
    }
    // static void Test(int[] a){
    //     for(int i = 0; i < a.Length-1; i++) {
    //         for(int j = 0; j < a.Length-1-i; j++) {
    //             if(a[j] > a[j+1] )
    //             {
    //                 int temp = a[j+1];
    //                 a[j + 1] = a[j];
    //                 a[j] = temp;
    //             }
    //         }
    //     }
    //                 Console.WriteLine(string.Join(", ", a));
    // }
}