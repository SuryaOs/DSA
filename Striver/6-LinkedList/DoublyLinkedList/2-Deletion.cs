namespace dsaproblem.Striver.LinkedList.DoublyLinkedList;

public class Deletion
{
    public static void Brute()
    {
        int[] a = { 1, 2, 3, 4 };
        Node head = Intro.ArrayToLL(a);
        // Node newHead = DeleteHead(head);
        // Node newHead = DeleteTail(head);
        Node newHead = DeleteK(head, 0);
        Intro.Print(newHead);
    }

    public static Node DeleteHead(Node head)
    {
        if (head == null || head.next == null)
            return null;

        head = head.next;
        head.back = null;
        return head;
    }

    public static Node DeleteTail(Node head)
    {
        if (head == null || head.next == null)
            return null;
        Node temp = head;
        while (temp.next != null)
        {
            temp = temp.next;
        }
        temp.back.next = null;
        return head;
    }

    public static Node DeleteK(Node head, int k)
    {
        if (head == null || head.next == null)
            return null;
        if (k == 1)
            return DeleteHead(head);
        int count = 0;
        Node temp = head;
        while (temp != null)
        {
            if (++count == k)
            {
                temp.back.next = temp.next;
                if (temp.next != null)
                    temp.next.back = temp.back;
                break;
            }
            temp = temp.next;
        }
        return head;
    }
}
