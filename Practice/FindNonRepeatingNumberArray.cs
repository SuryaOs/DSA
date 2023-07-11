namespace dsaproblem.Practice;

public class FindNonRepeatingNumberArray
{
    public static void FindNonRepeatingElementXOR(int[] array){
        int unique = 0;
        for (int i = 0; i<array.Length; i++){
            unique ^= array[i];
        }
        Console.WriteLine(unique);
    }
}