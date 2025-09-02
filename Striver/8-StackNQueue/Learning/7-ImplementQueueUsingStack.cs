namespace StackNQueue.Learning;

public class ImplementQueueUsingStack
{
    public static void Brute()
    {
        StackQueue q = new();
        q.EnqueueusingStack(10); // 10, 1
        q.EnqueueusingStack(20); // 10, 2
        q.EnqueueusingStack(30); // 10, 3
        q.EnqueueusingStack(40); // Top() => 10 , 4
        q.Dequeue(); // Top () => 20 , 3
        q.Dequeue(); // Top () => 30 , 2
        Console.WriteLine(q.Top());
        Console.WriteLine(q.Size());
    }
}
public class StackQueue
{
    private Stack<int> stack = new();
    private Stack<int> s2 = new();


    // my thought process
    public void EnqueueUsingArray(int val)
    {
        int[] a = new int[stack.Count];
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = stack.Pop();
        }
        stack.Push(val);
        for (int i = a.Length - 1; i >= 0; i--)
        {
            stack.Push(a[i]);
        }
    }

    // striver apprach - use 2 stack
    public void EnqueueusingStack(int val)
    {
        while (stack.Count > 0)
        {
            s2.Push(stack.Pop());
        }
        stack.Push(val);
        while (s2.Count > 0)
        {
            stack.Push(s2.Pop());
        }
    }
    public void Dequeue()
    {
        stack.Pop();
    }
    public int Top()
    {
        return stack.Peek();
    }
    public int Size()
    {
        return stack.Count;
    }

}