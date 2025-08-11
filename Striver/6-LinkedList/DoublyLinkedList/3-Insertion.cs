namespace dsaproblem.Striver.LinkedList.DoublyLinkedList;

public class Insertion
{
    public static void Brute()
    {
        int[] a = { 1, 2, 3, 4 };
        Node head = Intro.ArrayToLL(a);
        Node newHead = InsertHead(head, 100);
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
}
