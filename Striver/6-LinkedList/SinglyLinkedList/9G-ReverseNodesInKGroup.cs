namespace dsaproblem.Striver.LinkedList.SinglyLinkedList;

public class ReverseNodesInKGroup
{
    public static void Brute()
    {
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 }; // 321 654 78
        Node head = Intro.ArrayToLL(a);
        Node nH = Reverse(head, 3);
        Intro.Print(nH);
    }
    private static Node Reverse(Node head, int k)
    {
        Node temp = head;
        Node prev = null;
        while (temp != null)
        {
            Node K = FindKthNode(temp, k);
            if (K != null)
            {
                Node next = K.next;
                K.next = null;
                Node nH = ReverseASLL.ReverseLink(temp);
                if (prev == null) head = K;
                else prev.next = nH;

                prev = temp;
                temp = next;
            }
            else
            {
                prev.next = temp;
                temp = null;
            }
        }
        return head;
    }
    private static Node FindKthNode(Node temp, int k)
    {
        while (temp != null && --k > 0)
        {
            temp = temp.next;
        }
        return temp;
    }
}