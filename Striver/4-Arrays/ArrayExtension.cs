using dsaproblem.Striver.Arrays.Easy;
using dsaproblem.Striver.Arrays.Hard;
using dsaproblem.Striver.Arrays.Medium;
using dsaproblem.Striver.Arrays.Medium.RotateMatrix;
using dsaproblem.Striver.Arrays.Medium.SetMatrixZero;

namespace dsaproblem.Striver.Arrays;

public class ArrayExtension
{
    public static void Practice()
    {
        int[] a = { 2, 5, 1, 3, 0 };
        int[] b = { 8, 10, 5, 7, 9 };
        int[] c = { 1, 3, 5, 5, 19 };
        int[] d = { 1, 1, 2, 2, 2, 3, 3 };
        int[] e = { 1, 2, 3, 4, 5, 6, 7 };
        int[] f = { 1, 0, 2, 3, 0, 4, 0, 1 };
        int[] g = { 1, 2, 0, 1, 0, 0, 4, 0 };
        int[] h = { 0, 0, 0, 1 };

        int[] arr1 = { 1, 1, 3, 4, 5, 7 };
        int[] arr2 = { 2, 3, 5, 6 };

        int[] miss = { 1, 2, 4, 5 };
        int[] cons = { 1, 1, 0, 1, 1, 1, 0, 1, 0 };
        int[] unique = { 4, 1, 2, 1, 2 };

        int[] i = { 2, 3, 5, 1, 9, 2, 3, 4, 1 };
        int[] i2 = { 1, 2, 3, 1, 1, 1, 1, 4, 2, 3 };
        int[] iEdgeCase = { 2, 0, 0, 3 };
        int[] i3 = { -13, 0, 6, 15, 16, 2 };
        int[] i4 = { 1, 2, 3, 4, 5 };
        int[] i5 = { 1, 2, 3, 1, 1, 1 };

        //11/29/2023
        int[] movesZeroToEnd = { 1, 0, 2, 3, 0, 4, 0, 1 };
        int[] movesZeroToEndTwo = { 1, 2, 0, 1, 0, 4, 0 };
        // LargestElementInAnArray.FindLargestBrute(b);
        // SecondLargestElement.FindSecondLargestElement(c);
        // CheckIfArrayIsSorted.IsArraySorted(c);
        // RemoveDuplicatesFromSortedArray.FindDuplicate(c);
        // RemoveDuplicatesFromSortedArray.RemoveDuplicateStriver(d);
        // LeftRotateArray.LeftRotate(a);
        // RotateArrayByKElements.RotateLeft(e, 2)
        MoveZeroesToEnd.MoveZeroesToEndOptimal(h);
        // LinearSearch.Search(a, 1);
        // UnionArray.UnionOptimal(arr1, arr2);
        // FindMissingNumber.Find(miss); 
        // MaximumConsecutivesOnes.FindConsecutiveOnes(cons);
        // FindNumberThatAppearOnce.FindUnique(unique);
        // LongestSubArrayWithSum.FindSubArrayDict(i3, 21);

        // MEDIUM
        int[] tp = { 2, 6, 5, 8, 11 };
        // TwoPairSum.FindTwoPairBetter(tp, 14);
        int[] sort012 = { 2, 0, 2, 1, 1, 0 };
        // Sort012.SortOptimal(sort012);
        int[] z = { 2, 2, 1, 1, 1, 2, 2 };
        // NumberThatOccursNBy2.FindNumberOptimal(z);
        int[] subSum = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int[] subSum2 = { 1, 2, 3 };
        int[] subSum3 = { -2, -3, 4, -1, -2, 1, 5, -3 };
        int[] subSum4 = { -1, 2, 3, -9 };

        // MaxSubArraySum.SumOptimal(subSum4); 
        int[] buyAndSell = { 7, 1, 5, 3, 6, 4 };
        int[] buyAndSell2 = { 7, 6, 4, 3, 1 };
        // StockBuyandSell.BuyAndSellOptimal(buyAndSell);
        int[] reArrange = { 1, 2, -4, -5 };
        int[] reArrange1 = { 1, 2, 3, -1, -2, -3 };
        // RearrangeArrayElementBySign.ReArrange(reArrange1);
        int[] leaders = { 10, 22, 12, 3, 0, 6 };
        // LeadersInAnArray.LeadersInAnArrayBrute(leaders);
        int[] longestConsecutiveSequence = { 100, 200, 1, 3, 2, 4 };
        int[] longestConsecutiveSequenceOne = { 102, 4, 100, 1, 101, 3, 2, 104, 1, 1 };
        // LongestConsecutiveSequence.FindLongestConsecutiveSequenceOptimal(longestConsecutiveSequenceOne);
        int[] nextPermutation = { 1, 2, 3 };
        // NextPermutation.FindNextPermutation(nextPermutation);
        int[,] setMatrixZero = { { 0, 1, 2, 0 }, { 3, 4, 5, 2 }, { 1, 3, 1, 5 } };
        int[,] setMatrixZeroOne = { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 } };
        // Brute.FindSetMatrixBrute(setMatrixZeroOne);
        // Better.FindSetMatrixZeroBetter(setMatrixZero);
        // Optimal.FindSetMatrixZeroOptimal(setMatrixZero);
        int[,] rotateMatrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int[,] rotateMatrixOne = { { 5, 1, 9, 11 }, { 2, 4, 8, 10 }, { 13, 3, 6, 7 }, { 15, 14, 12, 16 } };
        // RotateMatrixBrute.RotateMatrix(rotateMatrixOne);
        // RotateMatrixOptimal.RotateMatrix(rotateMatrixOne);
        // SpiralMatrix.PrintSpiralMatrix(rotateMatrix);
        int[] countSubArraySum = { 3, 1, 2, 4 }; // 6
        int[] countSubArraySumOne = { 1, 2, 3 }; // 3
        // CountSubArraySum.PrintCount(countSubArraySumOne, 3);

        // Hard
        // PascalTriangle.NCR(5,3);
        // int[] numberMoreThanNb3 = { 3, 2, 2, 3, 2, 4 };
        int[] numberMoreThanNb3 = { 2, 1, 1, 3, 1, 4, 5, 6 };
        // NumbersThatOccursNBy3.Brute(numberMoreThanNb3);
        // NumbersThatOccursNBy3.Optimal(numberMoreThanNb3);
        int[] threeSum = { -1, 0, 1, 2, -1, 4 };
        // -1 -1 0 1 2 4
        // ThreeSum.Brute(threeSum);
        // ThreeSum.Optimal(threeSum);
        // ThreeSum.Better(threeSum);
        int[] fourSum = { 4, 3, 3, 4, 4, 2, 1, 2, 1, 1 }; //9
        int[] fourSumOne = { 1, 0, -1, 0, -2, 2 }; //0
        // FourSum.Brute(fourSumOne, 0);
        // FourSum.Better(fourSum, 9);
        // FourSum.Optimal(fourSum, 9);
        int[] longSubArraySumZero = { 9, -3, 3, -1, 6, -5 };
        int[] longSubArraySumZeroOne = { 6, -2, 2, -8, 1, 7, 4, -10 };
        // LongestSubArraySumZeroLength.Brute(longSubArraySumZero);
        // LongestSubArraySumZeroLength.Optimal(longSubArraySumZero);
        int[] countSubArrayXorTarget = { 4, 2, 2, 6, 4 }; // 6
        // CountSubArrayXorTarget.Brute(countSubArrayXorTarget, 6);
        // CountSubArrayXorTarget.Optimal(countSubArrayXorTarget, 6);
    }
}