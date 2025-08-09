namespace dsaproblem.Striver.LinkedList;

public class Deletion
{
    public static void Brute()
    {
        int[] arr = { 1, 2, 3, 4 };
        Node head = Intro.ArrayToLL(arr);
        // Node newHead = DeleteHead(head);
        // Intro.Print(newHead);
        // Node headT = DeleteTail(head);
        // Intro.Print(headT);
        // Node headDk = DeleteK(head, 5);
        // Node headDk = DeleteKOpti(head, 2);
        Node headDk = DeleteValue(head, 5);
        Intro.Print(headDk);
    }
    public static Node DeleteHead(Node head)
    {
        if (head == null) return null;
        head = head.next; // gc will delete the head from memory as it is not referenced any where
        return head;
    }
    public static Node DeleteTail(Node head)
    {
        if (head == null || head.next == null) return null;
        Node temp = head;
        while (temp.next.next != null)
        {
            temp = temp.next;
        }
        temp.next = null;
        return head;
    }
    public static Node DeleteK(Node head, int k)
    {
        if (head == null) return null;
        if (k == 1) return DeleteHead(head);
        Node temp = head;
        int count = 0;
        while (temp != null && temp.next != null)
        {
            if (++count == k - 1)
            {
                temp.next = temp.next.next;
                break;
            }
            temp = temp.next;
        }
        return head;
    }
    public static Node DeleteKOpti(Node head, int k)
    {
        if (head == null) return null;
        if (k == 1) return DeleteHead(head);
        Node temp = head;
        Node prev = null;
        int count = 0;
        while (temp != null)
        {
            count++;
            if (count == k)
            {
                prev.next = temp.next; // prev.next.next
                break;
            }
            prev = temp;
            temp = temp.next;
        }
        return head;
    }
    public static Node DeleteValue(Node head, int k)
    {
        if (head == null) return null;
        if (head.data == k) return DeleteHead(head);
        Node temp = head;
        Node prev = temp;
        while (temp != null)
        {
            if (temp.data == k)
            {
                prev.next = temp.next;
                break;
            }
            prev = temp;
            temp = temp.next;
        }
        return head;
    }
}