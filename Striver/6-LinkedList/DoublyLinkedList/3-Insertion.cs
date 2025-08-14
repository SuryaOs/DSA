namespace dsaproblem.Striver.LinkedList.DoublyLinkedList;

public class Insertion
{
    public static void Brute()
    {
        int[] a = { 1, 2, 3, 4 };
        Node head = Intro.ArrayToDLL(a);
        // Node newHead = InsertHead(head, 100);
        // Node newHead = InsertTail(head, 100);
        // Node newHead = InsertBeforeK(head, 100, 3);
        Node newHead = InsertBeforeNode(head.next, 100) ?? head;
        Intro.Print(newHead);
    }

    public static Node InsertHead(Node head, int val)
    {
        if (head == null)
            return new Node(val);
        var newHead = new Node(val);
        newHead.back = null;
        newHead.next = head;
        head.back = newHead;

        return newHead;
    }

    public static Node InsertTail(Node head, int val)
    {
        if (head == null)
            return null;
        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        Node newNode = new Node(val, temp, temp.back);
        temp.back.next = newNode;
        temp.back = newNode;
        return head;
    }

    public static Node InsertBeforeK(Node head, int val, int k)
    {
        if (head == null)
            return null;
        if (k == 1)
            return InsertHead(head, val);
        int count = 0;
        Node temp = head;
        while (temp != null)
        {
            if (++count == k)
            {
                Node newNode = new Node(val, temp, temp.back);
                temp.back.next = newNode;
                temp.back = newNode;
                break;
            }
            temp = temp.next;
        }
        return head;
    }
    public static Node InsertBeforeNode(Node temp, int val)
    {
        if (temp == null) return null;
        if (temp.back == null) return InsertHead(temp, val);
        Node newNode = new Node(val, temp, temp.back);
        temp.back.next = newNode;
        temp.back = newNode;
        return null;
    }
}
