namespace dsaproblem.Practice;

public static class PracticeExtension
{
    public static void Practice() {
        int[] array = {1, 4, 5, 6, 7, 8, 9};
        int[] missing = {1, 3, 2, 5, 4, 7};
        int[] missingTwo = {1,2,4,6};
        int[] pair = {1, 2, 3, 4, 5};
        int[] pair2 = {1, 1, 1, 1};
        int[] duplicates = { 23 , 21 , 24 , 27 , 22 , 27 , 26 , 25 };
        int[] nonRepeat = {1, 1, 3, 2, 2};
        int[] merge1 = {1, 4, 8, 9};
        int[] merge2 = {2, 3, 6, 7};
        int[] subset1 = {11,1,13,21,3,7};
        int[] subset2 = {11,7,1,3};
        //ReverseAnArray.ReverseArrayGPT(array);
        // MinMaxArray.MinMaxYT(array);
        // MissingNumberArray.MissingNumberYT(missing);
        // MissingNumberArray.MissingSingleNumberXOR(missing);
        // MissingTwoNumberArray.MissingTwoNumbers(missingTwo);
        // CountPairsWithSumArray.CountPairsWithSumDict(pair2, 2);
        // CountPairsWithSumArray.IndexPairsWithSumArray(pair, 7);
        // FindNonRepeatingNumberArray.FindNonRepeatingElementXOR(nonRepeat);
        // MergeTwoSortedArrays.MergeTwoSortedArrayYT(merge1, merge2);
        // OccurenceCountInArray.OccurrenceCount(nonRepeat);
        SubsetOfArray.Subset(subset1, subset2);
    }
}