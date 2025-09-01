namespace StackNQueue.Learning;

public class ImplementQueueUsingLL
{
    public static void Brute()
    {
        LLQueue ll = new();
        ll.Push(10);
        ll.Push(20);
        ll.Push(30);
        Console.WriteLine(ll.Top()); // 10
        ll.Pop(); // 10 Popped
        ll.Pop(); // 20 Pooped
        Console.WriteLine(ll.Top()); // 30
        Console.WriteLine(ll.Size()); // 1
        ll.Pop(); // 30 Popped
        // ll.Top(); // Empty Topp Exception
        ll.Push(7);
        Console.WriteLine(ll.Top() + " " + ll.Size()); // 7 1
    }
}
public class LLQueue
{
    Node front = null;
    Node end = null;
    int count = 0;
    public void Push(int value)
    {
        count++;
        var node = new Node(value);
        if (front == null) { front = end = node; }
        else
        {
            end.next = node;
            end = node;
        }
    }
    public int Pop()
    {
        if (count == 0) throw new ArgumentOutOfRangeException("Empty Stack");
        count--;
        int topElem = front.data;
        front = front.next;
        return topElem;
    }
    public int Top()
    {
        if (count == 0) throw new ArgumentNullException("Empty Top");
        return front.data;
    }
    public int Size()
    {
        return count;
    }
}