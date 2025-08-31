using System.Collections;

namespace StackNQueue.Learning;

public class ImplementStackUsingList
{
    public static void Brute()
    {
        ListStack<int> listStack = new();
        listStack.Push(10);
        listStack.Push(5);
        foreach (var s in listStack)
        {
            Console.Write(s + " ");
        }
        Console.WriteLine(listStack.Top());
        Console.WriteLine(listStack.Pop());
        Console.WriteLine(listStack.Top());
        listStack.Pop();
        listStack.Pop();
        Console.WriteLine(listStack.IsEmpty());
    }
}
public class ListStack<T> : IEnumerable<T>
{
    private List<T> list;
    public ListStack()
    {
        list = new List<T>();
    }
    public void Push(T value)
    {
        list.Add(value);
    }
    public T? Top()
    {
        if (list.Count < 0) return default;
        return list[list.Count - 1];
    }
    public T? Pop()
    {
        int index = list.Count - 1;
        if (index < 0) return default;
        T lastValue = list[index];
        list.RemoveAt(index);
        return lastValue;
    }
    public bool IsEmpty()
    {
        return list.Count == 0;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = list.Count - 1; i >= 0; i--)
        {
            yield return list[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}