namespace StackNQueue.Learning;

public class ImplementStackUsingArray
{
    public static void Brute()
    {
        ArrayStack stack = new(10);
        stack.Push(10);
        stack.Push(5);
        stack.Pop();
    }
}
public class ArrayStack
{
    int[] arr;
    int top = -1;
    public ArrayStack(int size)
    {
        arr = new int[size];
    }
    public void Push(int value)
    {
        top++;
        arr[top] = value;
    }
    public int Pop()
    {
        int popElem = arr[top];
        top--;
        return popElem;
    }
    public int Top()
    {
        return arr[top];
    }
    public int Size()
    {
        return top + 1;
    }
}