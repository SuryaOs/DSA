namespace dsaproblem.Practice;

public class OccurenceCountInArray
{
    public static void OccurrenceCount(int[] array){
        Dictionary<int, int> dic = new();
        for(int i = 0; i < array.Length; i++){
            if(dic.ContainsKey(array[i])){
                dic[array[i]]++;
            }
            else{
                dic[array[i]] = 1;
            }
        }
        foreach(var i in dic){
            Console.WriteLine("{0} = {1} times", i.Key, i.Value );
        }
    }
}