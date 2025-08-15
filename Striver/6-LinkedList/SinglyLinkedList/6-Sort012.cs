namespace dsaproblem.Striver.LinkedList.SinglyLinkedList;

public class Sort012
{
    public static void Brute()
    {
        int[] a = { 2, 1,1};
        Node node = Intro.ArrayToLL(a);
        // Node head = Sort(node);
        Node head = SumLink(node);
        Intro.Print(head);
    }

    public static Node Sort(Node head)
    {
        Node temp = head;
        int c0 = 0,
            c1 = 0,
            c2 = 0;
        while (temp != null)
        {
            if (temp.data == 0)
                c0++;
            else if (temp.data == 1)
                c1++;
            else if (temp.data == 2)
                c2++;
            temp = temp.next;
        }
        temp = head;
        while (c0-- > 0)
        {
            temp.data = 0;
            temp = temp.next;
        }
        while (c1-- > 0)
        {
            temp.data = 1;
            temp = temp.next;
        }
        while (c2-- > 0)
        {
            temp.data = 2;
            temp = temp.next;
        }
        return head;
    }

    private static Node SumLink(Node head)
    {
        Node temp = head;
        Node n0 = new(-1); Node n0Head = n0;
        Node n1 = new(-1); Node n1Head = n1;
        Node n2 = new(-1); Node n2Head = n2;
        while (temp != null)
        {
            if (temp.data == 0)
            {
                n0.next = temp;
                n0 = temp;
            }
            else if (temp.data == 1)
            {
                n1.next = temp;
                n1 = temp;
            }
            else
            {
                n2.next = temp;
                n2 = temp;
            }
            temp = temp.next;
        }
        n0.next = n1Head.next ?? n2Head.next;
        n1.next = n2Head.next;
        n2.next = null;
        return n0Head.next;
    }
}
