namespace dsaproblem.Practice;

public static class ReverseAnArray
{
    public static void ReverseArray(int[] array){
        Array.Reverse(array);
        foreach(int i in array)
            Console.WriteLine(i);
    }

    public static void ReverseArrayEfficient(int[] array){
        for(int i = array.Length-1; i >0; i--)
		{
			Console.Write(array[i] + ", ");
		}
    }

    public static void ReverseArrayGPT(int[] array){
        int left = 0;
        int right = array.Length-1;

        while(left < right){
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;

            left++;
            right--;
        }

        // for(int i = 0; i < array.Length-1; i++)
        // {
        //     Console.Write(array[i] + ", ");
        // }
        Console.Write(string.Join(",", array));
    }
}