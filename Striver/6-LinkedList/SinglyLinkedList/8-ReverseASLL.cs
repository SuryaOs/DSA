namespace dsaproblem.Striver.LinkedList.SinglyLinkedList;

public class ReverseASLL
{
    public static void Brute()
    {
        int[] a = { 1, 2, 3, 4, 5 };
        Node head = Intro.ArrayToLL(a);
        // ReverseStack(head);
        Node newHead = ReverseLink(head);
        Intro.Print(newHead);
    }

    private static Node ReverseStack(Node head)
    {
        Node temp = head;
        Stack<int> stack = new();
        while (temp != null)
        {
            stack.Push(temp.data);
            temp = temp.next;
        }
        temp = head;
        while (temp != null)
        {
            temp.data = stack.Pop();
            temp = temp.next;
        }
        return head;
    }

    private static Node ReverseLink(Node head)
    {
        if (head == null || head.next == null) return head;
        Node temp = head;
        Node prev = null;
        while (temp != null)
        {
            Node front = temp.next;
            temp.next = prev;
            prev = temp;
            temp = front;
        }
        return prev;
    }
}
