namespace dsaproblem.Striver.LinkedList.SinglyLinkedList;

public class RotateALL
{
    public static void Brute()
    {
        int[] a = { 1, 2, 3, 4, 5 };
        Node head = Intro.ArrayToLL(a);
        Node nH = Rotate(head, 2);
        Intro.Print(nH);
    }
    private static Node Rotate(Node head, int k)
    {
        if (head == null || k == 0) return head;

        Node temp = head;
        int count = 1;
        while (temp.next != null)
        {
            count++;
            temp = temp.next;
        }
        temp.next = head;

        // For Larger Numbers
        if (k % count == 0) return head;
        k = k % count;
        //

        count = count - k;
        while (count-- > 0)
        {
            temp = temp.next;
        }
        head = temp.next;
        temp.next = null;
        return head;
    }
}