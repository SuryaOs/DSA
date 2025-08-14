namespace dsaproblem.Striver.LinkedList.SinglyLinkedList;

public class Insertion
{
    public static void Brute()
    {
        int[] arr = { 1, 2, 3, 4 };
        Node head = Intro.ArrayToLL(arr);
        // Node newHead = InsertHead(null, 100);
        // Node newHead = InsertTail(null, 100);
        // Node newHead = InsertK(head, 3, 100);
        Node newHead = InsertBefore(head, 10, 5);
        Intro.Print(newHead);
    }

    public static Node InsertHead(Node head, int value)
    {
        return new Node(value, head);
    }

    public static Node InsertTail(Node head, int value)
    {
        if (head == null)
            return new Node(value);
        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.next = new Node(value);
        return head;
    }

    public static Node InsertK(Node head, int k, int value)
    {
        if (head == null)
        {
            if (k == 1)
                return new Node(value);
            else
                return null;
        }
        if (k == 1)
            return InsertHead(head, value);

        Node temp = head;
        int count = 0;
        while (temp != null)
        {
            if (++count == k - 1)
            {
                Node newNode = new Node(value, temp.next);
                temp.next = newNode;
                break;
            }
            temp = temp.next;
        }
        return head;
    }
    public static Node InsertBefore(Node head, int val, int k)
    {
        if (head == null) return null;
        if (head.data == k) return new Node(val, head);
        Node temp = head;
        Node prev = null;
        while (temp != null)
        {
            if (temp.data == k)
            {
                var n = new Node(val);
                n.next = temp;
                prev.next = n;
            }
            prev = temp;
            temp = temp.next;
        }
        return head;
    }
}
