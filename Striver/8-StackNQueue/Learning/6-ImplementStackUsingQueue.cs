namespace StackNQueue.Learning;

public class ImplementStackUsingQueue
{
    public static void Brute()
    {
        QueueStack qs = new();
        qs.Push(10);
        qs.Push(20);
        qs.Push(30);
        qs.Pop();
        Console.WriteLine(qs.Top());
    }
}
public class QueueStack
{
    private Queue<int> queueStack = new();
    public void Push(int val)
    {
        queueStack.Enqueue(val);
        for (int i = 0; i < queueStack.Count - 1; i++)
        {
            int a = queueStack.Dequeue();
            queueStack.Enqueue(a);
        }
    }
    public void Pop()
    {
        queueStack.Dequeue();
    }
    public int Top()
    {
        return queueStack.Peek();
    }
}