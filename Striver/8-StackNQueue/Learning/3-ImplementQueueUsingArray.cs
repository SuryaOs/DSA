namespace StackNQueue.Learning;

public class ImplementQueueUsingArray
{
    public static void Brute()
    {
        ArrayQueue queue = new(10);
        // queue.Push(10);
        // queue.Push(5);
        // queue.Pop(); // 10
        // queue.Pop(); // 5
        // queue.Push(1);
        // queue.Size(); // 1
        // queue.Top(); // 1
        // queue.Pop(); // 1
        // queue.Size(); // 0
        //               // Console.WriteLine(queue.Top()); // Arugment Out Of Range Exception
        // queue.Push(100);
        // queue.Push(200);
        // Console.WriteLine(queue.Top()); // 100
        // queue.Pop(); // 100
        // Console.WriteLine(queue.Top()); // 200

        // Need to handle circularly
        queue = new(4);
        queue.Push(10);
        queue.Push(20);
        queue.Push(30);
        queue.Pop();
        queue.Push(40);
        queue.Push(50);
        Console.WriteLine(queue.Top()); // 20
        // queue.Push(100); // Size Exceeded
        queue.Pop();
        queue.Pop();
        queue.Pop();
        queue.Pop();
        queue.Pop(); // No Elements Found in the queue
    }
}
public class ArrayQueue
{
    int[] arr;
    int start = -1;
    int end = -1;
    int currSize = 0;
    int size;
    public ArrayQueue(int size)
    {
        this.size = size;
        arr = new int[size];
    }
    public void Push(int value)
    {
        if (currSize >= size) throw new ArgumentOutOfRangeException("Size Exceeded");
        if (start == -1) start += 1;

        end += 1;
        if (end == size) end = end % size;
        currSize += 1;

        arr[end] = value;
    }
    public int Pop()
    {
        if (currSize == 0) throw new ArgumentOutOfRangeException("No Elements Found In the queue");
        int popElem = arr[start];
        if (currSize == 1) start = end = -1;
        else
        {
            start += 1;
            start = start % size;
        }
        currSize -= 1;
        return popElem;
    }
    public int Top()
    {
        if (start == -1) throw new ArgumentOutOfRangeException("No Top Elements Found");
        return arr[start];
    }
    public int Size()
    {
        return currSize;
    }
}