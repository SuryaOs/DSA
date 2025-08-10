namespace dsaproblem.Striver.LinkedList.DoublyLinkedList;

public class Intro
{
    public static void Brute()
    {
        int[] a = { 1, 2, 3, 4 };
        Node head = ArrayToLL(a);
        Print(head);
    }

    public static Node ArrayToLL(int[] arr)
    {
        Node head = new Node(arr[0], null, null);
        Node temp = head;
        for (int i = 1; i < arr.Length; i++)
        {
            temp.next = new Node(arr[i], null, temp);
            temp = temp.next;
        }
        return head;
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
}

public class Node
{
    public int data;
    public Node next;
    public Node back;

    public Node(int data, Node next, Node back)
    {
        this.data = data;
        this.next = next;
        this.back = back;
    }

    public Node(int data)
    {
        this.data = data;
        this.next = null;
        this.back = null;
    }
}
