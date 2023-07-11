namespace dsaproblem.Arrays;

public static class MultiplesOfNumber
{
    public static void MultiplesOfN()
    {
        int[] array = new int[10];
        int mutliples = 5;
        int index = 0;
        for (int i = mutliples; i <= 50; i=i+mutliples)
        {
            array[index] = i;
            index++;
        }
        Console.WriteLine(string.Join(",", array));
    }
}