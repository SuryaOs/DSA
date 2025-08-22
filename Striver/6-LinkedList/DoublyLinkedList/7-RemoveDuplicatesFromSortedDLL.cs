namespace dsaproblem.Striver.LinkedList.DoublyLinkedList;

public class RemoveDuplicatesFromSortedDLL
{
    public static void Brute()
    {
        int[] a = { 1, 1, 1, 2, 3, 3, 4 };
        Node head = Intro.ArrayToDLL(a);
        Node result = RemoveOpti(head);
        Intro.Print(result);
    }

    // I tried but it doesn't work for (1, 1, 1) :/
    public static Node Remove(Node head)
    {
        Node a = head;
        Node b = head.next;
        while (b != null)
        {
            if (a.data == b.data)
            {
                b = b.next;
            }
            else
            {
                a.next = b;
                b.back = a;

                b = b.next;
                a = a.next;
            }
        }
        return head;
    }
    public static Node RemoveOpti(Node head)
    {
        Node a = head;
        Node b = head;
        while (a != null)
        {
            b = a.next;
            while (b != null && a.data == b.data)
            {
                b = b.next;
            }
            a.next = b;
            if(b != null) b.back = a;

            a = a.next;
        }
        return head;
    }
}