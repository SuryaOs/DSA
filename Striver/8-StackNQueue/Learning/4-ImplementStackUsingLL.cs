namespace StackNQueue.Learning;

public class ImplementStackUsingLL
{
    public static void Brute()
    {
        LLStack ll = new();
        ll.Push(10);
        ll.Push(20);
        ll.Push(30);
        Console.WriteLine(ll.Top()); // 30
        ll.Pop(); // 30 Popped
        ll.Pop(); // 20 Pooped
        Console.WriteLine(ll.Top()); // 10
        Console.WriteLine(ll.Size()); // 1
        ll.Pop(); // 10 Popped
                  // ll.Top(); // Empty top Exception
        ll.Push(7);
        Console.WriteLine(ll.Top() + " " + ll.Size()); // 7 1
    }
}
public class LLStack
{
    Node top = null;
    int count = 0;
    public void Push(int value)
    {
        count++;
        top = new(value, top);
    }
    public int Pop()
    {
        if (count == 0) throw new ArgumentOutOfRangeException("Empty Stack");
        count--;
        int topElem = top.data;
        top = top.next;
        return topElem;
    }
    public int Top()
    {
        if (count == 0) throw new ArgumentNullException("Empty Top");
        return top.data;
    }
    public int Size()
    {
        return count;
    }
}
public class Node
{
    public int data;
    public Node next;
    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
    public Node(int data, Node next)
    {
        this.data = data;
        this.next = next;
    }
}