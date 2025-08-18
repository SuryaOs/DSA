namespace dsaproblem.Striver.LinkedList.SinglyLinkedList;

public class MiddleOfSLL
{
    public static void Brute()
    {
        int[] a = { 1, 2, 3, 4, 5, 6};
        Node head = Intro.ArrayToLL(a);
        Node middle = Mid(head);
        Console.WriteLine(middle.data);
    }
    private static Node Mid(Node head)
    {
        Node temp = head;
        int count = 0;
        while (temp != null)
        {
            count++;
            temp = temp.next;
        }
        int mid = (count / 2) + 1;
        temp = head;
        while (--mid > 0)
        {
            temp = temp.next;
        }
        return temp;
    }
    // Tortoise and Hare -> Fast Pointer
    private static Node Middle(Node head)
    {
        Node fast = head;
        Node slow = head;
        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
        }
        return slow;
    }
}