using dsaproblem.Striver.LinkedList.DoublyLinkedList;

namespace Striver.SinglyLinkedList;

public class DetectALoop
{
    public static void Brute()
    {
        int[] a = { 1, 2, 3, 4, 5, 6 };
        Node node = Intro.ArrayToDLL(a);
        node.next.next.next.next.next.next = node.next.next; // Creating A Looooooooooooooo
        bool isLoop = DetectLoopWithNoSpace(node);
        Console.WriteLine(isLoop);
    }
    private static bool DetectLoop(Node head)
    {
        Node temp = head;
        Stack<Node> st = new();
        while (temp != null)
        {
            if (st.Contains(temp)) return true;
            st.Push(temp);
            temp = temp.next;
        }
        return false;
    }
    private static bool DetectLoopWithNoSpace(Node head)
    {
        Node slow = head;
        Node fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast) return true;
        }
        return false;
    }
}