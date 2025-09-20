namespace dsaproblem.Striver.LinkedList.SinglyLinkedList;

public class DeleteMiddleNode
{
    public static void Brute()
    {
        int[] a = { 1, 2, 3, 4, 5, 6, 7 };
        Node head = Intro.ArrayToLL(a);
        DeleteMiddle(head);
        Intro.Print(head);
    }

    // Brute Force Is => find length of the node, delete N/2 + 1 node
    // Another way is => create a node prev to keep track of previous node  (tortoise and Hare with Prev Node to delete middle note coz slow will be pointing to delete, so we can't delete without prev)
    private static Node DeleteMiddle(Node head)
    {
        Node fast = head.next.next; // we skip slow 1 time, coz no need to reach mid to delete mid, need to reach 1 node before mid
        Node slow = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }
        slow.next = slow.next.next;
        return head;
    }
}
