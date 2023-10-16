using dsaproblem.Striver.Recursions.Advanced;
using dsaproblem.Striver.Recursions.Basics;

namespace dsaproblem.Recursions;

public class RecursionExtension
{
    public static void Practice() {
        // PrintNameNTimes.printname(5, 1);
        //Print1ToN.print(1, 5);
        // PrintNto1.print(5);
        // SumOfNNumber.printOne();
        // FactorialOfN.print(3);
        // int[] arr = {5,4,3,2,1};
        // ReverseAnArray.Print(arr, 5);
        // Palindrome.Print("ABCDCBA");
        // Fibonacci.Print(5);

        // Advanced
        int[] a = {1, 1, 2, 3};
        // SubSequence.SubSequenceBit(a);

        // SubSequence.SubSequenceRecursive(0, a, new List<int>());
        // Console.WriteLine(SubSequenceSum.FindSubSequenceSumCount(0, a, 0, 3));
        int[] comb = {2, 3, 6, 7};
        // CombinationSum.FindCombination(comb, 7, 0, new List<int>());
        // CombinationSumTwo.Main();

        int[] SubSetSums = {3, 1, 2};
        // SubSetSum.FindSubSetSum(SubSetSums, 0, 0, new List<int>());
        // int[] SubSetSumTwos = {1, 2, 2, 2, 3, 5};
        // SubSetSumTwo.Main();
        // Permutation.FindPermutation();
        int[] permutation = {1, 2, 3};
        PermutationSwap.FindPermutation(permutation, 0);
    }
}