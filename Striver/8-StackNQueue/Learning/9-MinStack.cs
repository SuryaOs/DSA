namespace StackNQueue;

public class Minstack
{
    public static void Brute()
    {
        // MStack ms = new(); // TC O(N) SC O(2 * N)
        Min ms = new();
        ms.Push(12);
        ms.Top();       // 12
        ms.GetMin(); // 12
        ms.Push(15);
        ms.Top(); // 15
        ms.GetMin(); // 12
        ms.Push(10);
        ms.GetMin(); // 10
        ms.Top();    // 10
        ms.Pop();
        ms.GetMin(); // 12
        ms.Top(); // 15
    }
}
public class Min
{
    private Stack<int> stack = new();
    int min = int.MaxValue;
    public void Push(int val)
    {
        if (stack.Count == 0)
        {
            stack.Push(val);
            min = Math.Min(val, min);
        }
        else
        {
            if (val < min)
            {
                int prevMin = min;
                min = val;
                val = 2 * val - prevMin;
            }
        }
        stack.Push(val);
    }
    public void Pop()
    {
        min = 2 * min - stack.Pop();
    }
    public int GetMin()
    {
        Console.WriteLine(min);
        return min;
    }
    public void Top()
    {
        int res = -1;
        int top = stack.Peek();
        if (top < min) res = min;
        else res = top;
        Console.WriteLine(res);
    }
}
public class MStack
{
    Stack<KeyValuePair<int, int>> stack = new();
    public void Push(int val)
    {
        if (stack.Count == 0) stack.Push(new(val, val));
        else
        {
            var kvp = stack.Peek();
            int min = Math.Min(val, kvp.Value);
            stack.Push(new(val, min));
        }
    }
    public int Pop()
    {
        return stack.Pop().Key;
    }
    public int Top()
    {
        Console.WriteLine(stack.Peek().Key);
        return stack.Peek().Key;
    }
    public int GetMin()
    {
        Console.WriteLine(stack.Peek().Value);
        return stack.Peek().Value;
    }
}