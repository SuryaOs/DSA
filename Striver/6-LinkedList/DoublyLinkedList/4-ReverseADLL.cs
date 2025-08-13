namespace dsaproblem.Striver.LinkedList.DoublyLinkedList;

public class ReverseADLL
{
    public static void Brute()
    {
        int[] a = { 1, 2, 3, 4 };
        Node head = Intro.ArrayToLL(a);
        // Node newHead = Reverse(head);
        Node newHead = ReverseLink(head);
        Intro.Print(newHead);
    }
    public static Node ReverseStack(Node head)
    {
        Node temp = head;
        Stack<int> st = new();
        while (temp != null)
        {
            st.Push(temp.data);
            temp = temp.next;
        }
        temp = head;
        while (temp != null)
        {
            temp.data = st.Pop(); ;
            temp = temp.next;
        }
        return head;
    }
    public static Node ReverseLink(Node head)
    {
        if (head == null || head.next == null) return head;
        Node temp = head;
        Node back = null;
        while (temp != null)
        {
            back = temp.back;
            temp.back = temp.next;
            temp.next = back;

            temp = temp.back;
        }
        return back.back;
    }
}
