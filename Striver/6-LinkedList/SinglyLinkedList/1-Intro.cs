namespace dsaproblem.Striver.LinkedList;

public class Intro
{
    public static void Brute()
    {
        Node head = new Node(5);
        // Console.WriteLine(head.data + " " + head.next);
        int[] arr = { 1, 2, 3, 4 };
        Node x = ArrayToLL(arr);
        // Print(x);
        // int length = LengthOfLL(x);
        bool exists = CheckIfPresent(x, 2);
        Console.WriteLine(exists);
    }

    public static Node ArrayToLL(int[] arr)
    {
        Node head = new Node(arr[0]);
        Node mover = head;
        for (int i = 1; i < arr.Length; i++)
        {
            Node temp = new Node(arr[i]);
            mover.next = temp;
            mover = temp;
        }
        return head;
    }
    public static int LengthOfLL(Node head)
    {
        Node temp = head;
        int count = 0;
        while (temp != null)
        {
            count++;
            temp = temp.next;
        }
        return count;
    }
    public static void Print(Node head)
    {
        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.data);
            temp = temp.next;
        }
    }
    public static bool CheckIfPresent(Node head, int val)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.data == val) return true;
            else temp = temp.next;
        }
        return false;
    }
}

public class Node
{
    public int data;
    public Node next;

    public Node(int data, Node next)
    {
        this.data = data;
        this.next = next;
    }

    public Node(int data)
    {
        this.data = data;
        this.next = null;
    }
}
