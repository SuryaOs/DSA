namespace dsaproblem.Striver.LinkedList.SinglyLinkedList;

public class StartingPointOfLoop
{
    public static void Brute()
    {
        int[] a = { 1, 2, 3, 4, 5, 6 };
        Node node = Intro.ArrayToLL(a);
        node.next.next.next.next.next.next = node.next.next; // Creating A Looooooooooooooo
        // Node newHead = Starting(node);
        Node newHead = Optimal(node);
        Console.WriteLine(newHead.data);
    }
    private static Node Starting(Node head)
    {
        Node temp = head;
        Stack<Node> stack = new();
        while (temp != null)
        {
            if (stack.Contains(temp))
            {
                return temp;
            }
            stack.Push(temp);
            temp = temp.next;
        }
        return null;
    }
    // Tricky but easy, There is an formula behind it
    private static Node Optimal(Node head)
    {
        Node slow = head;
        Node fast = head;
        while (fast != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
            {
                slow = head;
                while (slow != fast)
                {
                    slow = slow.next;
                    fast = fast.next;
                }
                return slow;
            }
        }
        return null;
    }
}