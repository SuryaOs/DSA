namespace dsaproblem.Striver.LinkedList.SinglyLinkedList;

public class LengthOfLoop
{
    public static void Brute()
    {
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        Node node = Intro.ArrayToLL(a);
        node.next.next.next.next.next.next.next.next.next.next = node.next.next.next.next;
        // int len = Length(node);
        // int len = LengthOptimal(node);
        int len = FindOptimal(node);
        Console.WriteLine(len);
    }
    private static int Length(Node head)
    {
        Node temp = head;
        Dictionary<Node, int> map = new Dictionary<Node, int>();
        int count = 0;
        while (temp != null)
        {
            count++;
            if (map.ContainsKey(temp))
            {
                return count - map[temp];
            }
            map.Add(temp, count);
            temp = temp.next;
        }
        return 0;
    }
    private static int LengthOptimal(Node head)
    {
        Node slow = head;
        Node fast = head;
        while (fast != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
            {
                return FindIt(slow, fast);
            }
        }
        return 0;
    }
    private static int FindIt(Node slow, Node fast)
    {
        int count = 1;
        fast = fast.next;
        while (slow != fast)
        {
            count++;
            fast = fast.next;
        }
        return count;
    }


    // it won't work for all the cases, not good
    private static int FindOptimal(Node head)
    {
        Node slow = head;
        Node fast = head;
        int sCount = 0;
        while (fast != null)
        {
            sCount++;
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
            {
                return sCount;
            }
        }
        return 0;
    }
}