namespace dsaproblem.Striver.LinkedList.SinglyLinkedList;

public class DeleteNthNodeFromBack
{
    public static void Brute()
    {
        int[] a = { 1, 2, 3, 4, 5 };
        Node head = Intro.ArrayToLL(a);
        Node newHead = DeleteN(head, 2);
        Intro.Print(newHead);
    }

    private static Node DeleteN(Node head, int n)
    {
        Node fast = head;
        Node slow = head;
        while (n-- > 0)
        {
            fast = fast.next;
        }
        while (fast.next != null)
        {
            fast = fast.next;
            slow = slow.next;
        }
        slow.next = slow.next.next;
        return head;
    }
}
