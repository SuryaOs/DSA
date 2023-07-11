namespace dsaproblem.Practice;

public class MissingTwoNumberArray
{
    // {1,2,4,6}
    // totalSum = 21
    // actualSum = 13
    // difference = 8
    // midPoint = 4
    // midSum = 10
    // number 1 = n * n +1 / 2
    // number 2 = diff - num1;
    public static void MissingTwoNumbers(int[] array) {
        int n = array.Length + 2;
        int totalSum = n * (n + 1)/2;
        int actualSum = 0;

        for (int i = 0; i < n -2; i++)
        {
            actualSum += array[i];
        }

        int difference = totalSum - actualSum; //single missing number

        int midPoint = difference / 2;
        int midTotalSum = midPoint * (midPoint + 1)/2;

        // int missingNumber1;
        for (int i = 0; i<array.Length; i++)
        {
            if(array[i] <= midPoint)
            {
                midTotalSum -= array[i];
            }
        }
        Console.WriteLine("MissingNumberOne " + midTotalSum);

        // int missingNumber2;
        Console.WriteLine("MissingNumberTwo " + (difference-midTotalSum));

    }
}